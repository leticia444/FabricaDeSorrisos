namespace FabricaDeSorrisos.UI
{
    partial class frmCriarProdutos
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            label1 = new Label();
            txtNomeProduto = new Guna.UI2.WinForms.Guna2TextBox();
            cbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 39);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BorderRadius = 10;
            txtNomeProduto.CustomizableEdges = customizableEdges7;
            txtNomeProduto.DefaultText = "";
            txtNomeProduto.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNomeProduto.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNomeProduto.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNomeProduto.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNomeProduto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeProduto.Font = new Font("Segoe UI", 9F);
            txtNomeProduto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeProduto.Location = new Point(301, 194);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.PlaceholderText = "Nome do Produto";
            txtNomeProduto.SelectedText = "";
            txtNomeProduto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNomeProduto.Size = new Size(200, 36);
            txtNomeProduto.TabIndex = 1;
            // 
            // cbCategoria
            // 
            cbCategoria.BackColor = Color.Transparent;
            cbCategoria.BorderRadius = 10;
            cbCategoria.CustomizableEdges = customizableEdges9;
            cbCategoria.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategoria.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategoria.Font = new Font("Segoe UI", 10F);
            cbCategoria.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategoria.ItemHeight = 30;
            cbCategoria.Location = new Point(301, 236);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbCategoria.Size = new Size(200, 36);
            cbCategoria.TabIndex = 8;
            // 
            // txtPreco
            // 
            txtPreco.BorderRadius = 10;
            txtPreco.CustomizableEdges = customizableEdges11;
            txtPreco.DefaultText = "";
            txtPreco.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPreco.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPreco.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPreco.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPreco.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPreco.Font = new Font("Segoe UI", 9F);
            txtPreco.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPreco.Location = new Point(301, 278);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.SelectedText = "";
            txtPreco.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtPreco.Size = new Size(200, 36);
            txtPreco.TabIndex = 9;
            // 
            // frmCriarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPreco);
            Controls.Add(cbCategoria);
            Controls.Add(txtNomeProduto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCriarProdutos";
            Text = "frmProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeProduto;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
    }
}