using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller
{
    
    class AgregarMedicamentoController
    {
        private FRM_AgregarMedicamento frm_AgregarMedicamento;
        private ConnectionDB connectionDB;

        public AgregarMedicamentoController (FRM_AgregarMedicamento frm_agregarMedicamento)
        {
            this.frm_AgregarMedicamento = frm_agregarMedicamento;
            connectionDB = new ConnectionDB();
        }

    }
}
