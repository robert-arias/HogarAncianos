using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.Controller {

    public class BuscarProductosController {

        private FRM_BuscarProductos frm_BuscarProductos;
        private ConnectionDB db;

        public BuscarProductosController(FRM_BuscarProductos frm_BuscarProductos) {
            this.frm_BuscarProductos = frm_BuscarProductos;
            db = new ConnectionDB();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_BuscarProductos.rbIdentificador.CheckedChanged += new EventHandler(BuscarPorIdentificador);
            frm_BuscarProductos.rbTipo.CheckedChanged += new EventHandler(BuscarPorTipo);
            frm_BuscarProductos.rbHigiene.CheckedChanged += new EventHandler(BuscarPorHigiene);
            frm_BuscarProductos.rbLimipieza.CheckedChanged += new EventHandler(BuscarPorLimpieza);
            frm_BuscarProductos.rbNombre.CheckedChanged += new EventHandler(BuscarPorNombre);
            frm_BuscarProductos.btnBuscar.Click += new EventHandler(BuscarProductos);
            frm_BuscarProductos.txtBuscar.KeyDown += new KeyEventHandler(BuscarProductosEnter);
            frm_BuscarProductos.btnCancelar.Click += new EventHandler(Cancelar);
        }

        private void BuscarPorIdentificador(object sender, EventArgs e) {
            frm_BuscarProductos.ActivarFechas();
        }

        private void BuscarPorTipo(object sender, EventArgs e) {
            frm_BuscarProductos.ActivarTipos();
        }

        private void BuscarPorHigiene(object sender, EventArgs e) {
            frm_BuscarProductos.txtBuscar.Text = "Higiene personal";
        }

        private void BuscarPorLimpieza(object sender, EventArgs e) {
            frm_BuscarProductos.txtBuscar.Text = "Limpieza";
        }

        private void BuscarPorNombre(object sender, EventArgs e) {
            frm_BuscarProductos.DesactivarCampos();
        }

        private void BuscarProductos(object sender, EventArgs e) {
            Buscar();
        }

        private void BuscarProductosEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Buscar();
                e.SuppressKeyPress = true; //remove ding windows sound.
            }
        }

        private void Cancelar(object sender, EventArgs e) {
            frm_BuscarProductos.EstadoInicial();
        }

        private void Buscar() {
            if (!frm_BuscarProductos.VerificarCampos()) {
                frm_BuscarProductos.ResultadoBusqueda(db.GetBusquedaProducto(frm_BuscarProductos.GetBusqueda(),
                    frm_BuscarProductos.GetEntradas(), frm_BuscarProductos.GetSalidas()));
            }
            else
                frm_BuscarProductos.ShowMessage("Verifique que los datos ingresados para la búsqueda sean correctos",
                    "Mensaje");
        }

    }
}
