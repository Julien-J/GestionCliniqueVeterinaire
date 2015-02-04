using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALVeterinaire
    {
        public static bool CreateVeterinaire(BOVeterinaire veterinaire)
        {
            int resultat = 0;
            SqlConnection cnx = null;
            try
            {
                using (cnx = SQLAccess.Connexion())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO Veterinaires VALUES(@Nom, @mdp, @archive)";
                    command.Parameters.Add(new SqlParameter("@Nom", veterinaire.Nom));
                    command.Parameters.Add(new SqlParameter("@mdp", veterinaire.MotDePasse));
                    command.Parameters.Add(new SqlParameter("@archive", veterinaire.Archive));


                    resultat = command.ExecuteNonQuery();

                    if (resultat > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur :" + ex.ToString());
            }

        }

    }
}
