using GestionBD.MySQL;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionPsFs : GestionBoutique
    {

        #region FS
        // Retourne quelque chose


        public static void addUserFS() 
        {
            var regroupement = new Dictionary<string, object>
            {
                { "@loginUtilisateur", "loginTesteee" },
                { "@passUtilisateur", "monMotsDePassTest" },
                { "@nomUtilisateur", "testNomTest" },
                { "@prenomUtilisateur", "testPrenomTest" },
                { "@emailUtilisateur", "email@test.com" },
                { "@telUtilisateur", "0645874521" },
                { "@adresseRueUtilisateur", "10 rue du test" },
                { "@adresseCpUtilisateur", 34510 },
                { "@adresseVilleUtilisateur", "villeTest2323" },
                { "@isAdmin", 0 }
            };
            appelerProcedureStocke("addUserIfNotExists", regroupement);
        }


        public static DataTable getUserPs()
        {
            try { 
                return getTuplesRequeteSelect("CALL _requette_Consultation_PS('U.*', 'utilisateur U', '1=1');", "userInformation");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }

        public static void creatAndGrantUser_PS(int idUtilisateur)
        {
            try
            {
                executerRequeteAction("CALL _create_and_grant_user_PS_V2("+ idUtilisateur + ",'localhost');");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }

        public static void removeUser_PS(int idUtilisateur)
        {
            try
            {
                executerRequeteAction("CALL _removeUserPrivilegesAndDropUser_PS_V2(" + idUtilisateur + ",'localhost');");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }

        public static string getUsernameById_FS(int idUtilisateur)
        {
            string userName;
            try
            {
                userName = "SELECT _get_username_by_id_FS(" + idUtilisateur + ");";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }

            return userName;
        }



        #endregion
    }
}
