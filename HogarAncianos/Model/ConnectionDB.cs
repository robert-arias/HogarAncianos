using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HogarAncianos.Model {
    public class ConnectionDB {

        private SQLiteConnection connection;

        public ConnectionDB() {
            RealizarConexion();
        }

        private void RealizarConexion() {
            if (!Directory.Exists("./Data")) {
                Directory.CreateDirectory("./Data");
                SQLiteConnection.CreateFile("./Data/database.sqlite3");
                connection = new SQLiteConnection("Data Source=./Data/database.sqlite3");

                string script = File.ReadAllText(@"./script/db.sql");
                SQLiteCommand c = new SQLiteCommand(script, connection);
                connection.Open();
                c.ExecuteNonQuery();
                connection.Close();
            }
            else {
                connection = new SQLiteConnection("Data Source=./Data/database.sqlite3");
            }
        }

        //***********************************************************METODOS PACIENTES ****************************************************************************//
        public bool ExisteCedulaPaciente(string cedula)
        {
            try
            {
                string query = "select * from Pacientes where cedula='" + cedula + "'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                connection.Close();

                if (dataset.Tables[0].Rows.Count == 0)
                    return false;
                else
                    return true;

            }
            catch (SQLiteException e)
            {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public bool AgregarPaciente(Paciente paciente)
        {
            try
            {
                string insert = $"insert into Pacientes values('{paciente.cedula}','{paciente.nombre}','{paciente.apellidos}','{paciente.fechaNacimiento}',{paciente.edad},'{paciente.sexo}')";
                SQLiteCommand command = new SQLiteCommand(insert, connection);
                Console.WriteLine(insert);
                connection.Open();
                Console.WriteLine("abri conexion");
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("cerre conexion");
                return true;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine("LLEGUE AL CATCH");
                connection.Close();
                Debug.WriteLine(e.ToString() + "EL ERRORRRRRRRRRRRRRRRRRRRRRR");
                return false;
            }

        }
        public  DataSet GetAllPacientes()
        {
           
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Pacientes", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();
                return data;
                
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

        public DataSet GetPaciente(string cedula)
        {
            Console.WriteLine(cedula + "LA CEDULA QUE ENTRA EN GET PACIENTE");
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Pacientes where cedula='" + cedula + "'", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();
                return data;


            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }


        }
        //string query = "update Empleados set Nombre = '" + empleado.Nombre + "', Sueldo = " + empleado.Sueldo +
        //      " where EmpleadoID = " + empleado.EmpleadoID;
        public bool UpdatePaciente (Paciente paciente)
        {
            string query = "update Pacientes set nombre ='" + paciente.nombre + "' , apellidos='" + paciente.apellidos + "',fecha_nacimiento='" + paciente.fechaNacimiento + "',edad=" + paciente.edad + ",sexo='" + paciente.sexo + "' where cedula= "+ paciente.cedula;

            Console.WriteLine(query);
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch (SQLiteException E)
            {
                Debug.WriteLine(E.ToString());
                return false;
            }
        }


        //***********************************************************METODOS USUARIOS ****************************************************************************//

        public bool UpdateUsuario(Usuario usuario)
        {
            string query = $"update Usuarios set contrasenia = @contrasenia where usuario = @usuario";

            try {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario.nombreUsuario);
                command.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch (SQLiteException e) {
                return false;
            }
        } 

       public bool DeleteUsuario(string usuario)
       {
          //  string query = "delete from Usuarios where usuario='" + usuario;

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("delete from Usuarios where usuario='" + usuario+"'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
                

            }
            catch (SQLiteException e)
            {
                return false;
            }

       }

        public DataSet GetUsuario(string usuario)
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Usuarios where usuario='" + usuario + "'", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();
                return data;


            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }


        }
        public DataSet GetUsuarios()
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select usuario from Usuarios", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();
                return data;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }
        public DataSet GetAllUsuarios()
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Usuarios", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();
                return data;
            
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

        public bool agregarUsuario(Usuario usuario)
        {
            string query = $"insert into Usuarios(usuario, contrasenia, cedula_empleado) values (@usuario, @contrasenia, @cedula)";

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario.nombreUsuario);
                command.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                command.Parameters.AddWithValue("@cedula", usuario.cedula);
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            } catch (SQLiteException e)
            {
                return false;
            }
        }

        public bool ExisteUsuarioConCedula(string cedula) {
            try {
                string query = $"select * from Usuarios where cedula_empleado = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();

                return dataTable.Rows.Count == 0;
            }
            catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public DataTable GetEmpleadoUsuario(string cedula) {
            try {
                string query = $"select cedula, nombre, apellidos, puesto_trabajo from Empleados where cedula = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();

                return dataTable;
            }
            catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return null;
            }
        }


            public bool ExisteUsuario(string usuario)
          {
            try {
                string query = "select * from Usuarios where usuario='" + usuario + "'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                connection.Close();

                if (dataset.Tables[0].Rows.Count == 0)
                    return false;
                else
                    return true;

            }
            catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }
        //***********************************************************METODOS EMPLEADOS ****************************************************************************//

        public bool ExisteCedula(string cedula) {
            try {
                string query = $"select cedula from Empleados where cedula = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataSQLite.Fill(dataSet);
                connection.Close();

                //No encuentra coincidencia; dataset vacío.
                return dataSet.Tables[0].Rows.Count == 0;
            } catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public bool AgregarEmpleado(Empleado empleado) {
            try {
                string insert = $"insert into Empleados values('{empleado.Cedula}', '{empleado.Nombre}', " +
                    $"'{empleado.Apellidos}', '{empleado.FechaNacimiento}', '{empleado.Telefono}', " +
                    $"'{empleado.Direccion}', '{empleado.PuestoTrabajo}', '{empleado.HorarioTrabajo}', " +
                    $"{empleado.Salario}, '{empleado.FechaContratacion}', 'A')";
                SQLiteCommand command = new SQLiteCommand(insert, connection);
                connection.Open();
                command.ExecuteNonQuery();

                foreach(string correo in empleado.Correos) {
                    string s = $"insert into Correos_Empleados values('{empleado.Cedula}', '{correo}')";
                    SQLiteCommand c = new SQLiteCommand(s, connection);
                    c.ExecuteNonQuery();
                }

                connection.Close();
                return true;
            } catch(SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public DataTable GetBusquedaEmpleados(string query) {
            try {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataSQLite.Fill(dataTable);
                connection.Close();

                return dataTable;
            } catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public DataTable GetCorreosEmpleado(string cedula) {
            try {
                string query = $"select correo from Correos_Empleados where cedula = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataSQLite.Fill(dataTable);
                connection.Close();

                return dataTable;
            }
            catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return null;
            }
        }

        //Metodos Medicamentos 

        public bool ExisteCodigoMedicamento(string codigo)
        {
            try
            {
                string query = "select * from Medicamentos where codigo_Medicamento='" + codigo + "'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                connection.Close();

                if (dataSet.Tables[0].Rows.Count == 0)
                    return false;
                else
                    return true;

            }
            catch (SQLiteException e)
            {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public bool UpdateMedicamento(Medicamento medicamento)
        {
            string query = "update Medicamentos set nombre_Medicamento='" + medicamento.nombreMedicamento + "', categoria ='" + medicamento.categoria + "',unidad_medida='" + medicamento.unidadMedida + "',cantidad_disponible=" + medicamento.catidadDisponible /*+ ""*/;
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch (SQLiteException E)
            {
                Debug.WriteLine(E.ToString());
                return false;
            }
        }


        public DataSet GetMedicamento(string codigo)
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Medicamentos where codigo_medicamento = '"+codigo + "'", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();

                Console.WriteLine(data.Tables[0].Rows[0][0]+"que traeeee medicamentooooooooos");
                Console.WriteLine(data.Tables[0].Rows[0][1] + "que traeeee medicamentooooooooos");
                Console.WriteLine(data.Tables[0].Rows[0][2] + "que traeeee medicamentooooooooos");
                return data;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

     

        public bool DeleteMedicamento(string codigo)
        {
            string query = "delete from Medicamentos where codigo_medicamento='" + codigo;

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;


            }
            catch (SQLiteException e)
            {
                return false;
            }

        }

        public bool AgregarMedicamento(Medicamento medicamento)
        {
            try
            {
                string insert = $"insert into Medicamentos values ('{medicamento.codigoMedicamento}','{medicamento.nombreMedicamento}','{medicamento.unidadMedida}','{medicamento.categoria}',{medicamento.catidadDisponible},{medicamento.cantidadPrescrita})";
                SQLiteCommand command = new SQLiteCommand(insert, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(SQLiteException e)
            {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
           
        }

        //***********************************************************METODOS PRODUCTOS HIGIENE ****************************************************************************//


        public bool VerificarIdentificador(string identificador)
        {
            try
            {
                string query = $"select identificador_producto from Productos_Higiene where identificador_producto = '{identificador}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataSQLite.Fill(dataTable);
                connection.Close();

                //No encuentra coincidencia; dataset vacío.
                return dataTable.Rows.Count == 0;
            }
            catch (SQLiteException e)
            {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public bool AgregarProductoHigiene(Productos_Higiene producto)
         {
             try
             {
                 string insert = $"insert into Productos_Higiene values('{producto.Identificador_producto}', '{producto.Nombre_producto}', " +
                     $"'{producto.Tipo_producto}', '{producto.Descripcion}', " +
                     $"{producto.Cantidad})";
                 SQLiteCommand command = new SQLiteCommand(insert, connection);
                 connection.Open();
                 command.ExecuteNonQuery();
                 connection.Close();
                 return true;
             }
             catch (SQLiteException e)
             {
                 connection.Close();
                 Debug.WriteLine(e.ToString());
                 return false;
             }
         }




    }
}
