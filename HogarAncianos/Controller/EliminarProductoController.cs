using HogarAncianos.Model;
using HogarAncianos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.Controller
{
    public class EliminarProductoController
    {

        FRM_EliminarProducto frm_EliminarProducto;
        ConnectionDB db;

        public EliminarProductoController(FRM_EliminarProducto frm_EliminarProducto)
        {
            this.frm_EliminarProducto = frm_EliminarProducto;
            db = new ConnectionDB();
            AgregarEventos();
        }

        private void AgregarEventos()
        {
            frm_EliminarProducto.btVerificar.Click += new EventHandler(VerificarIdentificador);
            frm_EliminarProducto.txbIdentificadorProducto.KeyDown += new KeyEventHandler(VerificarIdentificadorEnter);
            frm_EliminarProducto.btEliminar.Click += new EventHandler(EliminarProducto);
        }

        private void VerificarIdentificador(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Verificar()
        {
            if (!String.IsNullOrEmpty(frm_EliminarProducto.GetIdentificador()))
            {
                if (!db.VerificarIdentificador(frm_EliminarProducto.GetIdentificador()))
                {
                    frm_EliminarProducto.ActivarCampos();
                    frm_EliminarProducto.LlenarCampos(db.GetProductosHigiene(frm_EliminarProducto.GetIdentificador()));
                }
                else
                    frm_EliminarProducto.ShowMessage("El identificador ingresado no existe en nuestros registros.", "Advertencia");
            }
            else
                frm_EliminarProducto.ShowMessage("Debe ingresar un identificador válido.", "Advertencia");
        }

        private void VerificarIdentificadorEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificar();
                e.SuppressKeyPress = true;
            }
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            if (frm_EliminarProducto.GetCantidad() == 0)
            {
                if (frm_EliminarProducto.ShowConfirmation())
                {
                    //Llamamos a bse de datos y le pasamos el identificador.
                    frm_EliminarProducto.EstadoInicial();
                    frm_EliminarProducto.ShowMessage("Se ha eliminado el producto correctamente.", "Mensaje");

                }
            }
            else
                frm_EliminarProducto.ShowMessage("No se puede eliminar un producto cuya cantidad sea mayor a cero.",
                    "Advertencia.");
        }

    }
}
