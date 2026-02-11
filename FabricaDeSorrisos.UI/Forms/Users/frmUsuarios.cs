using FabricaDeSorrisos.UI.Models.Services;
using FabricaDeSorrisos.UI.ViewModels.UserViewModels;
using System.Drawing;
using System.Linq;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmUsuarios : Form
    {
        private readonly UserService _userService;

        public frmUsuarios(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void frmUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarGrids();
            await CarregarUsuarios();
        }

        // =========================
        // CARREGAMENTO
        // =========================

        private async Task CarregarUsuarios()
        {
            var usuarios = await _userService.ListarTodos();

            guna2DataGridView3.DataSource =
                usuarios.Where(u =>
                    !string.IsNullOrWhiteSpace(u.TipoUsuario) &&
                    u.TipoUsuario.Contains("Admin", StringComparison.OrdinalIgnoreCase))
                .ToList();

            guna2DataGridView1.DataSource =
                usuarios.Where(u =>
                    !string.IsNullOrWhiteSpace(u.TipoUsuario) &&
                    u.TipoUsuario.Contains("Gerente", StringComparison.OrdinalIgnoreCase))
                .ToList();

            guna2DataGridView2.DataSource =
                usuarios.Where(u =>
                    !string.IsNullOrWhiteSpace(u.TipoUsuario) &&
                    u.TipoUsuario.Contains("Cliente", StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // =========================
        // CONFIGURAÇÃO DOS GRIDS
        // =========================

        private void ConfigurarGrids()
        {
            ConfigurarGrid(guna2DataGridView1);
            ConfigurarGrid(guna2DataGridView2);
            ConfigurarGrid(guna2DataGridView3);
        }

        private void ConfigurarGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;

            grid.BorderStyle = BorderStyle.None;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersHeight = 35;

            grid.DataBindingComplete += Grid_DataBindingComplete;
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns.Contains("Id"))
            {
                grid.Columns["Id"].HeaderText = "ID";
                grid.Columns["Id"].FillWeight = 15;
                grid.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns["Id"].DisplayIndex = 0;
            }

            if (grid.Columns.Contains("Nome"))
            {
                grid.Columns["Nome"].HeaderText = "Nome";
                grid.Columns["Nome"].FillWeight = 45;
                grid.Columns["Nome"].DisplayIndex = 1;
            }

            if (grid.Columns.Contains("Email"))
            {
                grid.Columns["Email"].HeaderText = "Email";
                grid.Columns["Email"].FillWeight = 40;
                grid.Columns["Email"].DisplayIndex = 2;
            }

            // esconder colunas que não devem aparecer
            if (grid.Columns.Contains("TipoUsuario"))
                grid.Columns["TipoUsuario"].Visible = false;

            if (grid.Columns.Contains("Senha"))
                grid.Columns["Senha"].Visible = false;
        }

        // =========================
        // CRUD
        // =========================

        private async void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            // PASSANDO O USERSERVICE PARA O FORM
            var frm = new frmCriarUsuarios(_userService);
            frm.ShowDialog();

            await CarregarUsuarios();
        }

        private async void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            var frm = new frmEditarUsuarios();
            frm.ShowDialog();

            await CarregarUsuarios();
        }

        private async void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            var frm = new frmExcluirUsuarios();
            frm.ShowDialog();

            await CarregarUsuarios();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}