using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace webappemisor.Models
{
    public class DataAccessEmisor
    {
        string sConnection = "server=localhost;user id=root;password=;persistsecurityinfo=True;port=3306;database=test_candidate;SslMode=none";

        public IEnumerable<Emisor> GetAllEmisor()
        {
            List<Emisor> lstEmisor = new List<Emisor>();
            using (MySqlConnection con = new MySqlConnection(sConnection))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM test_candidate.emisor;", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Emisor emisor = new Emisor();
                    emisor.Id = Convert.ToString(rdr["Id"]);
                    emisor.Rfc = Convert.ToString(rdr["Rfc"]);
                    emisor.FechaInicioOperacion = Convert.ToDateTime(rdr["FechaInicioOperacion"]);
                    emisor.Capital = Convert.ToDecimal(rdr["Capital"]);

                    lstEmisor.Add(emisor);
                }
                con.Close();
            }
            return lstEmisor;
        }
        public string AddEmisor(Emisor emisor)
        {
            string sRespuesta = "Ok";
            try
            {
                using (MySqlConnection con = new MySqlConnection(sConnection))
                {

                    MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO test_candidate.emisor(Id,Rfc,FechaInicioOperacion,Capital) VALUES(@Id,@Rfc,@FechaInicioOperacion,@Capital);", con);

                    cmd.Parameters.AddWithValue("@Id", emisor.Id);
                    cmd.Parameters.AddWithValue("@Rfc", emisor.Rfc);
                    cmd.Parameters.AddWithValue("@FechaInicioOperacion", emisor.FechaInicioOperacion);
                    cmd.Parameters.AddWithValue("@Capital", emisor.Capital);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                sRespuesta = ex.ToString();
            }

            return sRespuesta;
        }

        public string DeleteEmisor()
        {
            string sRespuesta = "Ok";
            try
            {

            }
            catch (Exception ex)
            {
                sRespuesta = ex.ToString();
            }

            return sRespuesta;

        }

        public string AlterEmisor()
        {
            string sRespuesta = "Ok";
            try
            {

            }
            catch (Exception ex)
            {
                sRespuesta = ex.ToString();
            }

            return sRespuesta;

        }
    }
}