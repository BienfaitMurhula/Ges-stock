using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacie.traitement;
using System.Security.Cryptography;

namespace Pharmacie.pages
{
    public partial class Compte : UserControl
    {
        Traitement t = new Traitement();
        public Compte()
        {
            InitializeComponent();
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            user1.Visible = false;
            pass1.Visible = false;
            fx1.Visible = false;
            det.Visible = false;
            //cacher();
        }

        public void cacher()
        {
            DataGridViewBand b = dataGridView1.Rows[2];
            b.Visible = false;

        }
        private void Compte_Load(object sender, EventArgs e)
        {
          // cacherpwd();
            t.chargement(dataGridView1, "v_users",nbr);
        }

        private void valider_Click(object sender, EventArgs e)
        { 
            if (t.id <= 0)
            {
                t.Users(t.id, Username, pass, conf, fx,"v_users",dataGridView1,nbr);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (t.id > 0)
            {
                t.Users(t.id, Username, pass, conf, fx, "v_users", dataGridView1, nbr);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            t.supprimer(t.id, "t_users", "id", dataGridView1, "v_users",nbr);
        }

        TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            user1.Visible = false;
            pass1.Visible = false;
            fx1.Visible = false;
            t.depacerU(t.id, Username, fx, pass, pass1, conf, dataGridView1);
            det.Text = "Détail";
            det.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (det.Text.Equals("Détail"))
            {
                user1.Visible = true;
                pass1.Visible = true;
                fx1.Visible = true;
                det.Text = "Masquer";
                t.depacerU(t.id, user1, fx1, pass, pass1, conf, dataGridView1);
            }
            else if(det.Text.Equals("Masquer"))
            {
                user1.Visible = false;
                pass1.Visible = false;
                fx1.Visible = false;
                det.Text = "Détail";
            }

        }

        public void cacherpwd()
        {
           // dataGridView1.
        }
  
        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if((e.ColumnIndex==3 && e.Value != null) || (e.ColumnIndex==2 && e.Value != null) )
            {
                e.Value = new String('#', 5);
            }
        }

        private void det_MouseLeave(object sender, EventArgs e)
        {
            //user1.Visible = false;
            //pass1.Visible = false;
            //fx1.Visible = false;
            
        }
    }
}
