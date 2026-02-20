using FabricaDeSorrisos.UI.Models.Services;
using FabricaDeSorrisos.UI.ViewModels.Brinquedos;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using FabricaDeSorrisos.UI.Api;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmBrinquedos : Form
    {
        private readonly BrinquedoService _service;
        private static readonly HttpClient _imgClient = new HttpClient();
        private static readonly string _webBaseUrl = ApiSettings.WebBaseUrl;
        private static readonly string _webBaseUrlHttps = ApiSettings.WebBaseUrlHttps;
        private static readonly ConcurrentDictionary<string, Image> _imageCache = new();
        private static readonly Image _placeholder = new Bitmap(1, 1);

        public frmBrinquedos()
        {
            InitializeComponent();
            _service = new BrinquedoService();
            Load += frmBrinquedos_Load;
            btnCriarBrinquedo.Click += BtnCriar_Click;
            btnEditarBrinquedo.Click += BtnEditar_Click;
            btnStatusBrinquedo.Click += BtnStatus_Click;
            guna2DataGridView1.DataBindingComplete += Grid_DataBindingComplete;
        }

        private async void frmBrinquedos_Load(object sender, EventArgs e)
        {
            ConfigurarGrid(guna2DataGridView1);
            await CarregarDados();
        }

        private async Task CarregarDados()
        {
            var paged = await _service.ListarAsync(pageIndex: 1, pageSize: 100);
            guna2DataGridView1.DataSource = paged.Items;

            var qtd = paged.TotalCount;
            var estoqueTotal = paged.Items.Sum(i => i.Estoque);
        }

        private void ConfigurarGrid(Guna2DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoGenerateColumns = false;
            grid.RowTemplate.Height = 64;

            grid.Columns.Clear();
            var imgCol = new DataGridViewImageColumn
            {
                HeaderText = "Imagem",
                Name = "colImagem",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 96
            };
            imgCol.DefaultCellStyle.NullValue = _placeholder;
            grid.Columns.Add(imgCol);
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Id), HeaderText = "ID", Width = 60 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Nome), HeaderText = "Nome", Width = 200 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Estoque), HeaderText = "Estoque", Width = 80 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Preco), HeaderText = "Preço", Width = 90 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Descricao), HeaderText = "Descrição", Width = 260 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.FaixaEtaria), HeaderText = "Faixa Etária", Width = 100 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Marca), HeaderText = "Marca", Width = 120 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Categoria), HeaderText = "Categoria", Width = 120 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.SubCategoria), HeaderText = "Subcategoria", Width = 120 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Personagem), HeaderText = "Personagem", Width = 120 });
            grid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BrinquedoViewModel.Status), HeaderText = "Status", Width = 90 });
        }

        private async void Grid_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            await CarregarImagensAsync(guna2DataGridView1);
        }

        private async Task CarregarImagensAsync(Guna2DataGridView grid)
        {
            var imgColName = "colImagem";
            // Garante a existência da coluna de imagem mesmo se não tiver sido criada
            if (!grid.Columns.Contains(imgColName))
            {
                var newImg = new DataGridViewImageColumn
                {
                    HeaderText = "Imagem",
                    Name = imgColName,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 90
                };
                // insere como primeira coluna
                grid.Columns.Insert(0, newImg);
            }

            // Obtém o índice da coluna de imagem de forma segura
            int imgIndex = grid.Columns[imgColName].Index;

            foreach (DataGridViewRow row in grid.Rows)
            {
                var vm = row.DataBoundItem as BrinquedoViewModel;
                if (vm == null) continue;
                if (string.IsNullOrWhiteSpace(vm.ImagemUrl))
                {
                    row.Cells[imgIndex].Value = null;
                    continue;
                }
                var path = vm.ImagemUrl.Trim();
                if (path.StartsWith("~/")) path = path.Substring(1); // normaliza ~/ para /
                if (!path.StartsWith("/")) path = "/" + path;       // garante barra inicial
                try
                {
                    // Base da API sem o /api/ (para /static)
                    var apiBase = new Uri(ApiSettings.BaseUrl);
                    var apiHost = $"{apiBase.Scheme}://{apiBase.Host}{(apiBase.IsDefaultPort ? "" : ":" + apiBase.Port)}";

                    var candidates = vm.ImagemUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                        ? new[] { vm.ImagemUrl }
                        : new[]
                        {
                            _webBaseUrl.TrimEnd('/') + path,
                            _webBaseUrlHttps.TrimEnd('/') + path,
                            apiHost.TrimEnd('/') + "/static" + path
                        };

                    Image? img = null;
                    foreach (var url in candidates)
                    {
                        if (_imageCache.TryGetValue(url, out var cached))
                        {
                            img = cached;
                            break;
                        }
                        try
                        {
                            var bytes = await _imgClient.GetByteArrayAsync(url);
                            using var ms = new MemoryStream(bytes);
                            using var temp = Image.FromStream(ms);
                            img = new Bitmap(temp);
                            _imageCache[url] = img;
                            break;
                        }
                        catch
                        {
                            // tenta próximo candidato
                        }
                    }

                    if (img == null) img = _placeholder;
                    row.Cells[imgIndex].Value = img;
                }
                catch
                {
                    row.Cells[imgIndex].Value = _placeholder;
                }
            }
        }

        private void BtnCriar_Click(object? sender, EventArgs e)
        {
            var frm = new frmCriarBrinquedos();
            Hide();
            frm.ShowDialog(this);
            Show();
            _ = CarregarDados();
        }

        private async void BtnStatus_Click(object? sender, EventArgs e)
        {
            var selecionado = ObterSelecionado();
            if (selecionado == null)
            {
                MessageBox.Show("Selecione um brinquedo no grid.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var desejaAtivar = !selecionado.Ativo;
            var acaoTexto = desejaAtivar ? "ativar" : "desativar";

            var confirmar = MessageBox.Show(
                $"Deseja {acaoTexto} o brinquedo '{selecionado.Nome}' (ID {selecionado.Id})?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool ok;
                if (desejaAtivar)
                    ok = await _service.AtivarAsync(selecionado.Id);
                else
                    ok = await _service.DesativarAsync(selecionado.Id);

                if (!ok)
                {
                    MessageBox.Show("Operação não concluída pela API. Verifique se o endpoint de status está disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar status do brinquedo.\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await CarregarDados();
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var selecionado = ObterSelecionado();
            if (selecionado == null)
            {
                MessageBox.Show("Selecione um brinquedo no grid.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new Brinquedos.frmEditarBrinquedos(selecionado);
            frm.ShowDialog(this);
            _ = CarregarDados();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBrinquedosCadastrados_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private BrinquedoViewModel? ObterSelecionado()
        {
            if (guna2DataGridView1.CurrentRow == null) return null;
            return guna2DataGridView1.CurrentRow.DataBoundItem as BrinquedoViewModel;
        }
    }
}
