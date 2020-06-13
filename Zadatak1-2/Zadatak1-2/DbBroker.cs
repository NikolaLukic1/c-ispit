using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1_2
{
    class DbBroker
    {
        static string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\!Metropolitan\\Programiranje u C#\\Primer ispita uradjen\\Zadatak1-2\\Zadatak1-2\\Database1.mdf\";Integrated Security=True";
        
        public static bool Login(string user, string pass) {
            string upit = $"SELECT COUNT(*) from Klijent WHERE korisnickoIme = '{user}' and sifra = '{pass}'";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand check_User_Name = new SqlCommand(upit, connection);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0) {
                    return true;
                    //Username exist
                } else {
                    return false;
                    //Username doesn't exist.
                }
            } catch (Exception) {

                throw;
            }
            finally {
                if(connection != null) {
                    connection.Close();
                }
            }
        }

        public static void UnesiKlijenta(Klijent klijent) {
            string upit = "INSERT INTO klijent VALUES(@KorisnickoIme, @sifra, @ime, @prezime, @adresa, @email, @telefon)";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand command = new SqlCommand(upit, connection);

                command.Parameters.AddWithValue("@KorisnickoIme", klijent.korisnickoIme);
                command.Parameters.AddWithValue("@sifra", klijent.sifra);
                command.Parameters.AddWithValue("@ime", klijent.ime);
                command.Parameters.AddWithValue("@prezime", klijent.prezime);
                command.Parameters.AddWithValue("@adresa", klijent.adresa);
                command.Parameters.AddWithValue("@email", klijent.email);
                command.Parameters.AddWithValue("@telefon", klijent.telefon);


                command.ExecuteNonQuery();
            } catch {
                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }

        public static void InsertKnjiga(Knjiga knjiga) {
            string upit = "INSERT INTO Knjiga VALUES(@autor, @cena, @slika, @kategorija, @naziv)";
            Console.Out.WriteLine(upit);
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand command = new SqlCommand(upit, connection);

                command.Parameters.AddWithValue("@autor", knjiga.autor);
                command.Parameters.AddWithValue("@cena", knjiga.cena);
                command.Parameters.AddWithValue("@slika", knjiga.slika);
                command.Parameters.AddWithValue("@kategorija", knjiga.kategorija);
                command.Parameters.AddWithValue("@naziv", knjiga.naziv);

                command.ExecuteNonQuery();
            } catch {
                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }

        public static int getKnjigaPriceByName(string id) {

            if (id == "") return 0;
            string upit = $"SELECT cena from Knjiga WHERE naziv = '{id}'";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand getCena = new SqlCommand(upit, connection);
                int cena = (int)getCena.ExecuteScalar();

                return cena;
            } catch (Exception) {

                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }

        public static int kreirajPorudzbinu(DateTime datum, int racun) {
            if (racun == 0) return 0;
            string format = "yyyymmdd";
            string upit = $"INSERT INTO porudzbina output INSERTED.ID VALUES (getdate(),{racun})";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand getId = new SqlCommand(upit, connection);
                int id = (int)getId.ExecuteScalar();

                return id;
            } catch (Exception) {

                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }

        }



        public static DataTable VratiSveKnjige() {
            string upit = "SELECT * FROM Knjiga";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                SqlDataAdapter adapter = new SqlDataAdapter(upit, connection);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);

                return tabela;
            } catch {
                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }

        public static void UpdateKnjigu(Knjiga knjiga) {
            string upit = "UPDATE KNJIGA SET" +
                "naziv = @naziv," +
                "autor = @autor, " +
                "cena = @cena, " +
                "slika = @slika, " +
                "kategorija = @kategorija" +
                "where id = @id";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand command = new SqlCommand(upit, connection);

                command.Parameters.AddWithValue("@naziv", knjiga.naziv);
                command.Parameters.AddWithValue("@autor", knjiga.autor);
                command.Parameters.AddWithValue("@cena", knjiga.cena);
                command.Parameters.AddWithValue("@slika", knjiga.slika);
                command.Parameters.AddWithValue("@kategorija", knjiga.kategorija);
                command.Parameters.AddWithValue("@id", knjiga.id);

                command.ExecuteNonQuery();
            } catch {
                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }

        public static void DeleteKnjiga(Knjiga knjiga) {
            string upit = "DELETE FROM KNJIGA where ID = @id";
            SqlConnection connection = null;

            try {
                connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand command = new SqlCommand(upit, connection);
                command.Parameters.AddWithValue("@id", knjiga.id);

                command.ExecuteNonQuery();
            } catch {
                throw;
            } finally {
                if (connection != null) {
                    connection.Close();
                }
            }
        }


    }
}
