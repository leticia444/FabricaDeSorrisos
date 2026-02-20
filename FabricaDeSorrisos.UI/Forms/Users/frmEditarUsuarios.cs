using System.Windows.Forms;
using FabricaDeSorrisos.UI.Models.Services;

namespace FabricaDeSorrisos.UI.Forms
{
    public class frmEditarUsuarios : Form
    {
        private readonly UserService _userService;
        private readonly int? _userId;

        public frmEditarUsuarios(UserService userService)
        {
            _userService = userService;
            _userId = null;
            Text = "Editar Usuário";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Width = 400;
            Height = 200;
        }

        public frmEditarUsuarios(UserService userService, int id) : this(userService)
        {
            _userId = id;
            Text = $"Editar Usuário #{id}";
        }
    }
}
