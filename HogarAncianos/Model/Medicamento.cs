using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    class Medicamento
    {
        public string codigoMedicamento { get; set; }
        public string nombreMedicamento { get; set; }
        public string unidadMedida { get; set; }
        public string categoria { get; set; }
        public int catidadDisponible { get; set; }
        public int cantidadPrescrita { get; set; }


    }
}
