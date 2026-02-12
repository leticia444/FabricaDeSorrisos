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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            btnMarcas = new Guna.UI2.WinForms.Guna2CircleButton();
            lblMarca = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvMarca = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMarca).BeginInit();
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
            // btnMarcas
            // 
            btnMarcas.DisabledState.BorderColor = Color.DarkGray;
            btnMarcas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMarcas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMarcas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMarcas.FillColor = Color.Transparent;
            btnMarcas.Font = new Font("Segoe UI", 9F);
            btnMarcas.ForeColor = Color.White;
            btnMarcas.Image = Properties.Resources.marca;
            btnMarcas.ImageSize = new Size(100, 100);
            btnMarcas.Location = new Point(325, 12);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMarcas.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMarcas.Size = new Size(148, 112);
            btnMarcas.TabIndex = 20;
            // 
            // lblMarca
            // 
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(255, 139);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(296, 23);
            lblMarca.TabIndex = 23;
            lblMarca.Text = "Adicione, Edite ou Exclua uma Marca";
            // 
            // dgvMarca
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMarca.ColumnHeadersHeight = 4;
            dgvMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMarca.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMarca.GridColor = Color.FromArgb(231, 229, 255);
            dgvMarca.Location = new Point(141, 187);
            dgvMarca.Name = "dgvMarca";
            dgvMarca.RowHeadersVisible = false;
            dgvMarca.Size = new Size(510, 234);
            dgvMarca.TabIndex = 24;
            dgvMarca.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMarca.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvMarca.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvMarca.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvMarca.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvMarca.ThemeStyle.BackColor = Color.White;
            dgvMarca.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMarca.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvMarca.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMarca.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvMarca.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMarca.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMarca.ThemeStyle.HeaderStyle.Height = 4;
            dgvMarca.ThemeStyle.ReadOnly = false;
            dgvMarca.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMarca.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMarca.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMarca.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMarca.ThemeStyle.RowsStyle.Height = 25;
            dgvMarca.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMarca.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMarca);
            Controls.Add(lblMarca);
            Controls.Add(btnMarcas);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMarcas";
            Text = "frmMarcas";
            ((System.ComponentModel.ISupportInitialize)dgvMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2CircleButton btnMarcas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMarca;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMarca;
    }
}