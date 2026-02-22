using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmSubCategorias : Form
    {
        private readonly UI.Services.SubCategoriaService _subService = new UI.Services.SubCategoriaService();
        private readonly UI.Services.CatalogService _catalogService = new UI.Services.CatalogService();

        public frmSubCategorias()
        {
            InitializeComponent();
            Load += FrmSubCategorias_Load;
            ConfigurarGrid();
            VincularEventos();
        }

        private void VincularEventos()
        {
            // Os nomes dos controles vêm do Designer
            btnCriarSubCategoria.Click += BtnCriarSubCategoria_Click;
            btnEditarSubCategoria.Click += BtnEditarSubCategoria_Click;
            btnExcluirSubCategoria.Click += BtnExcluirSubCategoria_Click;
        }

        private async void FrmSubCategorias_Load(object? sender, EventArgs e)
        {
            await RecarregarAsync();
        }

        private void ConfigurarGrid()
        {
            gridCategorias.ReadOnly = true;
            gridCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategorias.MultiSelect = false;
            gridCategorias.AutoGenerateColumns = false;
            gridCategorias.Columns.Clear();
            gridCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                Width = 80
            });
            gridCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome da Subcategoria",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private async Task RecarregarAsync()
        {
            var lista = await _subService.GetAllAsync();
            gridCategorias.DataSource = lista;
        }

        private async void BtnCriarSubCategoria_Click(object? sender, EventArgs e)
        {
            using var form = new Sub_Categorias.frmCriarSubCategoria();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Nome já validado dentro do form
                var nome = form.Tag as string ?? string.Empty;
                int categoriaId = await ObterCategoriaPadraoAsync();
                if (categoriaId <= 0)
                {
                    MessageBox.Show("Nenhuma categoria encontrada para associar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var ok = await _subService.CreateAsync(nome, categoriaId);
                if (ok)
                    await RecarregarAsync();
                else
                    MessageBox.Show("Não foi possível criar a subcategoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnEditarSubCategoria_Click(object? sender, EventArgs e)
        {
            if (gridCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma subcategoria para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = (int)gridCategorias.SelectedRows[0].Cells["Id"].Value;
            var nomeAtual = gridCategorias.SelectedRows[0].Cells["Nome"].Value?.ToString() ?? "";
            using var form = new Sub_Categorias.frmEditarSubCategorias(id, nomeAtual);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var novoNome = form.Tag as string ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    var ok = await _subService.UpdateAsync(id, novoNome);
                    if (ok)
                        await RecarregarAsync();
                    else
                        MessageBox.Show("Não foi possível salvar a edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnExcluirSubCategoria_Click(object? sender, EventArgs e)
        {
            if (gridCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma subcategoria para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = (int)gridCategorias.SelectedRows[0].Cells["Id"].Value;
            var nome = gridCategorias.SelectedRows[0].Cells["Nome"].Value?.ToString() ?? "";
            var result = MessageBox.Show($"Tem certeza que deseja excluir a Sub-Categoria \"{nome}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var ok = await _subService.DeleteAsync(id);
                if (ok)
                    await RecarregarAsync();
                else
                    MessageBox.Show("Não foi possível excluir a subcategoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<int> ObterCategoriaPadraoAsync()
        {
            // Estratégia: usar a primeira categoria disponível
            var categorias = await _catalogService.GetCategoriasAsync();
            return categorias.FirstOrDefault()?.Id ?? 0;
        }
    }
}
