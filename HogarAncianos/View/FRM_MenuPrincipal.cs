using HogarAncianos.Controller;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_MenuPrincipal : Form {

        private MenuController menuController;

        public FRM_MenuPrincipal() {
            InitializeComponent();
            menuController = new MenuController(this);
        }
    }
}
