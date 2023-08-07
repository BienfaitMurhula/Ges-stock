using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie.connexion
{
    class Connexion
    {
        public static string chemin;

        public void connect()
        {

            PubCon.testFile();
            chemin = File.ReadAllText(ClsConstantes.Table.chemin).Trim();

        }
    }
}
