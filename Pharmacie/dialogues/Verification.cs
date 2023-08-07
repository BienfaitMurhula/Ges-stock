using Pharmacie.pages;
using Pharmacie.traitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie.dialogues
{
    public partial class Verification : Form
    {
        Traitement t = new Traitement();
        AjoutArticle a = new AjoutArticle();
       // Articles ar = new Articles();
        public static Control ps;
        public Verification()
        {
            InitializeComponent();
            ps = new Control();
            ps = pwd;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           //ar.verifier(pwd);
        }
        
    }
}
