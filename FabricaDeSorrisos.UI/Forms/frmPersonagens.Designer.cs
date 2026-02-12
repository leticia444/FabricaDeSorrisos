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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            btnPersonagem = new Guna.UI2.WinForms.Guna2CircleButton();
            lblPersonagem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvPersonagem = new Guna.UI2.WinForms.Guna2DataGridView();
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
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 36);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            // 
            // btnPersonagem
            // 
            btnPersonagem.DisabledState.BorderColor = Color.DarkGray;
            btnPersonagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPersonagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPersonagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPersonagem.FillColor = Color.Transparent;
            btnPersonagem.Font = new Font("Segoe UI", 9F);
            btnPersonagem.ForeColor = Color.White;
            btnPersonagem.Image = Properties.Resources.character_icon;
            btnPersonagem.ImageSize = new Size(100, 100);
            btnPersonagem.Location = new Point(329, 9);
            btnPersonagem.Name = "btnPersonagem";
            btnPersonagem.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnPersonagem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnPersonagem.Size = new Size(148, 116);
            btnPersonagem.TabIndex = 21;
            // 
            // lblPersonagem
            // 
            lblPersonagem.BackColor = Color.Transparent;
            lblPersonagem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonagem.Location = new Point(244, 139);
            lblPersonagem.Name = "lblPersonagem";
            lblPersonagem.Size = new Size(330, 23);
            lblPersonagem.TabIndex = 22;
            lblPersonagem.Text = "Adicione, Edite ou Exclua um Personagem";
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
            dgvPersonagem.Location = new Point(141, 187);
            dgvPersonagem.Name = "dgvPersonagem";
            dgvPersonagem.RowHeadersVisible = false;
            dgvPersonagem.Size = new Size(510, 234);
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
            // frmPersonagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPersonagem);
            Controls.Add(lblPersonagem);
            Controls.Add(btnPersonagem);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPersonagens";
            Text = "frmPersonagens";
            ((System.ComponentModel.ISupportInitialize)dgvPersonagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2CircleButton btnPersonagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPersonagem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPersonagem;
    }
}