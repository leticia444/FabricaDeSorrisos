namespace FabricaDeSorrisos.UI.Forms.Sub_Categorias
{
    partial class frmCriarSubCategoria
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            btnCriar = new Guna.UI2.WinForms.Guna2Button();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
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
            btnFechar.Location = new Point(850, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            // 
            // btnCriar
            // 
            btnCriar.BorderRadius = 10;
            btnCriar.CustomizableEdges = customizableEdges3;
            btnCriar.DisabledState.BorderColor = Color.DarkGray;
            btnCriar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriar.FillColor = Color.LimeGreen;
            btnCriar.Font = new Font("Segoe UI", 9F);
            btnCriar.ForeColor = Color.Black;
            btnCriar.Location = new Point(319, 175);
            btnCriar.Name = "btnCriar";
            btnCriar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCriar.Size = new Size(225, 56);
            btnCriar.TabIndex = 1;
            btnCriar.Text = "Criar Sub-Categoria";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(291, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 47);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Criar Sub-Categoria";
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 10;
            txtNome.CustomizableEdges = customizableEdges1;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(291, 98);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o Nome da Sub-Categoria";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNome.Size = new Size(286, 60);
            txtNome.TabIndex = 3;
            // 
            // frmCriarSubCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(900, 390);
            Controls.Add(txtNome);
            Controls.Add(lblTitulo);
            Controls.Add(btnCriar);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCriarSubCategoria";
            Text = "frmCriarSubCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2Button btnCriar;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
    }
}