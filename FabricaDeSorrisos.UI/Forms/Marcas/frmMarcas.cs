using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaDeSorrisos.UI.Services;
using FabricaDeSorrisos.UI.Forms.Marcas;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmMarcas : Form
    {
        private readonly CatalogService _catalogService = new CatalogService();
        private readonly MarcaService _marcaService = new MarcaService();

        public frmMarcas()
        {
            InitializeComponent();
            Load += frmMarcas_Load;
            btnCriarMarca.Click += BtnCriarMarca_Click;
            btnEditarMarca.Click += BtnEditarMarca_Click;
            btnExcluirMarca.Click += BtnExcluirMarca_Click;
        }

        private async void frmMarcas_Load(object? sender, EventArgs e)
        {
            ConfigurarGrid();
            await RecarregarAsync();
        }

        private void ConfigurarGrid()
        {
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.MultiSelect = false;
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.Columns.Clear();
            var colId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                ReadOnly = true
            };
            var colNome = new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome da Marca",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
                FillWeight = 1
            };
            guna2DataGridView1.Columns.Add(colId);
            guna2DataGridView1.Columns.Add(colNome);
        }

        private async Task RecarregarAsync()
        {
            var marcas = await _catalogService.GetMarcasAsync();
            guna2DataGridView1.DataSource = marcas;
        }

        private async void BtnCriarMarca_Click(object? sender, EventArgs e)
        {
            using var dlg = new frmCriarMarca();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await RecarregarAsync();
            }
        }

        private int? ObterIdSelecionado()
        {
            if (guna2DataGridView1.CurrentRow == null) return null;
            var row = guna2DataGridView1.CurrentRow.DataBoundItem;
            if (row is CatalogService.MarcaItem item) return item.Id;
            var idCell = guna2DataGridView1.CurrentRow.Cells["Id"]?.Value;
            if (idCell is int id) return id;
            if (int.TryParse(idCell?.ToString(), out var parsed)) return parsed;
            return null;
        }

        private string? ObterNomeSelecionado()
        {
            if (guna2DataGridView1.CurrentRow == null) return null;
            var row = guna2DataGridView1.CurrentRow.DataBoundItem;
            if (row is CatalogService.MarcaItem item) return item.Nome;
            return guna2DataGridView1.CurrentRow.Cells["Nome"]?.Value?.ToString();
        }

        private async void BtnEditarMarca_Click(object? sender, EventArgs e)
        {
            var id = ObterIdSelecionado();
            if (id == null)
            {
                MessageBox.Show("Selecione uma marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var nome = ObterNomeSelecionado() ?? string.Empty;
            using var dlg = new frmEditarMarca(id.Value, nome);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await RecarregarAsync();
            }
        }

        private async void BtnExcluirMarca_Click(object? sender, EventArgs e)
        {
            var id = ObterIdSelecionado();
            if (id == null)
            {
                MessageBox.Show("Selecione uma marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nome = ObterNomeSelecionado() ?? $"ID {id}";
            var confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir a marca \"{nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var ok = await _marcaService.DeleteAsync(id.Value);
            if (!ok)
            {
                MessageBox.Show("Não foi possível excluir a marca. Verifique a API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await RecarregarAsync();
        }
    }
}
