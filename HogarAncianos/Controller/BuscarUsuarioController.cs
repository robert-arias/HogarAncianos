using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller
{
    class BuscarUsuarioController
    {
        private FRM_ConsultarUsuario frm_ConsultarUsuario;
        private ConnectionDB db;
        public BuscarUsuarioController(FRM_ConsultarUsuario FRM_ConsultarUsuario)
        {
            this.frm_ConsultarUsuario = FRM_ConsultarUsuario;
            db = new ConnectionDB();
            AgregarEventosConsultarUsuario();
        }

        public void AgregarEventosConsultarUsuario()
        {
            frm_ConsultarUsuario.btnBuscar.Click += new EventHandler(BuscarBoton);
            
            frm_ConsultarUsuario.txtBuscar.KeyDown += new KeyEventHandler(BuscarEnter);
            frm_ConsultarUsuario.btnCancelar.Click += new EventHandler(Cancelar);
        }

        private void Cancelar(object sender, EventArgs e) {
            frm_ConsultarUsuario.EstadoInicial();
        }

        private void BuscarEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Buscar();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void BuscarBoton(object sender, EventArgs e) {
            Buscar();
        }

        private void Buscar() {
            if (!frm_ConsultarUsuario.VerificarCampos()) {
                frm_ConsultarUsuario.LlenarCampos(db.GetBusquedaUsuarios(frm_ConsultarUsuario.GetBusqueda()));
            }
            else
                frm_ConsultarUsuario.ShowMessage("Verifique que los datos de la búsqueda sean correctos.");
        }

      
    }
}
