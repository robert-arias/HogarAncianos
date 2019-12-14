using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.Model;
using HogarAncianos.View;
using System.Windows.Forms;

namespace HogarAncianos.Controller
{
   public  class SalidaProductosController
    {
        private FRM_SalidaProductos frm_SalidaProductos;
        private ConnectionDB db;


        public SalidaProductosController(FRM_SalidaProductos frm_SalidaProductos)
        {
            this.frm_SalidaProductos = frm_SalidaProductos;
            AgregarEventos();
            db = new ConnectionDB();
        }

        private void AgregarEventos()
        {
            frm_SalidaProductos.btLimpiar.Click += new EventHandler(BotonLimpiar);
            frm_SalidaProductos.btVerificar.Click += new EventHandler(VerificarIdentificador);
            frm_SalidaProductos.btSustraer.Click += new EventHandler(ExtraerProductoInventario);
            frm_SalidaProductos.txbIdentificadorProducto.KeyDown += new KeyEventHandler(VerificarIdentificadorEnter);
        }
        private void BotonLimpiar(object sender, EventArgs e)
        {
            frm_SalidaProductos.EstadoInicial();

        }

        private void VerificarIdentificador(object sender, EventArgs e)
        {
            Verificar();
        }

        private void VerificarIdentificadorEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificar();
                e.SuppressKeyPress = true;
            }
        }

        private void Verificar()
        {
            if (!String.IsNullOrEmpty(frm_SalidaProductos.GetIdentificador()))
            {
                if (!db.VerificarIdentificador(frm_SalidaProductos.GetIdentificador()))
                {
                    frm_SalidaProductos.ActivarCampos();
                    frm_SalidaProductos.LlenarCampos(db.GetProductosHigiene(frm_SalidaProductos.GetIdentificador()));
                }
                else
                    frm_SalidaProductos.ShowMessage("El identificador ingresado no existe en nuestros registros.");
            }
            else
                frm_SalidaProductos.ShowMessage("Debe ingresar un identificador válido.");
        }

        private void ExtraerProductoInventario(object sender, EventArgs e)
        {
            if (frm_SalidaProductos.VerificarCampos())
            {
                if (frm_SalidaProductos.VericarCantidad())
                {
                    if (frm_SalidaProductos.ShowConfirmation())
                    {
                        if (db.ExtraerProductoInventario(frm_SalidaProductos.GetSalidaProducto()))
                        {
                            frm_SalidaProductos.ShowMessage("Se ha sustraido la cantidad del producto con éxito.");
                            frm_SalidaProductos.EstadoInicial();
                        }
                    }
                    else
                        frm_SalidaProductos.ShowMessage("Se ha producido un error.\nVerifique los datos.");
                    
                }
                else
                    frm_SalidaProductos.ShowMessage("La cantidad a extraer, supera la cantidad actual.\nVerifique los datos."); 
            }
            else
            {
                frm_SalidaProductos.ShowMessage("Algunos campos se encuentran vacíos o están en el formato incorrecto.");
            }
            
        }


    }
}
