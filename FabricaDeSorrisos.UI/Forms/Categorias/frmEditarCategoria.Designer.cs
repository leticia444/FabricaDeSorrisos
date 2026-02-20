namespace FabricaDeSorrisos.UI.Forms.Categorias
{
    partial class frmEditarCategoria
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSalvarEdicao = new Guna.UI2.WinForms.Guna2Button();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            txtNomeCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            cbEscolherCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // btnSalvarEdicao
            // 
            btnSalvarEdicao.BorderRadius = 10;
            btnSalvarEdicao.CustomizableEdges = customizableEdges1;
            btnSalvarEdicao.DisabledState.BorderColor = Color.DarkGray;
            btnSalvarEdicao.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvarEdicao.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvarEdicao.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvarEdicao.FillColor = Color.DeepSkyBlue;
            btnSalvarEdicao.Font = new Font("Segoe UI", 9F);
            btnSalvarEdicao.ForeColor = Color.White;
            btnSalvarEdicao.Location = new Point(340, 301);
            btnSalvarEdicao.Margin = new Padding(3, 4, 3, 4);
            btnSalvarEdicao.Name = "btnSalvarEdicao";
            btnSalvarEdicao.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalvarEdicao.Size = new Size(216, 60);
            btnSalvarEdicao.TabIndex = 0;
            btnSalvarEdicao.Text = "Salvar Edição";
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
            btnFechar.Location = new Point(850, 13);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
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
            txtNomeCategoria.Location = new Point(332, 216);
            txtNomeCategoria.Margin = new Padding(3, 5, 3, 5);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.PlaceholderText = "Digite o novo nome da Categoria";
            txtNomeCategoria.SelectedText = "";
            txtNomeCategoria.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtNomeCategoria.Size = new Size(229, 48);
            txtNomeCategoria.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(332, 36);
            lblTitulo.Margin = new Padding(3, 4, 3, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(285, 47);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Nome da Categoria";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cbEscolherCategoria
            // 
            cbEscolherCategoria.BackColor = Color.Transparent;
            cbEscolherCategoria.BorderRadius = 10;
            cbEscolherCategoria.CustomizableEdges = customizableEdges6;
            cbEscolherCategoria.DrawMode = DrawMode.OwnerDrawFixed;
            cbEscolherCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEscolherCategoria.FocusedColor = Color.FromArgb(94, 148, 255);
            cbEscolherCategoria.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbEscolherCategoria.Font = new Font("Segoe UI", 10F);
            cbEscolherCategoria.ForeColor = Color.FromArgb(68, 88, 112);
            cbEscolherCategoria.ItemHeight = 30;
            cbEscolherCategoria.Location = new Point(340, 158);
            cbEscolherCategoria.Name = "cbEscolherCategoria";
            cbEscolherCategoria.ShadowDecoration.CustomizableEdges = customizableEdges7;
            cbEscolherCategoria.Size = new Size(209, 36);
            cbEscolherCategoria.TabIndex = 7;
            // 
            // frmEditarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(900, 450);
            Controls.Add(cbEscolherCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(txtNomeCategoria);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvarEdicao);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEditarCategoria";
            Text = "frmEditarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSalvarEdicao;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cbEscolherCategoria;
    }
}