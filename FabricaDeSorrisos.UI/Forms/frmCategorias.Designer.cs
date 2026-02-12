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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnCategorias = new Guna.UI2.WinForms.Guna2CircleButton();
            lblCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvCategorias = new Guna.UI2.WinForms.Guna2DataGridView();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnCategorias
            // 
            btnCategorias.DisabledState.BorderColor = Color.DarkGray;
            btnCategorias.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCategorias.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCategorias.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCategorias.FillColor = Color.Transparent;
            btnCategorias.Font = new Font("Segoe UI", 9F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = Properties.Resources.categorias;
            btnCategorias.ImageSize = new Size(100, 100);
            btnCategorias.Location = new Point(328, 16);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCategorias.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCategorias.Size = new Size(158, 108);
            btnCategorias.TabIndex = 16;
            // 
            // lblCategoria
            // 
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(246, 139);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(325, 23);
            lblCategoria.TabIndex = 17;
            lblCategoria.Text = "Adicione, Edite ou Exclua uma Categoria";
            // 
            // dgvCategorias
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategorias.Location = new Point(141, 187);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.Size = new Size(510, 234);
            dgvCategorias.TabIndex = 18;
            dgvCategorias.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCategorias.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCategorias.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCategorias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCategorias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCategorias.ThemeStyle.BackColor = Color.White;
            dgvCategorias.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategorias.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCategorias.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCategorias.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCategorias.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.ThemeStyle.HeaderStyle.Height = 4;
            dgvCategorias.ThemeStyle.ReadOnly = false;
            dgvCategorias.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCategorias.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCategorias.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCategorias.ThemeStyle.RowsStyle.Height = 25;
            dgvCategorias.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCategorias.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            btnFechar.Location = new Point(750, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 19;
            btnFechar.Text = "X";
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(dgvCategorias);
            Controls.Add(lblCategoria);
            Controls.Add(btnCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategorias";
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCategorias;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoria;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategorias;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
    }
}