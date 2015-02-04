using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class SQLAccess
    {
        public static SqlConnection Connexion()
        {
            try
            {
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["Principale"].ToString();
                cnx.Open();
                return cnx;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
