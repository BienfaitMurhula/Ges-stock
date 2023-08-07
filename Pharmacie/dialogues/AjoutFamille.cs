using Pharmacie.pages;
using Pharmacie.traitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie.dialogues
{
    public partial class AjoutFamille : Form
    {
        Traitement t = new Traitement();

        Famille f = new Famille();
        public AjoutFamille()
        {
            InitializeComponent();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void valider_Click(object sender, EventArgs e)
        {
            if (title.Text.Equals("Ajouter une famille") && valider.Text.Equals("Enregistrer"))
            {
                t.famille(iddf, nom, desc, "sp_famille ", f.dataGridView1, "T_famille", f.nbrf);
                iddr.Text = "";
                iddf.Text = "";
            }
            else if (title.Text.Equals("Modifier la famille") && valider.Text.Equals("Modifier"))
            {
                if (Convert.ToInt16(iddf.Text) > 0)
                {
                    t.famille(iddf, nom, desc, "sp_famille ", f.dataGridView1, "T_famille",f.nbrf);
                    iddr.Text = "";
                    iddf.Text = "";
                }
                else
                {
                    MessageBox.Show("la valeur est " + f.s);
                }

            }
            else if(title.Text.Equals("Ajouter une rangée") && valider.Text.Equals("Enregistrer"))
            {
                    t.famille(iddr, nom, desc, "sp_rangement ", f.dataGridView2, "T_rangement",f.nbrr);
                    iddf.Text = "";
                    iddr.Text = "";
            }
            else if(title.Text.Equals("Modifier une rangée") && valider.Text.Equals("Modifier"))
            {
                if (Convert.ToInt16(iddr.Text) > 0)
                {
                    t.famille(iddr, nom, desc, "sp_rangement ", f.dataGridView2, "T_rangement",f.nbrr);
                    iddr.Text = "";
                    iddf.Text = "";
                }
                else
                {
                    MessageBox.Show("la valeur est " + f.s);
                }
            }
        }
    }
}
