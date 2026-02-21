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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            dgvPersonagem = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPersonagensCadastrados = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCriarPersonagem = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEditarPersonagem = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExcluirPersonagem = new Guna.UI2.WinForms.Guna2GradientButton();
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
            dgvPersonagem.Location = new Point(-6, 367);
            dgvPersonagem.Margin = new Padding(3, 4, 3, 4);
            dgvPersonagem.Name = "dgvPersonagem";
            dgvPersonagem.RowHeadersVisible = false;
            dgvPersonagem.RowHeadersWidth = 51;
            dgvPersonagem.RowTemplate.Height = 25;
            dgvPersonagem.Size = new Size(1453, 313);
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
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Margin = new Padding(3, 4, 3, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(462, 47);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "Gerenciamento de Personagens";
            // 
            // lblPersonagensCadastrados
            // 
            lblPersonagensCadastrados.BackColor = Color.Transparent;
            lblPersonagensCadastrados.Font = new Font("Segoe UI", 15F);
            lblPersonagensCadastrados.Location = new Point(3, 338);
            lblPersonagensCadastrados.Name = "lblPersonagensCadastrados";
            lblPersonagensCadastrados.Size = new Size(290, 37);
            lblPersonagensCadastrados.TabIndex = 25;
            lblPersonagensCadastrados.Text = "Personagens Cadastrados";
            // 
            // btnCriarPersonagem
            // 
            btnCriarPersonagem.BorderRadius = 10;
            btnCriarPersonagem.CustomizableEdges = customizableEdges5;
            btnCriarPersonagem.DisabledState.BorderColor = Color.DarkGray;
            btnCriarPersonagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCriarPersonagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCriarPersonagem.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCriarPersonagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCriarPersonagem.FillColor = Color.HotPink;
            btnCriarPersonagem.FillColor2 = Color.Yellow;
            btnCriarPersonagem.Font = new Font("Segoe UI", 9F);
            btnCriarPersonagem.ForeColor = Color.Black;
            btnCriarPersonagem.Image = Properties.Resources.plus2;
            btnCriarPersonagem.ImageAlign = HorizontalAlignment.Left;
            btnCriarPersonagem.Location = new Point(1209, 12);
            btnCriarPersonagem.Name = "btnCriarPersonagem";
            btnCriarPersonagem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCriarPersonagem.Size = new Size(225, 56);
            btnCriarPersonagem.TabIndex = 26;
            btnCriarPersonagem.Text = "Criar Personagem";
            // 
            // btnEditarPersonagem
            // 
            btnEditarPersonagem.BorderRadius = 10;
            btnEditarPersonagem.CustomizableEdges = customizableEdges3;
            btnEditarPersonagem.DisabledState.BorderColor = Color.DarkGray;
            btnEditarPersonagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditarPersonagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditarPersonagem.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnEditarPersonagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditarPersonagem.FillColor = Color.Aqua;
            btnEditarPersonagem.FillColor2 = Color.Yellow;
            btnEditarPersonagem.Font = new Font("Segoe UI", 9F);
            btnEditarPersonagem.ForeColor = Color.Black;
            btnEditarPersonagem.Image = Properties.Resources.lapis6;
            btnEditarPersonagem.ImageAlign = HorizontalAlignment.Left;
            btnEditarPersonagem.Location = new Point(1209, 86);
            btnEditarPersonagem.Name = "btnEditarPersonagem";
            btnEditarPersonagem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditarPersonagem.Size = new Size(225, 56);
            btnEditarPersonagem.TabIndex = 27;
            btnEditarPersonagem.Text = "Editar Personagem";
            // 
            // btnExcluirPersonagem
            // 
            btnExcluirPersonagem.BorderRadius = 10;
            btnExcluirPersonagem.CustomizableEdges = customizableEdges1;
            btnExcluirPersonagem.DisabledState.BorderColor = Color.DarkGray;
            btnExcluirPersonagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluirPersonagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluirPersonagem.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExcluirPersonagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluirPersonagem.FillColor = Color.Red;
            btnExcluirPersonagem.FillColor2 = Color.Blue;
            btnExcluirPersonagem.Font = new Font("Segoe UI", 9F);
            btnExcluirPersonagem.ForeColor = Color.Black;
            btnExcluirPersonagem.Image = Properties.Resources.x4;
            btnExcluirPersonagem.ImageAlign = HorizontalAlignment.Left;
            btnExcluirPersonagem.Location = new Point(1209, 160);
            btnExcluirPersonagem.Name = "btnExcluirPersonagem";
            btnExcluirPersonagem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExcluirPersonagem.Size = new Size(225, 56);
            btnExcluirPersonagem.TabIndex = 28;
            btnExcluirPersonagem.Text = "Excluir Personagem";
            // 
            // frmPersonagens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1446, 681);
            Controls.Add(btnExcluirPersonagem);
            Controls.Add(btnEditarPersonagem);
            Controls.Add(btnCriarPersonagem);
            Controls.Add(lblPersonagensCadastrados);
            Controls.Add(lblTitulo);
            Controls.Add(dgvPersonagem);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPersonagens";
            Text = "frmPersonagens";
            Load += frmPersonagens_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPersonagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPersonagensCadastrados;
        private Guna.UI2.WinForms.Guna2GradientButton btnCriarPersonagem;
        private Guna.UI2.WinForms.Guna2GradientButton btnExcluirPersonagem;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditarPersonagem;
    }
}