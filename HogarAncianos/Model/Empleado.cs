using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model {
    public class Empleado {

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string[] Correos { get; set; }
        public string PuestoTrabajo { get; set; }
        public string HorarioTrabajo { get; set; }
        public double Salario { get; set; }
        public string FechaContratacion { get; set; }
        public string EstadoLaboral { get; set; }

        public Empleado(string cedula, string nombre, string apellidos, string fechaNacimiento, string telefono, string direccion,
            string[] correos, string puestoTrabajo, string horario, double salario, string fechaContratacion, string estadoLaboral) {
            Cedula = cedula;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
            Correos = correos;
            PuestoTrabajo = puestoTrabajo;
            HorarioTrabajo = horario;
            Salario = salario;
            FechaContratacion = fechaContratacion;
            EstadoLaboral = estadoLaboral;
        }

    }
}
