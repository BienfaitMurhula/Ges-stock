using Pharmacie.dialogues;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie.connexion
{
    class PubCon
    {
        public static String connec;
        public static String dataS;
        public static String initcat;
        public static String id;
        public static String pass;
        public static int etat = 0;
        //=========sms==============
        //public static int port;
        //public static int baudRate;
        //public static int timeout;
        //public static GsmCommMain comm;
       //Login l = new Login();
        public static void testFile()
        {
            if (Directory.Exists(ClsConstantes.Table.InitialDirectory) == true) {

            }

            else
            {
                Directory.CreateDirectory(ClsConstantes.Table.InitialDirectory);
            }

            if (File.Exists(ClsConstantes.Table.chemin) == true)
            {
                //connec = File.ReadAllText("C:\\cheminBdCredit\\monChemin.txt");
            }
            else
            {
                FrmConfig frm = new FrmConfig();
                new Login().Show();
                frm.Hide();
            }
        }
    }
}
