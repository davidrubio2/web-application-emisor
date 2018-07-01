using System;
using System.Collections.Generic;

namespace webappemisor
{
    public class DataAccessEmisor
    {
        string sConnection = "server=localhost;user id=root;password=;persistsecurityinfo=True;port=3306;database=test_candidate;SslMode=none";

        public IEnumerable<Emisor> GetAllEmisor()
        {
            List<Emisor> lstEmisor = new List<Emisor>();
          

            return lstEmisor;
        }
        public string AddEmisor()
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