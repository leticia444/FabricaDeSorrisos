namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmCategorias
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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            gridCategorias = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCategoriasCadastradas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCriarCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEditarCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExcluirCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // gridCategorias
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gridCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridCategorias.ColumnHeadersHeight = 36;
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            gridCategorias.GridColor = Color.FromArgb(231, 229, 255);
            gridCategorias.Location = new Point(0, 330);
            gridCategorias.Margin = new Padding(3, 4, 3, 4);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.RowHeadersVisible = false;
            gridCategorias.RowHeadersWidth = 51;
            gridCategorias.RowTemplate.Height = 25;
            gridCategorias.Size = new Size(1314, 293);
            gridCategorias.TabIndex = 18;
            gridCategorias.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridCategorias.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridCategorias.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridCategorias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridCategorias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridCategorias.ThemeStyle.BackColor = Color.White;
            gridCategorias.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridCategorias.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gridCategorias.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCategorias.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridCategorias.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridCategorias.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridCategorias.ThemeStyle.HeaderStyle.Height = 36;
            gridCategorias.ThemeStyle.ReadOnly = false;
            gridCategorias.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridCategorias.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCategorias.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridCategorias.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridCategorias.ThemeStyle.RowsStyle.Height = 25;
            gridCategorias.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridCategorias.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(431, 47);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Gerenciamento de Categorias";
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // lblCategoriasCadastradas
            // 
            lblCategoriasCadastradas.BackColor = Color.Transparent;
            lblCategoriasCadastradas.Font = new Font("Segoe UI", 15F);
            lblCategoriasCadastradas.ForeColor = Color.Black;
            lblCategoriasCadastradas.Location = new Point(0, 280);
            lblCategoriasCadastradas.Name = "lblCategoriasCadastradas";
            lblCategoriasCadastradas.Size = new Size(264, 37);
            lblCategoriasCadastradas.TabIndex = 20;
            lblCategoriasCadastradas.Text = "Categorias Cadastradas";
            // 
            // btnCriarCategoria
            // 
            btnCriarCategoria.BorderRadius = 10;
            btnCriarCategoria.CustomizableEdges = customizableEdges5;
            btnCriarCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnCriarCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriarCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriarCategoria.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCriarCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriarCategoria.FillColor = Color.HotPink;
            btnCriarCategoria.FillColor2 = Color.Yellow;
            btnCriarCategoria.Font = new Font("Segoe UI", 9F);
            btnCriarCategoria.ForeColor = Color.Black;
            btnCriarCategoria.Image = Properties.Resources.plus1;
            btnCriarCategoria.ImageAlign = HorizontalAlignment.Left;
            btnCriarCategoria.Location = new Point(1076, 22);
            btnCriarCategoria.Name = "btnCriarCategoria";
            btnCriarCategoria.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCriarCategoria.Size = new Size(225, 56);
            btnCriarCategoria.TabIndex = 21;
            btnCriarCategoria.Text = "Criar Categoria";
            btnCriarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.BorderRadius = 10;
            btnEditarCategoria.CustomizableEdges = customizableEdges3;
            btnEditarCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnEditarCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarCategoria.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEditarCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarCategoria.FillColor = Color.Aqua;
            btnEditarCategoria.FillColor2 = Color.Yellow;
            btnEditarCategoria.Font = new Font("Segoe UI", 9F);
            btnEditarCategoria.ForeColor = Color.Black;
            btnEditarCategoria.Image = Properties.Resources.lapis2;
            btnEditarCategoria.ImageAlign = HorizontalAlignment.Left;
            btnEditarCategoria.Location = new Point(1076, 97);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditarCategoria.Size = new Size(225, 56);
            btnEditarCategoria.TabIndex = 22;
            btnEditarCategoria.Text = "Editar Categoria";
            btnEditarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnExcluirCategoria
            // 
            btnExcluirCategoria.BorderRadius = 10;
            btnExcluirCategoria.CustomizableEdges = customizableEdges1;
            btnExcluirCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnExcluirCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluirCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluirCategoria.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExcluirCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluirCategoria.FillColor = Color.Red;
            btnExcluirCategoria.FillColor2 = Color.Blue;
            btnExcluirCategoria.Font = new Font("Segoe UI", 9F);
            btnExcluirCategoria.ForeColor = Color.Black;
            btnExcluirCategoria.Image = Properties.Resources.x2;
            btnExcluirCategoria.ImageAlign = HorizontalAlignment.Left;
            btnExcluirCategoria.Location = new Point(1076, 170);
            btnExcluirCategoria.Name = "btnExcluirCategoria";
            btnExcluirCategoria.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExcluirCategoria.Size = new Size(225, 56);
            btnExcluirCategoria.TabIndex = 23;
            btnExcluirCategoria.Text = "Excluir Categoria";
            btnExcluirCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Ivory;
            ClientSize = new Size(1313, 629);
            Controls.Add(btnExcluirCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnCriarCategoria);
            Controls.Add(lblCategoriasCadastradas);
            Controls.Add(lblTitulo);
            Controls.Add(gridCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategorias";
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView gridCategorias;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoriasCadastradas;
        private Guna.UI2.WinForms.Guna2GradientButton btnCriarCategoria;
        private Guna.UI2.WinForms.Guna2GradientButton btnExcluirCategoria;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditarCategoria;
    }
}
