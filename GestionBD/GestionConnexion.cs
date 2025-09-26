using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD
{
    public class GestionConnexion
    {
        public static bool VerifConnexion(string login, string mdp)
        {

            GestionBoutique.seConnecter();
            DataTable dtResultat = GestionBoutique.getTuplesRequeteSelect("SELECT * FROM utilisateur WHERE loginUtilisateur ='" + login + 
                "' and passUtilisateur='" + GestionHachage.mdpHachage.HashPassword(mdp) + "'", "VerifConnexion");

            if (dtResultat.Rows.Count == 0)
                return false;
            else
                return true;

        }


    }
}
