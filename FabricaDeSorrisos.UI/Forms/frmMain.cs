using FabricaDeSorrisos.UI.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Recalcula posição ao redimensionar
            this.Resize += FrmMain_Resize;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 🔒 Segurança centralizada
            if (!UserSession.IsAuthenticated || UserSession.Role != "Admin")
            {
                MessageBox.Show(
                    "Sessão inválida ou acesso não autorizado.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                VoltarParaLogin();
                return;
            }

            // 👤 Mostra apenas o nome (antes do @)
            lblUsuario.Text = ObterNomeUsuario();

            // Ajustes visuais do label
            lblUsuario.AutoSize = true;
            lblUsuario.TextAlignment = ContentAlignment.MiddleCenter;

            CentralizarLblUsuario();

            AplicarPermissoes();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            CentralizarLblUsuario();
        }

        private void CentralizarLblUsuario()
        {
            // Centraliza horizontalmente em relação ao pbIcon
            lblUsuario.Left = pbIcon.Left + (pbIcon.Width - lblUsuario.Width) / 2;

            // Posiciona logo abaixo do ícone
            lblUsuario.Top = pbIcon.Bottom + 8; // espaço de 8px
        }

        private string ObterNomeUsuario()
        {
            if (string.IsNullOrWhiteSpace(UserSession.UserName))
                return "Usuário";

            // Se for email, pega só o nome
            if (UserSession.UserName.Contains("@"))
                return UserSession.UserName.Split('@')[0];

            return UserSession.UserName;
        }

        private void AplicarPermissoes()
        {
            // Somente Admin vê usuários
            btnUsuarios.Visible = UserSession.Role == "Admin";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new frmUsuarios());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new frmCriarProdutos());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            FecharFormsDoPainel();
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
            FecharFormsDoPainel();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }

        private void FecharFormsDoPainel()
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Form f)
                    f.Close();
            }

            panel.Controls.Clear();
        }

        private void VoltarParaLogin()
        {
            new frmLogin().Show();
            Close();
        }
    }
}
