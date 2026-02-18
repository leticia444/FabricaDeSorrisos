using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmBrinquedos : Form
    {
        private readonly Models.Services.BrinquedoService _service;

        public frmBrinquedos()
        {
            InitializeComponent();
            _service = new Models.Services.BrinquedoService();
        }

        private async void frmBrinquedos_Load(object sender, EventArgs e)
        {
            ConfigurarGrid(gridBrinquedos);
            await CarregarDados();
        }

        private async Task CarregarDados()
        {
            var paged = await _service.ListarAsync(pageIndex: 1, pageSize: 100);
            gridBrinquedos.DataSource = paged.Items;

            var qtd = paged.TotalCount;
            var estoqueTotal = paged.Items.Sum(i => i.Estoque);
        }

        private void ConfigurarGrid(Guna.UI2.WinForms.Guna2DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoGenerateColumns = true;
        }

        private void BtnCriar_Click(object? sender, EventArgs e)
        {
            var frm = new frmCriarBrinquedos();
            Hide();
            frm.ShowDialog(this);
            Show();
        }

        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            var frm = new Brinquedos.frmExcluirBrinquedos();
            Hide();
            frm.ShowDialog(this);
            Show();
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var frm = new Brinquedos.frmEditarBrinquedos();
            Hide();
            frm.ShowDialog(this);
            Show();
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
    }
}
