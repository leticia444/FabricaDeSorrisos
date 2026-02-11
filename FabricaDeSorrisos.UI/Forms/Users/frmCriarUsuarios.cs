using FabricaDeSorrisos.UI.Models.Services;
using FabricaDeSorrisos.UI.ViewModels.UserViewModels;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmCriarUsuarios : Form
    {
        private readonly UserService _userService;

        public frmCriarUsuarios(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void frmCriarUsuarios_Load(object sender, EventArgs e)
        {
            cbTipoUsuario.Items.Clear();
            cbTipoUsuario.Items.Add("Admin");
            cbTipoUsuario.Items.Add("Gerente");
            cbTipoUsuario.Items.Add("Cliente");

            cbTipoUsuario.SelectedIndex = 0;
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            try
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

                var novoUsuario = new UserViewModel
                {
                    Nome = txtNome.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Senha = txtSenha.Text,
                    TipoUsuario = cbTipoUsuario.SelectedItem.ToString()!
                };

                var sucesso = await _userService.Criar(novoUsuario);

                if (sucesso)
                {
                    MessageBox.Show("Usuário criado com sucesso!");
                    LimparCampos();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao criar usuário.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbTipoUsuario.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
