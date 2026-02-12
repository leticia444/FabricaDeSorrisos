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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            btnSubCategoria = new Guna.UI2.WinForms.Guna2CircleButton();
            lblSubcategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvSubcategoria = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubcategoria).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
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
            btnFechar.Location = new Point(750, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            // 
            // btnSubCategoria
            // 
            btnSubCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnSubCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubCategoria.FillColor = Color.Transparent;
            btnSubCategoria.Font = new Font("Segoe UI", 9F);
            btnSubCategoria.ForeColor = Color.White;
            btnSubCategoria.Image = Properties.Resources.sub_categorias;
            btnSubCategoria.ImageSize = new Size(100, 100);
            btnSubCategoria.Location = new Point(326, 14);
            btnSubCategoria.Name = "btnSubCategoria";
            btnSubCategoria.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSubCategoria.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnSubCategoria.Size = new Size(148, 112);
            btnSubCategoria.TabIndex = 17;
            // 
            // lblSubcategoria
            // 
            lblSubcategoria.BackColor = Color.Transparent;
            lblSubcategoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubcategoria.Location = new Point(235, 139);
            lblSubcategoria.Name = "lblSubcategoria";
            lblSubcategoria.Size = new Size(351, 23);
            lblSubcategoria.TabIndex = 23;
            lblSubcategoria.Text = "Adicione, Edite ou Exclua uma Subcategoria";
            // 
            // dgvSubcategoria
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvSubcategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSubcategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSubcategoria.ColumnHeadersHeight = 4;
            dgvSubcategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSubcategoria.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSubcategoria.GridColor = Color.FromArgb(231, 229, 255);
            dgvSubcategoria.Location = new Point(141, 187);
            dgvSubcategoria.Name = "dgvSubcategoria";
            dgvSubcategoria.RowHeadersVisible = false;
            dgvSubcategoria.Size = new Size(510, 234);
            dgvSubcategoria.TabIndex = 24;
            dgvSubcategoria.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSubcategoria.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSubcategoria.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSubcategoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSubcategoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSubcategoria.ThemeStyle.BackColor = Color.White;
            dgvSubcategoria.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvSubcategoria.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSubcategoria.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSubcategoria.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvSubcategoria.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSubcategoria.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSubcategoria.ThemeStyle.HeaderStyle.Height = 4;
            dgvSubcategoria.ThemeStyle.ReadOnly = false;
            dgvSubcategoria.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSubcategoria.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubcategoria.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvSubcategoria.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSubcategoria.ThemeStyle.RowsStyle.Height = 25;
            dgvSubcategoria.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSubcategoria.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmSubCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSubcategoria);
            Controls.Add(lblSubcategoria);
            Controls.Add(btnSubCategoria);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSubCategorias";
            Text = "frmSubCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvSubcategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2CircleButton btnSubCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubcategoria;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSubcategoria;
    }
}