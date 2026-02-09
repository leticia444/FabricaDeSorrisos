using FabricaDeSorrisos.UI.Auth;
using FabricaDeSorrisos.UI.Models;
using FabricaDeSorrisos.UI.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly AuthService _authService;

        public frmLogin()
        {
            InitializeComponent();

            _authService = new AuthService();

            txtSenha.PasswordChar = '●';
            this.AcceptButton = btnEntrar;

            btnEntrar.Click += btnEntrar_Click;
            btnFechar.Click += btnFechar_Click; // 👈 AQUI
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            await RealizarLogin();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 👈 Fecha a aplicação inteira
        }

        private async Task RealizarLogin()
        {
            btnEntrar.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show(
                    "Informe email e senha.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                btnEntrar.Enabled = true;
                return;
            }

            try
            {
                var request = new LoginRequest
                {
                    Email = txtEmail.Text.Trim(),
                    Password = txtSenha.Text
                };

                var response = await _authService.LoginAsync(request);

                // 🚫 Cliente não acessa o sistema administrativo
                if (response.Role == "Cliente")
                {
                    MessageBox.Show(
                        "Usuários do tipo Cliente não têm acesso ao sistema administrativo.",
                        "Acesso negado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    btnEntrar.Enabled = true;
                    return;
                }

                // ✅ Inicia sessão
                UserSession.Token = response.Token;
                UserSession.UserName = response.UserName;
                UserSession.Role = response.Role;

                var main = new frmMain();
                main.Show();

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Email ou senha inválidos.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                btnEntrar.Enabled = true;
            }
        }
    }
}
