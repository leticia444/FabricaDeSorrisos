using FabricaDeSorrisos.UI.Models;
using System;
using System.Windows.Forms;
using FabricaDeSorrisos.UI.Models.Services;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmMain : Form
    {
        private readonly UserService _userService;

        public frmMain(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
            this.Resize += FrmMain_Resize;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsAuthenticated)
            {
                MessageBox.Show(
                    "Sessão inválida.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                VoltarParaLogin();
                return;
            }

            lblUsuario.Text = ObterNomeUsuario();
            CentralizarLblUsuario();
            AplicarPermissoes();
        }

        // =====================
        // AJUSTES DE LAYOUT
        // =====================

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            CentralizarLblUsuario();
        }

        private void CentralizarLblUsuario()
        {
            lblUsuario.Left = pbIcon.Left + (pbIcon.Width - lblUsuario.Width) / 2;
            lblUsuario.Top = pbIcon.Bottom + 8;
        }

        private string ObterNomeUsuario()
        {
            if (string.IsNullOrWhiteSpace(UserSession.UserName))
                return "Usuário";

            if (UserSession.UserName.Contains("@"))
                return UserSession.UserName.Split('@')[0];

            return UserSession.UserName;
        }

        private void AplicarPermissoes()
        {
            bool isAdmin = UserSession.Role == "Admin";

            btnUsuario.Visible = isAdmin;
            lblUsuários.Visible = isAdmin;
        }

        // =====================
        // BOTÕES → FORMULÁRIOS
        // =====================

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new frmUsuarios(_userService).ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
            => AbrirFormulario(new frmCategorias());

        private void btnSubCategoria_Click(object sender, EventArgs e)
            => AbrirFormulario(new frmSubCategorias());

        private void btnPersonagem_Click(object sender, EventArgs e)
            => AbrirFormulario(new frmPersonagens());

        private void btnBrinquedos_Click(object sender, EventArgs e)
            => AbrirFormulario(new frmBrinquedos());

        private void btnMarcas_Click(object sender, EventArgs e)
            => AbrirFormulario(new frmMarcas());

        private void btnPedidos_Click(object sender, EventArgs e)
            => AbrirFormulario(new frmPedidos());

        // =====================
        // CONTROLES GERAIS
        // =====================

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

        private void AbrirFormulario(Form form)
        {
            Hide();

            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosed += (s, e) => Show();
            form.Show();
        }

        private void VoltarParaLogin()
        {
            new frmLogin().Show();
            Close();
        }
    }
}
