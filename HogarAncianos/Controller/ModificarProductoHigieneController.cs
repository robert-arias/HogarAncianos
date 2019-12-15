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
   public class ModificarProductoHigieneController
    {
        private FRM_ModificarProductosHigiene frm_ModificarProductosHigiene;
        private ConnectionDB db;
        

        public ModificarProductoHigieneController(FRM_ModificarProductosHigiene frm_ModificarProductosHigiene)
        {
            this.frm_ModificarProductosHigiene = frm_ModificarProductosHigiene;
            AgregarEventos();
            db = new ConnectionDB();
        }

        private void AgregarEventos()
        {
            frm_ModificarProductosHigiene.btVerificar.Click += new EventHandler(VerificarIdentificador);
            frm_ModificarProductosHigiene.btLimpiar.Click += new EventHandler(BotonLimpiar);
            frm_ModificarProductosHigiene.btModificar.Click += new EventHandler(ModificarProductoHigiene);
            frm_ModificarProductosHigiene.txbIdentificadorProducto.KeyDown += new KeyEventHandler(VerificarIdentificadorEnter);
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
            if (!String.IsNullOrEmpty(frm_ModificarProductosHigiene.GetIdentificador()))
            {
                if (!db.VerificarIdentificador(frm_ModificarProductosHigiene.GetIdentificador()))
                {
                    frm_ModificarProductosHigiene.ActivarCampos();
                    frm_ModificarProductosHigiene.llenarCampos(db.GetProductosHigiene(frm_ModificarProductosHigiene.GetIdentificador()));
                }
                else
                    frm_ModificarProductosHigiene.ShowMessage("El identificador ingresado no existe en nuestros registros.");
            }
            else
                frm_ModificarProductosHigiene.ShowMessage("Debe ingresar un identificador válido.");
        }

        private void ModificarProductoHigiene(object sender, EventArgs e)
        {
            if (!frm_ModificarProductosHigiene.VerificarCampos())
            {
                if (frm_ModificarProductosHigiene.ShowConfirmation())
                {
                    if (db.modificarProductoHigiene(frm_ModificarProductosHigiene.GetProductoHigiene()))
                    {
                        frm_ModificarProductosHigiene.ShowMessage("Se ha modificado el producto de higiene con éxito.");
                        frm_ModificarProductosHigiene.EstadoInicial();
                    }
                }
                else
                    frm_ModificarProductosHigiene.ShowMessage("Se ha producido un error.\nVerifique los datos.");
            }
            else
            {
                frm_ModificarProductosHigiene.ShowMessage("Algunos campos se encuentran vacíos. ");
            }
        }

        private void BotonLimpiar(object sender, EventArgs e)
        {
            frm_ModificarProductosHigiene.EstadoInicial();

        }

         
    }
}
