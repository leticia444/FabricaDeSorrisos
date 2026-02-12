using FabricaDeSorrisos.UI.Models.Services;
using FabricaDeSorrisos.UI.ViewModels.UserViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmExcluirUsuarios : Form
    {
        private readonly UserService? _userService;
        private readonly int? _usuarioId;

        public frmExcluirUsuarios()
        {
            InitializeComponent();
            Load += frmExcluirUsuarios_Load;
            btnVoltar.Click += btnVoltar_Click;
            btnExcluir.Click += btnExcluir_Click;
        }

        public frmExcluirUsuarios(UserService userService, int? usuarioId = null) : this()
        {
            _userService = userService;
            _usuarioId = usuarioId;
        }

        private async void frmExcluirUsuarios_Load(object? sender, EventArgs e)
        {
            if (_userService == null) return;

            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.MultiSelect = false;
            guna2DataGridView1.AutoGenerateColumns = true;

            var usuarios = await _userService.ListarTodos();
            guna2DataGridView1.DataSource = usuarios;

            if (_usuarioId.HasValue)
            {
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    var item = row.DataBoundItem as UserViewModel;
                    if (item != null && item.Id == _usuarioId.Value)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private async void btnExcluir_Click(object? sender, EventArgs e)
        {
            if (_userService == null) return;

            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            var confirmado = MessageBox.Show("Confirmar exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (confirmado != DialogResult.Yes) return;

            var selecionado = guna2DataGridView1.SelectedRows[0].DataBoundItem as UserViewModel;
            if (selecionado == null)
            {
                MessageBox.Show("Seleção inválida.");
                return;
            }

            var sucesso = await _userService.Excluir(selecionado.Id);
            if (sucesso)
            {
                MessageBox.Show("Usuário excluído com sucesso!");
                var usuarios = await _userService.ListarTodos();
                guna2DataGridView1.DataSource = usuarios;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Falha ao excluir usuário.");
            }
        }

        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
