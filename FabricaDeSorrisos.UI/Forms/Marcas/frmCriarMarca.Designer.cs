namespace FabricaDeSorrisos.UI.Forms.Marcas
{
    partial class frmCriarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            txtNomeCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCriar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Red;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1187, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pbLogo
            // 
            pbLogo.CustomizableEdges = customizableEdges8;
            pbLogo.Image = Properties.Resources.add_marca_icon;
            pbLogo.ImageRotate = 0F;
            pbLogo.Location = new Point(523, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.ShadowDecoration.CustomizableEdges = customizableEdges9;
            pbLogo.Size = new Size(163, 134);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.CustomizableEdges = customizableEdges6;
            guna2PictureBox2.Image = Properties.Resources.mais;
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(692, 12);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2PictureBox2.Size = new Size(97, 76);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox2.TabIndex = 2;
            guna2PictureBox2.TabStop = false;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.BorderRadius = 10;
            txtNomeCategoria.CustomizableEdges = customizableEdges4;
            txtNomeCategoria.DefaultText = "";
            txtNomeCategoria.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNomeCategoria.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNomeCategoria.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNomeCategoria.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNomeCategoria.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeCategoria.Font = new Font("Segoe UI", 9F);
            txtNomeCategoria.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeCategoria.Location = new Point(494, 243);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.PlaceholderText = "Digite o nome da marca";
            txtNomeCategoria.SelectedText = "";
            txtNomeCategoria.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtNomeCategoria.Size = new Size(222, 48);
            txtNomeCategoria.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15F);
            guna2HtmlLabel1.Location = new Point(494, 207);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(213, 30);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Digite o nome da marca";
            // 
            // btnCriar
            // 
            btnCriar.BorderRadius = 10;
            btnCriar.CustomizableEdges = customizableEdges2;
            btnCriar.DisabledState.BorderColor = Color.DarkGray;
            btnCriar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriar.FillColor = Color.LimeGreen;
            btnCriar.Font = new Font("Segoe UI", 9F);
            btnCriar.ForeColor = Color.White;
            btnCriar.Location = new Point(500, 570);
            btnCriar.Name = "btnCriar";
            btnCriar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnCriar.Size = new Size(204, 57);
            btnCriar.TabIndex = 5;
            btnCriar.Text = "Criar Marca";
            // 
            // frmCriarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1249, 689);
            Controls.Add(btnCriar);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txtNomeCategoria);
            Controls.Add(guna2PictureBox2);
            Controls.Add(pbLogo);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCriarMarca";
            Text = "frmCriarMarca";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnCriar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeCategoria;
    }
}