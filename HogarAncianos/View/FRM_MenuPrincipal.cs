using HogarAncianos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_MenuPrincipal : Form {

        private MenuController menuController;

        public FRM_MenuPrincipal() {
            InitializeComponent();
            menuController = new MenuController(this);
        }

        public void AgregarEventos(Action<object, EventArgs> openAgregarEmpleado) {
            mi_EmpleadosAgregar.Click += new EventHandler(openAgregarEmpleado);
        }
    }
}
