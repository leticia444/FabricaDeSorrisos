using FabricaDeSorrisos.UI.Models.Services;
using FabricaDeSorrisos.UI.ViewModels.UserViewModels;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmCadastro : Form
    {
        private readonly UserService _userService;

        public frmCadastro()
        {
            InitializeComponent();
            _userService = new UserService();

            txtSenha.PasswordChar = '●';
            txtSenhaNovamente.PasswordChar = '●';

            btnCriar.Click += btnCriar_Click;
            btnVoltarLogin.Click += btnVoltarLogin_Click;
        }

        private async void btnCriar_Click(object sender, System.EventArgs e)
        {
            var nome = txtNome.Text?.Trim() ?? string.Empty;
            var email = txtEmail.Text?.Trim() ?? string.Empty;
            var senha = txtSenha.Text ?? string.Empty;
            var senha2 = txtSenhaNovamente.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(senha2))
            {
                MessageBox.Show(
                    "Preencha todos os campos obrigatórios.",
                    "Campos obrigatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!senha.Equals(senha2))
            {
                MessageBox.Show(
                    "As senhas não coincidem.",
                    "Validação de senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!SenhaValida(senha))
            {
                MessageBox.Show(
                    "A senha não atende os níveis de complexidade. Ela deve ter pelo menos 12 caracteres, incluindo maiúscula, minúscula, número e caractere especial.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                var usuario = new UserViewModel
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    TipoUsuario = "Gerente"
                };

                var ok = await _userService.Criar(usuario);

                if (ok)
                {
                    MessageBox.Show(
                        "Usuário criado com sucesso. Você já pode fazer login.",
                        "Cadastro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    var login = new frmLogin();
                    login.Show();
                    Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível criar o usuário.\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVoltarLogin_Click(object sender, System.EventArgs e)
        {
            var login = new frmLogin();
            login.Show();
            Close();
        }

        private bool SenhaValida(string senha)
        {
            if (senha.Length < 12) return false;
            var temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
            var temMinuscula = Regex.IsMatch(senha, "[a-z]");
            var temNumero = Regex.IsMatch(senha, "[0-9]");
            var temEspecial = Regex.IsMatch(senha, "[^a-zA-Z0-9]");
            return temMaiuscula && temMinuscula && temNumero && temEspecial;
        }
    }
}
