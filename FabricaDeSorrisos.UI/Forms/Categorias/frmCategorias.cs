using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FabricaDeSorrisos.UI.Services;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmCategorias : Form
    {
        private readonly CatalogService _catalogService = new CatalogService();
        private readonly CategoryService _categoryService = new CategoryService();

        public frmCategorias()
        {
            InitializeComponent();
            Load += frmCategorias_Load;
            btnCriarCategoria.Click += BtnCriarCategoria_Click;
            btnEditarCategoria.Click += BtnEditarCategoria_Click;
            btnExcluirCategoria.Click += BtnExcluirCategoria_Click;
            gridCategorias.CellDoubleClick += (s, e) => BtnEditarCategoria_Click(s, e);
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private async void frmCategorias_Load(object? sender, EventArgs e)
        {
            ConfigurarGrid();
            await RecarregarAsync();
        }

        private void ConfigurarGrid()
        {
            gridCategorias.ReadOnly = true;
            gridCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategorias.MultiSelect = false;
            gridCategorias.AutoGenerateColumns = false;
            gridCategorias.Columns.Clear();
            gridCategorias.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "ID", Width = 80 });
            gridCategorias.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nome", DataPropertyName = "Nome", HeaderText = "Nome", Width = 300 });
        }

        private async Task RecarregarAsync()
        {
            var categorias = await _catalogService.GetCategoriasAsync();
            var dados = categorias.Select(c => new { c.Id, c.Nome }).ToList();
            gridCategorias.DataSource = dados;
        }

        private void BtnCriarCategoria_Click(object? sender, EventArgs e)
        {
            using var frm = new Categorias.frmCriarCategoria();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                _ = RecarregarAsync();
            }
        }

        private (int id, string nome)? ObterSelecionada()
        {
            if (gridCategorias.CurrentRow == null) return null;
            var idCell = gridCategorias.CurrentRow.Cells["Id"] ?? gridCategorias.CurrentRow.Cells[0];
            var nomeCell = gridCategorias.CurrentRow.Cells["Nome"] ?? gridCategorias.CurrentRow.Cells[1];
            var id = Convert.ToInt32(idCell.Value);
            var nome = Convert.ToString(nomeCell.Value) ?? "";
            return (id, nome);
        }

        private void BtnEditarCategoria_Click(object? sender, EventArgs e)
        {
            var sel = ObterSelecionada();
            if (sel == null)
            {
                MessageBox.Show("Selecione uma categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using var frm = new Categorias.frmEditarCategoria(sel.Value.id, sel.Value.nome);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                _ = RecarregarAsync();
            }
        }

        private async void BtnExcluirCategoria_Click(object? sender, EventArgs e)
        {
            var sel = ObterSelecionada();
            if (sel == null)
            {
                MessageBox.Show("Selecione uma categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirm = MessageBox.Show($"Deseja excluir a Categoria \"{sel.Value.nome}\"?",
                "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var ok = await _categoryService.DeleteAsync(sel.Value.id);
            if (!ok)
            {
                MessageBox.Show("Não foi possível excluir a categoria. Verifique a API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Categoria excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await RecarregarAsync();
        }
    }
}
