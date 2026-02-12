namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmCriarUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            btnCriarUsuario = new Guna.UI2.WinForms.Guna2Button();
            cbTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = customizableEdges12;
            txtEmail.DefaultText = "";
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(484, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges13;
            txtEmail.Size = new Size(220, 50);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges10;
            txtSenha.DefaultText = "";
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.Location = new Point(484, 375);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtSenha.Size = new Size(220, 50);
            txtSenha.TabIndex = 5;
            // 
            // btnCriarUsuario
            // 
            btnCriarUsuario.BorderRadius = 10;
            btnCriarUsuario.CustomizableEdges = customizableEdges8;
            btnCriarUsuario.FillColor = Color.Lime;
            btnCriarUsuario.Font = new Font("Segoe UI", 9F);
            btnCriarUsuario.ForeColor = Color.Black;
            btnCriarUsuario.Location = new Point(493, 480);
            btnCriarUsuario.Name = "btnCriarUsuario";
            btnCriarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnCriarUsuario.Size = new Size(210, 55);
            btnCriarUsuario.TabIndex = 4;
            btnCriarUsuario.Text = "Criar Usuário";
            btnCriarUsuario.Click += btnEntrar_Click;
            // 
            // cbTipoUsuario
            // 
            cbTipoUsuario.BackColor = Color.Transparent;
            cbTipoUsuario.BorderRadius = 10;
            cbTipoUsuario.CustomizableEdges = customizableEdges6;
            cbTipoUsuario.DrawMode = DrawMode.OwnerDrawFixed;
            cbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoUsuario.FocusedColor = Color.Empty;
            cbTipoUsuario.Font = new Font("Segoe UI", 10F);
            cbTipoUsuario.ForeColor = Color.FromArgb(68, 88, 112);
            cbTipoUsuario.ItemHeight = 30;
            cbTipoUsuario.Location = new Point(484, 438);
            cbTipoUsuario.Name = "cbTipoUsuario";
            cbTipoUsuario.ShadowDecoration.CustomizableEdges = customizableEdges7;
            cbTipoUsuario.Size = new Size(220, 36);
            cbTipoUsuario.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 10;
            txtNome.CustomizableEdges = customizableEdges4;
            txtNome.DefaultText = "";
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.Location = new Point(484, 255);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtNome.Size = new Size(220, 50);
            txtNome.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.FillColor = Color.Red;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1222, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // pbLogo
            // 
            pbLogo.CustomizableEdges = customizableEdges1;
            pbLogo.Image = Properties.Resources.add_user;
            pbLogo.ImageRotate = 0F;
            pbLogo.Location = new Point(441, 17);
            pbLogo.Name = "pbLogo";
            pbLogo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pbLogo.Size = new Size(300, 200);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // frmCriarUsuarios
            // 
            ClientSize = new Size(1265, 728);
            Controls.Add(pbLogo);
            Controls.Add(btnFechar);
            Controls.Add(txtNome);
            Controls.Add(cbTipoUsuario);
            Controls.Add(btnCriarUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCriarUsuarios";
            Load += frmCriarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnCriarUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoUsuario;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
    }
}
