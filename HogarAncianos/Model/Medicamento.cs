using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
   public  class Medicamento
    {
        public string codigoMedicamento { get; set; }
        public string nombreMedicamento { get; set; }
        public string unidadMedida { get; set; }
        public string categoria { get; set; }
        public int catidadDisponible { get; set; }
        public int cantidadPrescrita { get; set; }


        public Medicamento(string codigoMedicamento, string nombreMedicamento, string unidadMedida, string categoria,int cantidadDisponible,int cantidadPrescrita)
        {
            this.codigoMedicamento = codigoMedicamento;
            this.nombreMedicamento = nombreMedicamento;
            this.unidadMedida = unidadMedida;
            this.categoria = categoria;
            this.catidadDisponible = cantidadDisponible;
            this.cantidadPrescrita = cantidadPrescrita;
        }

        public Medicamento(string codigoMedicamento, string nombreMedicamento, string unidadMedida, string categoria, int cantidadDisponible)
        {
            this.codigoMedicamento = codigoMedicamento;
            this.nombreMedicamento = nombreMedicamento;
            this.unidadMedida = unidadMedida;
            this.categoria = categoria;
            this.catidadDisponible = cantidadDisponible;
          
        }

    }
}
