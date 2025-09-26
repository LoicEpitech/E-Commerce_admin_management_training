using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace LiaKosShop
{
    internal static class Program
    {  
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool devMode = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (devMode) {
                GestionBoutique.seConnecter();
                Application.Run(new FrmAccueil());
            } else {
                Application.Run(new FrmConnexion());
            }

            //
        }

    }
}
