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
   public class AgregarProductoInventarioController
    {
        private FRM_AgregarProductoInventario frm_AgregarProductoInventario;
        private ConnectionDB db;


        public AgregarProductoInventarioController(FRM_AgregarProductoInventario frm_AgregarProductoInventario)
        {
            this.frm_AgregarProductoInventario = frm_AgregarProductoInventario;
            AgregarEventos();
            db = new ConnectionDB();
        }

        private void AgregarEventos()
        {
            frm_AgregarProductoInventario.btLimpiar.Click += new EventHandler(BotonLimpiar);
            frm_AgregarProductoInventario.btAgregar.Click += new EventHandler(AgregarProductoInventario);
            frm_AgregarProductoInventario.btVerificar.Click += new EventHandler(VerificarIdentificador);
            frm_AgregarProductoInventario.txbIdentificadorProducto.KeyDown += new KeyEventHandler(VerificarIdentificadorEnter);
        }
        private void BotonLimpiar(object sender, EventArgs e)
        {
            frm_AgregarProductoInventario.EstadoInicial();

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
            if (!String.IsNullOrEmpty(frm_AgregarProductoInventario.GetIdentificador()))
            {
                if (!db.VerificarIdentificador(frm_AgregarProductoInventario.GetIdentificador()))
                {
                    frm_AgregarProductoInventario.ActivarCampos();
                    frm_AgregarProductoInventario.llenarCampos(db.GetProductosInventario(frm_AgregarProductoInventario.GetIdentificador()));
                }
                else
                    frm_AgregarProductoInventario.ShowMessage("El identificador ingresado no existe en nuestros registros.");
            }
            else
                frm_AgregarProductoInventario.ShowMessage("Debe ingresar un identificador válido.");
        }

        

        private void AgregarProductoInventario(object sender, EventArgs e)
        {
            if (frm_AgregarProductoInventario.VerificarCampos())
            {
                if (frm_AgregarProductoInventario.ShowConfirmation())
                {
                    if (db.AgregarProductoInventario(frm_AgregarProductoInventario.GetProductoInventario()))
                    {
                        frm_AgregarProductoInventario.ShowMessage("Se ha agregado la cantidad del producto al inventario con éxito.");
                        frm_AgregarProductoInventario.EstadoInicial();
                    }
                }
                else
                    frm_AgregarProductoInventario.ShowMessage("Se ha producido un error.\nVerifique los datos.");
                
            }
            else
            {
                frm_AgregarProductoInventario.ShowMessage("Algunos campos se encuentran vacíos o están en el formato incorrecto.");
            }
        }



    }

}
