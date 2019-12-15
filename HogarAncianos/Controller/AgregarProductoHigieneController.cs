using System;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller {
    public class AgregarProductoHigieneController {
        private FRM_AgregarProductosHigiene frm_AgregarProductosHigiene;
        private ConnectionDB db;

        public AgregarProductoHigieneController(FRM_AgregarProductosHigiene frm_AgregarProductosHigiene) {
            this.frm_AgregarProductosHigiene = frm_AgregarProductosHigiene;
            AgregarEventos();
            db = new ConnectionDB();
        }

        private void AgregarEventos() {
            frm_AgregarProductosHigiene.btVerificar.Click += new EventHandler(VerificarIdentificador);
            frm_AgregarProductosHigiene.btLimpiar.Click += new EventHandler(BotonLimpiar);
            frm_AgregarProductosHigiene.btAgregar.Click += new EventHandler(AgregarProductoHigiene);
            frm_AgregarProductosHigiene.txbIdentificadorProducto.KeyDown += new KeyEventHandler(VerificarIdentificadorEnter);

        }

        private void BotonLimpiar(object sender, EventArgs e) {
            frm_AgregarProductosHigiene.EstadoInicial();

        }

        private void VerificarIdentificadorEnter(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Verificar();
                e.SuppressKeyPress = true;
            }
        }
        private void VerificarIdentificador(object sender, EventArgs e) {
            Verificar();
        }

        private void Verificar() {
            if (!String.IsNullOrEmpty(frm_AgregarProductosHigiene.GetIdentificador())) {
                if (db.VerificarIdentificador(frm_AgregarProductosHigiene.GetIdentificador())) {
                    frm_AgregarProductosHigiene.ActivarCampos();
                }
                else
                    frm_AgregarProductosHigiene.ShowMessage("El identificador ingresado ya existe en nuestros registros.");
            }
            else
                frm_AgregarProductosHigiene.ShowMessage("Debe ingresar un identificador válido.");
        }



        private void AgregarProductoHigiene(object sender, EventArgs e) {
            if (!frm_AgregarProductosHigiene.VerificarCampos()) {
                if (frm_AgregarProductosHigiene.ShowConfirmation()) {
                    if (db.AgregarProductoHigiene(frm_AgregarProductosHigiene.GetProductoHigiene())) {
                        frm_AgregarProductosHigiene.ShowMessage("Se ha agregado un nuevo producto de higiene con éxito.");
                        frm_AgregarProductosHigiene.EstadoInicial();
                    }
                }
                else
                    frm_AgregarProductosHigiene.ShowMessage("Se ha producido un error.\nVerifique los datos.");
            }
            else
                frm_AgregarProductosHigiene.ShowMessage("Algunos campos se encuentran vacíos. ");
        }

    }
}