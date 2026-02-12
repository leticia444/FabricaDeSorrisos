using FabricaDeSorrisos.UI.Models.Services;
using FabricaDeSorrisos.UI.ViewModels.UserViewModels;
using System.Linq;
using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmEditarUsuarios : Form
    {
        private readonly UserService _userService;
        private readonly int? _usuarioId;
        private Guna2DataGridView _grid;

        public frmEditarUsuarios(UserService userService, int? usuarioId = null)
        {
            InitializeComponent();
            _userService = userService;
            _usuarioId = usuarioId;

            Load += frmEditarUsuarios_Load;
            btnFechar.Click += btnFechar_Click;
            btnEntrar.Click += btnEntrar_Click;
        }

        private async void frmEditarUsuarios_Load(object? sender, EventArgs e)
        {
            cbTipoUsuario.Items.Clear();
            cbTipoUsuario.Items.Add("Admin");
            cbTipoUsuario.Items.Add("Gerente");
            cbTipoUsuario.Items.Add("Cliente");
            cbTipoUsuario.SelectedIndex = 0;

            _grid = new Guna2DataGridView
            {
                Location = new System.Drawing.Point(120, 245),
                Size = new System.Drawing.Size(500, 340),
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoGenerateColumns = true
            };
            Controls.Add(_grid);
            _grid.SelectionChanged += Grid_SelectionChanged;

            var usuariosLista = await _userService.ListarTodos();
            _grid.DataSource = usuariosLista;

            if (_usuarioId.HasValue)
            {
                foreach (DataGridViewRow row in _grid.Rows)
                {
                    var item = row.DataBoundItem as UserViewModel;
                    if (item != null && item.Id == _usuarioId.Value)
                    {
                        row.Selected = true;
                        PreencherCampos(item);
                        break;
                    }
                }
            }
        }

        private void Grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count == 0) return;
            var item = _grid.SelectedRows[0].DataBoundItem as UserViewModel;
            if (item == null) return;
            PreencherCampos(item);
        }

        private void PreencherCampos(UserViewModel usuario)
        {
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            var idx = cbTipoUsuario.Items
                .Cast<string>()
                .ToList()
                .FindIndex(x => x.Equals(usuario.TipoUsuario, StringComparison.OrdinalIgnoreCase));
            cbTipoUsuario.SelectedIndex = idx >= 0 ? idx : 0;
        }

        private async void btnEntrar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Informe o e-mail.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Informe a senha.");
                return;
            }
            if (cbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo de usuário.");
                return;
            }

            int? id = null;
            if (_grid.SelectedRows.Count > 0)
            {
                var item = _grid.SelectedRows[0].DataBoundItem as UserViewModel;
                if (item != null) id = item.Id;
            }
            else if (_usuarioId.HasValue)
            {
                id = _usuarioId.Value;
            }
            else
            {
                MessageBox.Show("Selecione um usuário na lista.");
                return;
            }

            var atualizado = new UserViewModel
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Senha = txtSenha.Text,
                TipoUsuario = cbTipoUsuario.SelectedItem!.ToString()!
            };

            var sucesso = await _userService.Atualizar(id.Value, atualizado);
            if (sucesso)
            {
                MessageBox.Show("Usuário atualizado com sucesso!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao atualizar usuário.");
            }
        }

        private void btnFechar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
