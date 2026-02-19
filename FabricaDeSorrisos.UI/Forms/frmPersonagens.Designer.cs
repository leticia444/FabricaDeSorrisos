namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmPersonagens
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
            dgvPersonagem = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvPersonagem).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dgvPersonagem
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPersonagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonagem.ColumnHeadersHeight = 4;
            dgvPersonagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPersonagem.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPersonagem.GridColor = Color.FromArgb(231, 229, 255);
            dgvPersonagem.Location = new Point(-5, 275);
            dgvPersonagem.Name = "dgvPersonagem";
            dgvPersonagem.RowHeadersVisible = false;
            dgvPersonagem.Size = new Size(838, 235);
            dgvPersonagem.TabIndex = 23;
            dgvPersonagem.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPersonagem.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPersonagem.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPersonagem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPersonagem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPersonagem.ThemeStyle.BackColor = Color.White;
            dgvPersonagem.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvPersonagem.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvPersonagem.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPersonagem.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPersonagem.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPersonagem.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPersonagem.ThemeStyle.HeaderStyle.Height = 4;
            dgvPersonagem.ThemeStyle.ReadOnly = false;
            dgvPersonagem.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPersonagem.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersonagem.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPersonagem.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPersonagem.ThemeStyle.RowsStyle.Height = 25;
            dgvPersonagem.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPersonagem.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(233, 114);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(170, 17);
            guna2HtmlLabel1.TabIndex = 24;
            guna2HtmlLabel1.Text = "Gerenciamento de Personagens";
            // 
            // frmPersonagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(833, 506);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dgvPersonagem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPersonagens";
            Text = "frmPersonagens";
            ((System.ComponentModel.ISupportInitialize)dgvPersonagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPersonagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}