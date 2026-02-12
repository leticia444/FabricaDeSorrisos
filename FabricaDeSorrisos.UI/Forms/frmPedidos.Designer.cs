namespace FabricaDeSorrisos.UI.Forms
{
    partial class frmPedidos
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
            btnPedidos = new Guna.UI2.WinForms.Guna2CircleButton();
            lblPedido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvPedido = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
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
            // btnPedidos
            // 
            btnPedidos.DisabledState.BorderColor = Color.DarkGray;
            btnPedidos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPedidos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPedidos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPedidos.FillColor = Color.Transparent;
            btnPedidos.Font = new Font("Segoe UI", 9F);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = Properties.Resources.pedidos_icon;
            btnPedidos.ImageSize = new Size(100, 100);
            btnPedidos.Location = new Point(326, 15);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPedidos.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnPedidos.Size = new Size(148, 115);
            btnPedidos.TabIndex = 25;
            // 
            // lblPedido
            // 
            lblPedido.BackColor = Color.Transparent;
            lblPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(264, 140);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(287, 23);
            lblPedido.TabIndex = 26;
            lblPedido.Text = "Adicione, Edite ou Exclua um Pedido";
            // 
            // dgvPedido
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPedido.ColumnHeadersHeight = 4;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPedido.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPedido.GridColor = Color.FromArgb(231, 229, 255);
            dgvPedido.Location = new Point(141, 187);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.Size = new Size(510, 234);
            dgvPedido.TabIndex = 27;
            dgvPedido.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPedido.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPedido.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPedido.ThemeStyle.BackColor = Color.White;
            dgvPedido.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvPedido.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvPedido.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPedido.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPedido.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPedido.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPedido.ThemeStyle.HeaderStyle.Height = 4;
            dgvPedido.ThemeStyle.ReadOnly = false;
            dgvPedido.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPedido.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPedido.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPedido.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPedido.ThemeStyle.RowsStyle.Height = 25;
            dgvPedido.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPedido.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPedido);
            Controls.Add(lblPedido);
            Controls.Add(btnPedidos);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPedidos";
            Text = "frmPedidos";
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2CircleButton btnPedidos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPedido;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPedido;
    }
}