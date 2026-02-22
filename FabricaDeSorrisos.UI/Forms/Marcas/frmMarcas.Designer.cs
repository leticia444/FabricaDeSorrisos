namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmMarcas
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
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCriarMarca = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEditarMarca = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExcluirMarca = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
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
            guna2DataGridView1.ColumnHeadersHeight = 36;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 360);
            guna2DataGridView1.Margin = new Padding(3, 4, 3, 4);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 25;
            guna2DataGridView1.Size = new Size(1320, 321);
            guna2DataGridView1.TabIndex = 26;
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
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20F);
            guna2HtmlLabel1.Location = new Point(12, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(382, 47);
            guna2HtmlLabel1.TabIndex = 27;
            guna2HtmlLabel1.Text = "Gerenciamento de Marcas";
            guna2HtmlLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 15F);
            guna2HtmlLabel2.Location = new Point(3, 320);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(226, 37);
            guna2HtmlLabel2.TabIndex = 28;
            guna2HtmlLabel2.Text = "Marcas Cadastradas";
            // 
            // btnCriarMarca
            // 
            btnCriarMarca.BorderRadius = 10;
            btnCriarMarca.CustomizableEdges = customizableEdges5;
            btnCriarMarca.DisabledState.BorderColor = Color.DarkGray;
            btnCriarMarca.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriarMarca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriarMarca.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCriarMarca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriarMarca.FillColor = Color.HotPink;
            btnCriarMarca.FillColor2 = Color.Yellow;
            btnCriarMarca.Font = new Font("Segoe UI", 9F);
            btnCriarMarca.ForeColor = Color.Black;
            btnCriarMarca.Image = Properties.Resources.plus3;
            btnCriarMarca.ImageAlign = HorizontalAlignment.Left;
            btnCriarMarca.Location = new Point(1076, 12);
            btnCriarMarca.Name = "btnCriarMarca";
            btnCriarMarca.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCriarMarca.Size = new Size(225, 56);
            btnCriarMarca.TabIndex = 29;
            btnCriarMarca.Text = "Criar Marca";
            btnCriarMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnEditarMarca
            // 
            btnEditarMarca.BorderRadius = 10;
            btnEditarMarca.CustomizableEdges = customizableEdges3;
            btnEditarMarca.DisabledState.BorderColor = Color.DarkGray;
            btnEditarMarca.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarMarca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarMarca.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEditarMarca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarMarca.FillColor = Color.Aqua;
            btnEditarMarca.FillColor2 = Color.Yellow;
            btnEditarMarca.Font = new Font("Segoe UI", 9F);
            btnEditarMarca.ForeColor = Color.Black;
            btnEditarMarca.Image = Properties.Resources.lapis1;
            btnEditarMarca.ImageAlign = HorizontalAlignment.Left;
            btnEditarMarca.Location = new Point(1076, 84);
            btnEditarMarca.Name = "btnEditarMarca";
            btnEditarMarca.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditarMarca.Size = new Size(225, 56);
            btnEditarMarca.TabIndex = 30;
            btnEditarMarca.Text = "Editar Marca";
            btnEditarMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnExcluirMarca
            // 
            btnExcluirMarca.BorderRadius = 10;
            btnExcluirMarca.CustomizableEdges = customizableEdges1;
            btnExcluirMarca.DisabledState.BorderColor = Color.DarkGray;
            btnExcluirMarca.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluirMarca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluirMarca.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExcluirMarca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluirMarca.FillColor = Color.Red;
            btnExcluirMarca.FillColor2 = Color.DodgerBlue;
            btnExcluirMarca.Font = new Font("Segoe UI", 9F);
            btnExcluirMarca.ForeColor = Color.Black;
            btnExcluirMarca.Image = Properties.Resources.x1;
            btnExcluirMarca.ImageAlign = HorizontalAlignment.Left;
            btnExcluirMarca.Location = new Point(1076, 159);
            btnExcluirMarca.Name = "btnExcluirMarca";
            btnExcluirMarca.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExcluirMarca.Size = new Size(225, 56);
            btnExcluirMarca.TabIndex = 31;
            btnExcluirMarca.Text = "Excluir Marca";
            btnExcluirMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Ivory;
            ClientSize = new Size(1313, 629);
            Controls.Add(btnExcluirMarca);
            Controls.Add(btnEditarMarca);
            Controls.Add(btnCriarMarca);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2DataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMarcas";
            Text = "frmMarcas";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCriarMarca;
        private Guna.UI2.WinForms.Guna2GradientButton btnExcluirMarca;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditarMarca;
    }
}
