namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmBrinquedos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTituloLista = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCriarBrinquedo = new Guna.UI2.WinForms.Guna2GradientButton();
            btnStatusBrinquedo = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEditarBrinquedo = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBrinquedosCadastrados = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblBrinquedoCadastrado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTituloLista
            // 
            lblTituloLista.BackColor = Color.Transparent;
            lblTituloLista.Font = new Font("Segoe UI", 16F);
            lblTituloLista.Location = new Point(14, 8);
            lblTituloLista.Margin = new Padding(3, 4, 3, 4);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(224, 32);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Brinquedos cadastrados";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 32;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(2, 285);
            guna2DataGridView1.Margin = new Padding(3, 2, 3, 2);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 29;
            guna2DataGridView1.Size = new Size(1173, 395);
            guna2DataGridView1.TabIndex = 13;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20F);
            guna2HtmlLabel1.Location = new Point(10, 9);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(290, 39);
            guna2HtmlLabel1.TabIndex = 17;
            guna2HtmlLabel1.Text = "Catálogo de Brinquedos";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // btnCriarBrinquedo
            // 
            btnCriarBrinquedo.BorderRadius = 10;
            btnCriarBrinquedo.CustomizableEdges = customizableEdges5;
            btnCriarBrinquedo.DisabledState.BorderColor = Color.DarkGray;
            btnCriarBrinquedo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriarBrinquedo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriarBrinquedo.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCriarBrinquedo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriarBrinquedo.FillColor = Color.HotPink;
            btnCriarBrinquedo.FillColor2 = Color.Yellow;
            btnCriarBrinquedo.Font = new Font("Segoe UI", 9F);
            btnCriarBrinquedo.ForeColor = Color.Black;
            btnCriarBrinquedo.Image = Properties.Resources.plus;
            btnCriarBrinquedo.ImageAlign = HorizontalAlignment.Left;
            btnCriarBrinquedo.Location = new Point(967, 11);
            btnCriarBrinquedo.Margin = new Padding(3, 2, 3, 2);
            btnCriarBrinquedo.Name = "btnCriarBrinquedo";
            btnCriarBrinquedo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCriarBrinquedo.Size = new Size(197, 42);
            btnCriarBrinquedo.TabIndex = 19;
            btnCriarBrinquedo.Text = "Criar Brinquedo";
            // 
            // btnStatusBrinquedo
            // 
            btnStatusBrinquedo.BorderRadius = 10;
            btnStatusBrinquedo.CustomizableEdges = customizableEdges3;
            btnStatusBrinquedo.DisabledState.BorderColor = Color.DarkGray;
            btnStatusBrinquedo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStatusBrinquedo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStatusBrinquedo.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnStatusBrinquedo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStatusBrinquedo.FillColor = Color.Wheat;
            btnStatusBrinquedo.Font = new Font("Segoe UI", 9F);
            btnStatusBrinquedo.ForeColor = Color.Black;
            btnStatusBrinquedo.Location = new Point(967, 131);
            btnStatusBrinquedo.Margin = new Padding(3, 2, 3, 2);
            btnStatusBrinquedo.Name = "btnStatusBrinquedo";
            btnStatusBrinquedo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnStatusBrinquedo.Size = new Size(197, 42);
            btnStatusBrinquedo.TabIndex = 21;
            btnStatusBrinquedo.Text = "Ativar/Desativar Brinquedo";
            // 
            // btnEditarBrinquedo
            // 
            btnEditarBrinquedo.BorderRadius = 10;
            btnEditarBrinquedo.CustomizableEdges = customizableEdges1;
            btnEditarBrinquedo.DisabledState.BorderColor = Color.DarkGray;
            btnEditarBrinquedo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarBrinquedo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarBrinquedo.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEditarBrinquedo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarBrinquedo.FillColor = Color.Aqua;
            btnEditarBrinquedo.FillColor2 = Color.Yellow;
            btnEditarBrinquedo.Font = new Font("Segoe UI", 9F);
            btnEditarBrinquedo.ForeColor = Color.Black;
            btnEditarBrinquedo.Image = Properties.Resources.lapis4;
            btnEditarBrinquedo.ImageAlign = HorizontalAlignment.Left;
            btnEditarBrinquedo.Location = new Point(967, 71);
            btnEditarBrinquedo.Margin = new Padding(3, 2, 3, 2);
            btnEditarBrinquedo.Name = "btnEditarBrinquedo";
            btnEditarBrinquedo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEditarBrinquedo.Size = new Size(197, 42);
            btnEditarBrinquedo.TabIndex = 22;
            btnEditarBrinquedo.Text = "Editar Brinquedo";
            // 
            // lblBrinquedosCadastrados
            // 
            lblBrinquedosCadastrados.BackColor = Color.Transparent;
            lblBrinquedosCadastrados.Font = new Font("Segoe UI", 15F);
            lblBrinquedosCadastrados.Location = new Point(0, 0);
            lblBrinquedosCadastrados.Margin = new Padding(3, 2, 3, 2);
            lblBrinquedosCadastrados.Name = "lblBrinquedosCadastrados";
            lblBrinquedosCadastrados.Size = new Size(215, 30);
            lblBrinquedosCadastrados.TabIndex = 14;
            lblBrinquedosCadastrados.Text = "Brinquedos Cadastrados";
            lblBrinquedosCadastrados.Click += lblBrinquedosCadastrados_Click;
            // 
            // lblBrinquedoCadastrado
            // 
            lblBrinquedoCadastrado.BackColor = Color.Transparent;
            lblBrinquedoCadastrado.Font = new Font("Segoe UI", 15F);
            lblBrinquedoCadastrado.Location = new Point(2, 250);
            lblBrinquedoCadastrado.Name = "lblBrinquedoCadastrado";
            lblBrinquedoCadastrado.Size = new Size(215, 30);
            lblBrinquedoCadastrado.TabIndex = 23;
            lblBrinquedoCadastrado.Text = "Brinquedos Cadastrados";
            // 
            // frmBrinquedos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1176, 679);
            Controls.Add(lblBrinquedoCadastrado);
            Controls.Add(btnEditarBrinquedo);
            Controls.Add(btnStatusBrinquedo);
            Controls.Add(btnCriarBrinquedo);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2DataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBrinquedos";
            Text = "frmBrinquedos";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTituloLista;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCriarBrinquedo;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditarBrinquedo;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatusBrinquedo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrinquedosCadastrados;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrinquedoCadastrado;
    }
}
