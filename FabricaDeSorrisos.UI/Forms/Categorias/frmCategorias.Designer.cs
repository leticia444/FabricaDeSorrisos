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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            gridCategorias = new Guna.UI2.WinForms.Guna2DataGridView();
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
            gridCategorias.ColumnHeadersHeight = 4;
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            gridCategorias.GridColor = Color.FromArgb(231, 229, 255);
            gridCategorias.Location = new Point(0, 360);
            gridCategorias.Margin = new Padding(3, 4, 3, 4);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.RowHeadersVisible = false;
            gridCategorias.RowHeadersWidth = 51;
            gridCategorias.RowTemplate.Height = 25;
            gridCategorias.Size = new Size(1314, 264);
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
            gridCategorias.ThemeStyle.HeaderStyle.Height = 4;
            gridCategorias.ThemeStyle.ReadOnly = false;
            gridCategorias.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridCategorias.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCategorias.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridCategorias.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridCategorias.ThemeStyle.RowsStyle.Height = 25;
            gridCategorias.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridCategorias.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1313, 629);
            Controls.Add(gridCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategorias";
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView gridCategorias;
    }
}