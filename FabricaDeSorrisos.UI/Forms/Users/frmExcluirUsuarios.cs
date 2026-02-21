using System.Windows.Forms;
using FabricaDeSorrisos.UI.Models.Services;

namespace FabricaDeSorrisos.UI.Forms
{
    public class frmExcluirUsuarios : Form
    {
        private readonly UserService _userService;
        private readonly int? _userId;

        public frmExcluirUsuarios(UserService userService)
        {
            _userService = userService;
            _userId = null;
            Text = "Excluir Usuário";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Width = 400;
            Height = 200;
        }

        public frmExcluirUsuarios(UserService userService, int id) : this(userService)
        {
            _userId = id;
            Text = $"Excluir Usuário #{id}";
        }
    }
}
