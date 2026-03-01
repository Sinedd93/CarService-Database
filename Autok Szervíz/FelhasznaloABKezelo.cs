using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok_Szervíz
{
    public class FelhasznaloABKezelo
    {
        #region Adattagok
        public static SqlConnection connection;
        public static SqlCommand command;
        #endregion

        #region Alprogramok
        public static void Csatlakozas()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Belépés"].ConnectionString;
                connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
            }
            catch(Exception ex)
            {
                throw new ABkivetel("Sikertelen csatlakozás",ex);
            }
        }
        public static void Lecsatlakozás()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch(Exception ex)
            {
                throw new ABkivetel("Sikertelen Lecsatlakozás",ex);
            }
        }
        public static bool Belepes(string fnev, string jelszo)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText =
                    "SELECT COUNT(*) FROM Felhasznalok WHERE fnev = @fnev AND fjelszo = @fjelszo";

                command.Parameters.AddWithValue("@fnev", fnev);
                command.Parameters.AddWithValue("@fjelszo", jelszo);

                int count = (int)command.ExecuteScalar();
                return count == 1;
            }
            catch (Exception ex)
            {
                throw new ABkivetel("Sikertelen bejelentkezés", ex);
            }
        }
        
        #endregion
    }
}
