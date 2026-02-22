using System;
using System.Windows.Forms;

namespace FabricaDeSorrisos.UI.Forms
{
    public partial class frmPersonagens : Form
    {
        private readonly UI.Services.PersonagemService _service = new UI.Services.PersonagemService();

        public frmPersonagens()
        {
            InitializeComponent();
        }

        private void frmPersonagens_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            VincularEventos();
            _ = RecarregarAsync();
        }

        private void ConfigurarGrid()
        {
            dgvPersonagem.ReadOnly = true;
            dgvPersonagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonagem.MultiSelect = false;
            dgvPersonagem.AutoGenerateColumns = false;
            dgvPersonagem.Columns.Clear();
            dgvPersonagem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                Width = 80
            });
            dgvPersonagem.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome do Personagem",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void VincularEventos()
        {
            btnCriarPersonagem.Click += BtnCriarPersonagem_Click;
            btnEditarPersonagem.Click += BtnEditarPersonagem_Click;
            btnExcluirPersonagem.Click += BtnExcluirPersonagem_Click;
        }

        private async System.Threading.Tasks.Task RecarregarAsync()
        {
            var lista = await _service.GetAllAsync();
            dgvPersonagem.DataSource = lista;
        }

        private async void BtnCriarPersonagem_Click(object? sender, EventArgs e)
        {
            using var form = new Personagens.frmCriarPersonagens();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var nome = form.Tag as string ?? string.Empty;
                var ok = await _service.CreateAsync(nome);
                if (ok) await RecarregarAsync();
                else MessageBox.Show("Não foi possível criar o personagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnEditarPersonagem_Click(object? sender, EventArgs e)
        {
            if (dgvPersonagem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um personagem para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = (int)dgvPersonagem.SelectedRows[0].Cells["Id"].Value;
            var nomeAtual = dgvPersonagem.SelectedRows[0].Cells["Nome"].Value?.ToString() ?? "";
            using var form = new Personagens.frmEditarPersonagens(id, nomeAtual);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var novoNome = form.Tag as string ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    var ok = await _service.UpdateAsync(id, novoNome);
                    if (ok) await RecarregarAsync();
                    else MessageBox.Show("Não foi possível salvar a edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnExcluirPersonagem_Click(object? sender, EventArgs e)
        {
            if (dgvPersonagem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um personagem para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = (int)dgvPersonagem.SelectedRows[0].Cells["Id"].Value;
            var nome = dgvPersonagem.SelectedRows[0].Cells["Nome"].Value?.ToString() ?? "";
            var result = MessageBox.Show($"Deseja realmente excluir o/a Pesonagem \"{nome}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var ok = await _service.DeleteAsync(id);
                if (ok) await RecarregarAsync();
                else MessageBox.Show("Não foi possível excluir o personagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
