using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Autok_Szervíz
{
    public class AutokSzervizABKezelo
    {
        #region Adattagok
        private static SqlConnection connection;
        private static SqlCommand command;
        #endregion

        #region Alprogramok
        public static void AutokCsatlakozas()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AutokSzerviz"].ConnectionString;
                connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
            }
            catch (Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen AutokSzerviz csatlakozás", ex);
            }
        }
        public static void AutokLecsatlakozas()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen AutokSzerviz lecsatalkozás!", ex);
            }
        }
        public static List<Autok> AutokListazas()
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM [Autok]";
                List<Autok> lista = new List<Autok>();

                using (SqlDataReader reader = command.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string rendszam = reader["Rendszam"].ToString();

                        string tipusStr = reader["Tipus"].ToString();
                        Tipus tipus;
                        Enum.TryParse(tipusStr, out tipus);

                        DateTime evjarat = DateTime.Parse(reader["Evjarat"].ToString());

                        lista.Add(new Autok(id, rendszam, tipus, evjarat));
                    }
                    reader.Close();
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen auto listazas!", ex);
            }
        }
        public static List<Szervizek> SzervizListazas()
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM [Szervizek]";

                List<Szervizek> lista = new List<Szervizek>();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int autoId = (int)reader["AutoId"];
                        DateTime datum = DateTime.Parse(reader["Datum"].ToString());
                        string leiras = reader["Leiras"].ToString();
                        int koltseg = (int)reader["Koltseg"];

                        lista.Add(new Szervizek(autoId, datum, leiras, koltseg));
                    }
                    reader.Close();
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen Szerviz Listazas!", ex);
            }
        }
        public static List<Autok> AutokesSzervizLista()
        {
            List<Autok> autoklista = AutokListazas();
            List<Szervizek> szervizlista = SzervizListazas();

            foreach (var auto in autoklista)
            {
                auto.Bejegyzes = szervizlista.Where(s => s.AutoId == auto.Id).ToList();
            }

            return autoklista;
        }

        public static void AutoFelvetel(Autok ujauto)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Autok]([Rendszam],[Tipus],[Evjarat]) OUTPUT INSERTED.Id VALUES(@r,@t,@e)";
                command.Parameters.AddWithValue("@r", ujauto.Rendszam);
                command.Parameters.AddWithValue("@t", ujauto.Tipus);
                command.Parameters.AddWithValue("@e", ujauto.Evjarat);

                ujauto.Id = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen autofelvétel!", ex);
            }
        }
        public static void AutoModositas(Autok update)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "UPDATE [Autok] SET [Rendszam] = @r,[Tipus] = @t,[Evjarat] = @e WHERE [Id] = @id";

                command.Parameters.AddWithValue("@id",update.Id);
                command.Parameters.AddWithValue("@r", update.Rendszam);
                command.Parameters.AddWithValue("@t",update.Tipus);
                command.Parameters.AddWithValue("@e", update.Evjarat);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen Módosítás!", ex);
            }
        }
        public static void AutokTorles(Autok delete)
        {
            try
            {
                command.Parameters.Clear();

                
                command.CommandText = "DELETE FROM [Szervizek] WHERE [AutoId] = @id";
                command.Parameters.AddWithValue("@id", delete.Id);
                command.ExecuteNonQuery();

                
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Autok] WHERE [Id] = @id";
                command.Parameters.AddWithValue("@id", delete.Id);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen auto törlés!", ex);
            }
        }
        public static void SzerfizFelvétel(Szervizek uj)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [Szervizek] ([AutoId],[Datum],[Leiras],[Koltseg]) OUTPUT INSERTED.Id VALUES(@a,@d,@l,@k)";

                command.Parameters.AddWithValue("@a", uj.AutoId);
                command.Parameters.AddWithValue("@d", uj.Datum);
                command.Parameters.AddWithValue("@l", uj.Leiras);
                command.Parameters.AddWithValue("@k", uj.Koltseg);

                uj.AutoId = (int)command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen Szervizfelvétel!", ex);
            }
        }
        public static void SzervizModositas(Szervizek update)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "UPDATE [Szervizek] SET [Datum] = @d,[Leiras] = @l,[Koltseg] = @k WHERE [AutoId] = @a";

                command.Parameters.AddWithValue("@a", update.AutoId);
                command.Parameters.AddWithValue("@d",update.Datum);
                command.Parameters.AddWithValue("@l", update.Leiras);
                command.Parameters.AddWithValue("@k", update.Koltseg);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen Szerviz Módosítás!", ex);
            }
        }
        public static void SzervizTorles(Szervizek delete)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM [Szervizek] WHERE [AutoId] = @a";

                command.Parameters.AddWithValue("@a",delete.AutoId);

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new AutokSzervizKivetel("Sikertelen szervíz törlés!", ex);
            }
        }
        #endregion
    }
}
