namespace FabricaDeSorrisos.UI.Forms.Personagens
{
    partial class frmEditarPersonagens
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnConfirmarEdição = new Guna.UI2.WinForms.Guna2Button();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            txtNomePersonagem = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbEscolherPersonagem = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnConfirmarEdição
            // 
            btnConfirmarEdição.BorderRadius = 10;
            btnConfirmarEdição.CustomizableEdges = customizableEdges6;
            btnConfirmarEdição.DisabledState.BorderColor = Color.DarkGray;
            btnConfirmarEdição.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirmarEdição.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirmarEdição.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirmarEdição.FillColor = Color.DeepSkyBlue;
            btnConfirmarEdição.Font = new Font("Segoe UI", 9F);
            btnConfirmarEdição.ForeColor = Color.White;
            btnConfirmarEdição.Location = new Point(333, 295);
            btnConfirmarEdição.Name = "btnConfirmarEdição";
            btnConfirmarEdição.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnConfirmarEdição.Size = new Size(225, 56);
            btnConfirmarEdição.TabIndex = 0;
            btnConfirmarEdição.Text = "Confirmar Edição";
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
            btnFechar.Location = new Point(857, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            // 
            // txtNomePersonagem
            // 
            txtNomePersonagem.BorderRadius = 10;
            txtNomePersonagem.CustomizableEdges = customizableEdges3;
            txtNomePersonagem.DefaultText = "";
            txtNomePersonagem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNomePersonagem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNomePersonagem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNomePersonagem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNomePersonagem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomePersonagem.Font = new Font("Segoe UI", 9F);
            txtNomePersonagem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomePersonagem.Location = new Point(296, 182);
            txtNomePersonagem.Margin = new Padding(3, 4, 3, 4);
            txtNomePersonagem.Name = "txtNomePersonagem";
            txtNomePersonagem.PlaceholderText = "Digite o novo Nome para o Personagem";
            txtNomePersonagem.SelectedText = "";
            txtNomePersonagem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNomePersonagem.Size = new Size(305, 60);
            txtNomePersonagem.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(301, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 47);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Edite um Personagem";
            // 
            // cbEscolherPersonagem
            // 
            cbEscolherPersonagem.AccessibleDescription = "";
            cbEscolherPersonagem.BackColor = Color.Transparent;
            cbEscolherPersonagem.BorderRadius = 10;
            cbEscolherPersonagem.CustomizableEdges = customizableEdges1;
            cbEscolherPersonagem.DrawMode = DrawMode.OwnerDrawFixed;
            cbEscolherPersonagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEscolherPersonagem.FocusedColor = Color.FromArgb(94, 148, 255);
            cbEscolherPersonagem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbEscolherPersonagem.Font = new Font("Segoe UI", 10F);
            cbEscolherPersonagem.ForeColor = Color.FromArgb(68, 88, 112);
            cbEscolherPersonagem.ItemHeight = 30;
            cbEscolherPersonagem.Location = new Point(304, 139);
            cbEscolherPersonagem.Name = "cbEscolherPersonagem";
            cbEscolherPersonagem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbEscolherPersonagem.Size = new Size(286, 36);
            cbEscolherPersonagem.TabIndex = 4;
            // 
            // frmEditarBrinquedo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(900, 450);
            Controls.Add(cbEscolherPersonagem);
            Controls.Add(lblTitulo);
            Controls.Add(txtNomePersonagem);
            Controls.Add(btnFechar);
            Controls.Add(btnConfirmarEdição);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarBrinquedo";
            Text = "frmEditarBrinquedo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cbEscolherPersonagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtNomePersonagem;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2Button btnConfirmarEdição;
    }
}