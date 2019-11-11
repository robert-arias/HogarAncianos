using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

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

        public bool ExisteCedula(string cedula) {
            try {
                string query = "select cedula from Empleados where cedula = '" + cedula + "'";
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataSQLite = new SQLiteDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataSQLite.Fill(dataSet);
                connection.Close();

                //No encuentra coincidencia; dataset vacío.
                if (dataSet.Tables[0].Rows.Count == 0)
                    return false;
                else
                    return true;
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
                Console.WriteLine(insert);
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
    }
}
