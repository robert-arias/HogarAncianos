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

    }
}
