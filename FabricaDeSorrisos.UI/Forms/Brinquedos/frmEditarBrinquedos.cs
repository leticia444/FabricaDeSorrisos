using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaDeSorrisos.UI.ViewModels.Brinquedos;
using FabricaDeSorrisos.UI.Api;

namespace FabricaDeSorrisos.UI.Forms.Brinquedos
{
    public partial class frmEditarBrinquedos : Form
    {
        private BrinquedoViewModel _model;
        private static readonly HttpClient _imgClient = new HttpClient();
        public string? NovaImagemBase64 { get; private set; }
        public string? NovaImagemNomeArquivo { get; private set; }

        public frmEditarBrinquedos()
        {
            InitializeComponent();
            WireEvents();
        }

        public frmEditarBrinquedos(BrinquedoViewModel model)
        {
            InitializeComponent();
            _model = model;
            WireEvents();
            PreencherCampos();
        }

        private void WireEvents()
        {
            guna2CircleButton1.Click += Guna2CircleButton1_Click;
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    e.Handled = true;
                    Close();
                }
            };
        }

        private void Guna2CircleButton1_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private async void PreencherCampos()
        {
            if (_model == null) return;
            txtNome.Text = _model.Nome;
            txtEstoque.Text = _model.Estoque.ToString();
            txtPreço.Text = _model.Preco.ToString("0.00");
            txtDescricao.Text = _model.Descricao ?? string.Empty;

            cbCategoria.Items.Clear();
            if (!string.IsNullOrWhiteSpace(_model.Categoria))
            {
                cbCategoria.Items.Add(_model.Categoria);
                cbCategoria.SelectedIndex = 0;
            }

            cbMarca.Items.Clear();
            if (!string.IsNullOrWhiteSpace(_model.Marca))
            {
                cbMarca.Items.Add(_model.Marca);
                cbMarca.SelectedIndex = 0;
            }

            cbFaixaEtaria.Items.Clear();
            if (!string.IsNullOrWhiteSpace(_model.FaixaEtaria))
            {
                cbFaixaEtaria.Items.Add(_model.FaixaEtaria);
                cbFaixaEtaria.SelectedIndex = 0;
            }

            cbPersonagem.Items.Clear();
            if (!string.IsNullOrWhiteSpace(_model.Personagem))
            {
                cbPersonagem.Items.Add(_model.Personagem);
                cbPersonagem.SelectedIndex = 0;
            }

            await CarregarImagemAtualAsync();
            btnTrocarImagem.Click += BtnTrocarImagem_Click;
        }

        private async Task CarregarImagemAtualAsync()
        {
            if (string.IsNullOrWhiteSpace(_model?.ImagemUrl))
            {
                picImagem.Image = null;
                return;
            }
            var path = _model.ImagemUrl.Trim();
            if (path.StartsWith("~/")) path = path.Substring(1);
            if (!path.StartsWith("/")) path = "/" + path;
            var apiBase = new Uri(ApiSettings.BaseUrl);
            var apiHost = $"{apiBase.Scheme}://{apiBase.Host}{(apiBase.IsDefaultPort ? "" : ":" + apiBase.Port)}";
            var candidates = _model.ImagemUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                ? new[] { _model.ImagemUrl }
                : new[]
                {
                    ApiSettings.WebBaseUrl.TrimEnd('/') + path,
                    ApiSettings.WebBaseUrlHttps.TrimEnd('/') + path,
                    apiHost.TrimEnd('/') + "/static" + path
                };
            foreach (var url in candidates)
            {
                try
                {
                    var bytes = await _imgClient.GetByteArrayAsync(url);
                    using var ms = new MemoryStream(bytes);
                    using var temp = Image.FromStream(ms);
                    picImagem.Image = new Bitmap(temp);
                    break;
                }
                catch
                {
                }
            }
        }

        private void BtnTrocarImagem_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Imagens|*.jpg;*.jpeg;*.png;*.webp;*.bmp",
                Title = "Selecione a nova imagem"
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var bytes = File.ReadAllBytes(dlg.FileName);
                using var ms = new MemoryStream(bytes);
                using var temp = Image.FromStream(ms);
                picImagem.Image = new Bitmap(temp);
                NovaImagemBase64 = Convert.ToBase64String(bytes);
                NovaImagemNomeArquivo = Path.GetFileName(dlg.FileName);
            }
        }

        private async void btnEditar_Click(object? sender, EventArgs e)
        {
            if (_model == null) return;
            if (!decimal.TryParse(txtPreço.Text, out var preco)) preco = _model.Preco;
            if (!int.TryParse(txtEstoque.Text, out var estoque)) estoque = _model.Estoque;

            var service = new FabricaDeSorrisos.UI.Models.Services.BrinquedoService();
            var req = new FabricaDeSorrisos.UI.Models.Services.BrinquedoService.UpdateBrinquedoRequest
            {
                Nome = txtNome.Text?.Trim(),
                Descricao = txtDescricao.Text?.Trim(),
                Preco = preco,
                Estoque = estoque,
                ImagemBase64 = NovaImagemBase64,
                ImagemNomeArquivo = NovaImagemNomeArquivo
            };

            var ok = await service.AtualizarAsync(_model.Id, req);
            if (!ok)
            {
                MessageBox.Show("Falha ao salvar alterações do brinquedo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Alterações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
