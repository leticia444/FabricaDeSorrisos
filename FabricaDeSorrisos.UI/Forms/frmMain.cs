using FabricaDeSorrisos.UI.Models;
using System;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 🔒 Segurança
            if (!UserSession.IsAuthenticated)
            {
                MessageBox.Show("Sessão expirada. Faça login novamente.");
                VoltarParaLogin();
                return;
            }

            lblUsuario.Text = $"{UserSession.UserName} ({UserSession.Role})";

            AplicarPermissoes();
        }

        private void AplicarPermissoes()
        {
            // Apenas Admin vê usuários
            if (UserSession.Role != "Admin")
            {
                guna2Button1.Visible = false;
            }

            // Cliente não entra
            if (UserSession.Role == "Cliente")
            {
                MessageBox.Show("Acesso não permitido para este perfil.");
                VoltarParaLogin();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new frmProdutos());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            painel.Controls.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja sair do sistema?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UserSession.Logout();
                VoltarParaLogin();
            }
        }

        private void AbrirFormNoPainel(Form form)
        {
            painel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            painel.Controls.Add(form);
            form.Show();
        }

        private void VoltarParaLogin()
        {
            new frmLogin().Show();
            this.Close();
        }
    }
}
