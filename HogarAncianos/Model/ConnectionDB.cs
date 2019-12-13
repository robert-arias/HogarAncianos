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
                CrearBD();
            }
            else {
                CrearBD();
            }
        }

        private void CrearBD() {
            if (!File.Exists("./Data/database.sqlite3")) {
                SQLiteConnection.CreateFile("./Data/database.sqlite3");
                connection = new SQLiteConnection("Data Source=./Data/database.sqlite3");

                string script = File.ReadAllText(@"./script/db.sql");
                SQLiteCommand c = new SQLiteCommand(script, connection);
                connection.Open();
                c.ExecuteNonQuery();
                connection.Close();

                CrearUsuarioAdmin();

            }
            else
                connection = new SQLiteConnection("Data Source=./Data/database.sqlite3");
        }

        private void CrearUsuarioAdmin() {
            Empleado empleado = new Empleado("0", "Admin", "Admin", "01/01/2001", "0", "none", null, "Administradora",
                "none", 0, "01/01/2001", "A");
            AgregarEmpleado(empleado);

            byte[] passwordBytes = Encoding.Unicode.GetBytes("admin");
            var hasher = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = hasher.ComputeHash(passwordBytes);

            Usuario usuario = new Usuario("admin", hashedBytes, "0");
            AgregarUsuario(usuario);
        }

        //***********************************************************METODOS PACIENTES ****************************************************************************//
        public DataSet GetBusquedaPaciente(string query)
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
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

        public int GetTotalRegistrosPrescripcion()
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select Count(*)+1 from Prescripcion", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);
                connection.Close();
                return int.Parse(data.Tables[0].Rows[0][0].ToString());

            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

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

        public DataSet GetNombrePaciente(string cedula)
        {
           
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select nombre, apellidos from Pacientes where cedula='" + cedula + "'", connection);
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
            catch (SQLiteException) {
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
            catch (SQLiteException)
            {
                return false;
            }

       }

        public DataTable GetUsuario(string usuario)
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Usuarios where usuario='" + usuario + "'", connection);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(command);
                DataTable data = new DataTable();
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

        public bool AgregarUsuario(Usuario usuario)
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

            } catch (SQLiteException)
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


       public string GetPuestoTrabajo(string cedula) {
            try {
                string query = $"select puesto_trabajo from Empleados where cedula = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataSQLite.Fill(dataTable);
                connection.Close();

                return dataTable.Rows[0][0].ToString();
            }
            catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

        public bool ExisteCedula(string cedula) {
            try {
                string query = $"select cedula from Empleados where cedula = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataSQLite.Fill(dataTable);
                connection.Close();

                //No encuentra coincidencia; dataset vacío.
                return dataTable.Rows.Count == 0;
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

        public DataSet GetEmpleado(string cedula) {
            try {
                string query = $"select * from Empleados where cedula = '{cedula}'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataSet dataTable = new DataSet();
                dataSQLite.Fill(dataTable, "Empleado");

                query = $"select correo from Correos_Empleados where cedula = '{cedula}'";
                SQLiteCommand command2 = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite2 = new SQLiteDataAdapter(command2);
                dataSQLite2.Fill(dataTable, "Correos");
                connection.Close();

                return dataTable;
            }
            catch (SQLiteException e) {
                connection.Close();
                Debug.WriteLine(e.ToString());
                return null;
            }
        }

        public bool ModificarEmpleado(Empleado empleado) {
            try {
                string modificar = $"update Empleados set telefono = '{empleado.Telefono}', " +
                    $"direccion = '{empleado.Direccion}', puesto_trabajo = '{empleado.PuestoTrabajo}', " +
                    $"horario_trabajo = '{empleado.HorarioTrabajo}', salario_base_mensual = {empleado.Salario}, " +
                    $"estado_laboral = '{empleado.EstadoLaboral}' where cedula = '{empleado.Cedula}'";

                SQLiteCommand command = new SQLiteCommand(modificar, connection);
                connection.Open();
                command.ExecuteNonQuery();

                string delete = $"delete from Correos_Empleados where cedula = '{empleado.Cedula}'";
                SQLiteCommand c = new SQLiteCommand(delete, connection);
                c.ExecuteNonQuery();

                foreach (string correo in empleado.Correos) {
                    string s = $"insert into Correos_Empleados values('{empleado.Cedula}', '{correo}')";
                    SQLiteCommand i = new SQLiteCommand(s, connection);
                    i.ExecuteNonQuery();
                }

                connection.Close();

                return true;
            }
            catch (SQLiteException e) {
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
        //update Bebidas set Stock = Stock - " + cantidad + " where BebidaID = "
        //            + bebidaID, connection

        public bool UpdateCantidadDisponibleMedicamento(string codigo, int cantidad)
        {
            string query = "update Medicamentos set cantidad_disponible= cantidad_disponible -" + cantidad + " where codigo_medicamento='" + codigo /*+ ""*/;
            try
            {
               // connection.Open();
                SQLiteCommand command = new SQLiteCommand("update Medicamentos set cantidad_disponible= cantidad_disponible -" + cantidad + ", cantidad_prescrita= cantidad_prescrita +"+cantidad+" where codigo_medicamento='"+codigo+"'", connection);
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

        public DataSet GetNombre_CantidadDisponible_Medicamento(string codigo)
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select nombre_medicamento,cantidad_disponible from Medicamentos where codigo_medicamento = '" + codigo + "'", connection);
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


    



        public DataSet GetAllMedicamento()
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Medicamentos", connection);
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
            catch (SQLiteException )
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

        public DataSet GetBusquedaMedicamento(string query)
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
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

        public bool modificarProductoHigiene(Productos_Higiene producto)
        {
            string query = "update Productos_Higiene set nombre_producto ='" + producto.Nombre_producto + "' , tipo_producto='" + producto.Tipo_producto + "',descripcion='" + producto.Descripcion + "' where identificador_producto = '" + producto.Identificador_producto+"'";

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

        public DataSet GetProductosHigiene(string identificador)
        {
            Console.WriteLine(identificador);
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Productos_Higiene where identificador_producto ='" + identificador + "'", connection);
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



        //METODOS PRESCRIPCION 
        public bool AgregarPrescripcion(Prescripcion prescripcion)
        {
            try
            {
                string insert = $"insert into Prescripcion values({prescripcion.num},'{prescripcion.cedula_paciente}')";
                SQLiteCommand command = new SQLiteCommand(insert, connection);
                Console.WriteLine(insert);
                connection.Open();
                Console.WriteLine("LLEGUE A PRESCRIPCION");
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

        public bool AgregarPrescripcion_Medicamentos(List<Prescripcion_Medicamentos> prescripcion)
        {        
            try
            {               
                foreach (Prescripcion_Medicamentos i in prescripcion)
                {
                    string insert = $"insert into Prescripcion_Medicamento values({i.num},'{i.codigo_medicamento}','{i.fecha_caducidad}',{i.cantidad_prescrita})";

                    SQLiteCommand command = new SQLiteCommand(insert, connection);
                    Console.WriteLine(insert);
                    connection.Open();
                    command.ExecuteNonQuery();
                    UpdateCantidadDisponibleMedicamento(i.codigo_medicamento,i.cantidad_prescrita);
                    connection.Close();
                }
                
               
                return true;
            }
            catch (SQLiteException e)
            {
                
                connection.Close();
                Debug.WriteLine(e.ToString() + "Error");
                return false;
            }

        }

        public DataSet GetPrescripcionesUnPaciente(string cedula)
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select num from Prescripcion where cedula_paciente='" + cedula + "'", connection);
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

        public DataSet GetPrescripciones_MedicamentosUnPaciente(int num)
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Prescripcion_Medicamento where num=" + num + "", connection);
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

        public DataSet GetDatosMedicamento_Prescripcion(string codigo, int num)
        {

            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from Prescripcion_Medicamento where codigo_medicamento=" + codigo + " and num="+num+"", connection);
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


    }
}
