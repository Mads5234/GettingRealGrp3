using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GettingReal
{
    public class Database_Controller
    {
        private static string conntectionString =
        "Server = ealSQL1.eal.local; Database = A_DB27_2018; User Id = A_STUDENT27; Password = A_OPENDB27;";
        public int thedate;
        public void InsertCustomer()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("Tilføj kunde", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Indtast adresse:");
                    cmd1.Parameters.Add(new SqlParameter("@Adresse", Console.ReadLine()));
                    Console.WriteLine("Indtast postnummer:");
                    cmd1.Parameters.Add(new SqlParameter("@Postnr", Console.ReadLine()));
                    cmd1.Parameters.Add(new SqlParameter("@Dato", DateTime.Today));
                    Console.WriteLine("Indtast kundenavn:");
                    cmd1.Parameters.Add(new SqlParameter("@Kunde", Console.ReadLine()));
                    Console.WriteLine("Indtast telefonnummer:");
                    cmd1.Parameters.Add(new SqlParameter("@Telefonnummer", Console.ReadLine()));
                    Console.WriteLine("Indtast kontaktdato fra 1-12 måneder:");
                    string dato = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Kontaktdato", DateCalc.FindDate(thedate = Convert.ToInt32(dato))));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
        public void InsertShowing()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("Tilføj kunde", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Indtast adresse:");
                    cmd1.Parameters.Add(new SqlParameter("@Adresse", Console.ReadLine()));
                    Console.WriteLine("Indtast postnummer:");
                    cmd1.Parameters.Add(new SqlParameter("@Postnr", Console.ReadLine()));
                    cmd1.Parameters.Add(new SqlParameter("@Dato", DateTime.Today));
                    Console.WriteLine("Indtast kundenavn:");
                    cmd1.Parameters.Add(new SqlParameter("@Kunde", Console.ReadLine()));
                    Console.WriteLine("Indtast telefonnummer:");
                    cmd1.Parameters.Add(new SqlParameter("@Telefonnummer", Console.ReadLine()));
                    int days = 2;
                    cmd1.Parameters.Add(new SqlParameter("@Kontaktdato", DateCalc.DateDay(days)));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
        public void ShowCustomer()
        {
            using (SqlConnection conn = new SqlConnection(conntectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("Find kunde:", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string Adresse = read["Adresse: "].ToString();
                            string Postnr = read["Postnummer: "].ToString();
                            string Dato = read["Dato: "].ToString();
                            string Kunde = read["Kunde: "].ToString();
                            string Telefonnummer = read["Telefonnummer: "].ToString();
                            string KontaktDato= read["Kontaktdato: "].ToString();
                            Console.WriteLine(Adresse + " " + Postnr + " " + Dato + " " + Kunde + " " +Telefonnummer + " " + KontaktDato);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
        public void FindOwnerByAddress(string Adresse)
        {
            using (SqlConnection conn = new SqlConnection(conntectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("Find adresse: ", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@Adresse: ", Adresse));

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string Postnr = read["Postnummer: "].ToString();
                            string Dato = read["Dato: "].ToString();
                            string Kunde = read["Kunde: "].ToString();
                            string Telefonnummer = read["Telefonnummer: "].ToString();
                            string KontaktDato = read["Kontaktdato: "].ToString();
                            Console.WriteLine(Adresse + " " + Postnr + " " + Dato + " " + Kunde + " " + Telefonnummer + " " + KontaktDato);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
        public void FindOwnerByPhone(string Telefonnummer)
        {
            using (SqlConnection conn = new SqlConnection(conntectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("Find telefonnummer: ", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@Telefonnummer: ", Telefonnummer));

                    SqlDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string Adresse = read["Adresse: "].ToString();
                            string Postnr = read["Postnummer: "].ToString();
                            string Dato = read["Dato: "].ToString();
                            string Kunde = read["Kunde: "].ToString();
                            string KontaktDato = read["Kontaktdato: "].ToString();
                            Console.WriteLine(Adresse + " " + Postnr + " " + Dato + " " + Kunde + " " + Telefonnummer + " " + KontaktDato);
                        }
                    }
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
    }
}
