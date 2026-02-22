namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmSubCategorias
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
            btnEditarSubCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExcluirSubCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            btnCriarSubCategoria = new Guna.UI2.WinForms.Guna2GradientButton();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubCategoriasCadastradas = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            gridCategorias.Location = new Point(-3, 317);
            gridCategorias.Margin = new Padding(3, 4, 3, 4);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.RowHeadersVisible = false;
            gridCategorias.RowHeadersWidth = 51;
            gridCategorias.RowTemplate.Height = 25;
            gridCategorias.Size = new Size(1324, 312);
            gridCategorias.TabIndex = 24;
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
            // btnEditarSubCategoria
            // 
            btnEditarSubCategoria.BorderRadius = 10;
            btnEditarSubCategoria.CustomizableEdges = customizableEdges5;
            btnEditarSubCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnEditarSubCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarSubCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarSubCategoria.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEditarSubCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarSubCategoria.FillColor = Color.Aqua;
            btnEditarSubCategoria.FillColor2 = Color.Yellow;
            btnEditarSubCategoria.Font = new Font("Segoe UI", 9F);
            btnEditarSubCategoria.ForeColor = Color.Black;
            btnEditarSubCategoria.Image = Properties.Resources.lapis7;
            btnEditarSubCategoria.ImageAlign = HorizontalAlignment.Left;
            btnEditarSubCategoria.Location = new Point(1076, 84);
            btnEditarSubCategoria.Name = "btnEditarSubCategoria";
            btnEditarSubCategoria.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarSubCategoria.Size = new Size(225, 56);
            btnEditarSubCategoria.TabIndex = 25;
            btnEditarSubCategoria.Text = "Editar Sub-Categoria";
            btnEditarSubCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnExcluirSubCategoria
            // 
            btnExcluirSubCategoria.BorderRadius = 10;
            btnExcluirSubCategoria.CustomizableEdges = customizableEdges3;
            btnExcluirSubCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnExcluirSubCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluirSubCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluirSubCategoria.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExcluirSubCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluirSubCategoria.FillColor = Color.Red;
            btnExcluirSubCategoria.FillColor2 = Color.Blue;
            btnExcluirSubCategoria.Font = new Font("Segoe UI", 9F);
            btnExcluirSubCategoria.ForeColor = Color.Black;
            btnExcluirSubCategoria.Image = Properties.Resources.x5;
            btnExcluirSubCategoria.ImageAlign = HorizontalAlignment.Left;
            btnExcluirSubCategoria.Location = new Point(1076, 156);
            btnExcluirSubCategoria.Name = "btnExcluirSubCategoria";
            btnExcluirSubCategoria.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExcluirSubCategoria.Size = new Size(225, 56);
            btnExcluirSubCategoria.TabIndex = 26;
            btnExcluirSubCategoria.Text = "Excluir Categoria";
            btnExcluirSubCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnCriarSubCategoria
            // 
            btnCriarSubCategoria.BorderRadius = 10;
            btnCriarSubCategoria.CustomizableEdges = customizableEdges1;
            btnCriarSubCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnCriarSubCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriarSubCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriarSubCategoria.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCriarSubCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriarSubCategoria.FillColor = Color.HotPink;
            btnCriarSubCategoria.FillColor2 = Color.Yellow;
            btnCriarSubCategoria.Font = new Font("Segoe UI", 9F);
            btnCriarSubCategoria.ForeColor = Color.Black;
            btnCriarSubCategoria.Image = Properties.Resources.plus5;
            btnCriarSubCategoria.ImageAlign = HorizontalAlignment.Left;
            btnCriarSubCategoria.Location = new Point(1076, 12);
            btnCriarSubCategoria.Name = "btnCriarSubCategoria";
            btnCriarSubCategoria.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCriarSubCategoria.Size = new Size(225, 56);
            btnCriarSubCategoria.TabIndex = 27;
            btnCriarSubCategoria.Text = "Criar Sub-Categoria";
            btnCriarSubCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 47);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Gerenciamento de Sub-Categorias";
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // lblSubCategoriasCadastradas
            // 
            lblSubCategoriasCadastradas.BackColor = Color.Transparent;
            lblSubCategoriasCadastradas.Font = new Font("Segoe UI", 15F);
            lblSubCategoriasCadastradas.Location = new Point(2, 274);
            lblSubCategoriasCadastradas.Name = "lblSubCategoriasCadastradas";
            lblSubCategoriasCadastradas.Size = new Size(316, 37);
            lblSubCategoriasCadastradas.TabIndex = 29;
            lblSubCategoriasCadastradas.Text = "Sub-Categorias Cadastradas";
            // 
            // frmSubCategorias
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Ivory;
            ClientSize = new Size(1313, 629);
            Controls.Add(lblSubCategoriasCadastradas);
            Controls.Add(lblTitulo);
            Controls.Add(btnCriarSubCategoria);
            Controls.Add(btnExcluirSubCategoria);
            Controls.Add(btnEditarSubCategoria);
            Controls.Add(gridCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSubCategorias";
            Text = "frmSubCategorias";
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView gridCategorias;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubCategoriasCadastradas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2GradientButton btnCriarSubCategoria;
        private Guna.UI2.WinForms.Guna2GradientButton btnExcluirSubCategoria;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditarSubCategoria;
    }
}
