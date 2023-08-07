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
    public partial class AjoutFournisseur : Form
    {
        Traitement t = new Traitement();

        public AjoutFournisseur()
        {
            InitializeComponent();
            idd.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
           // idd.Text;
            if (idd.Text=="0" || idd.Text=="")
            {
                t.insertionFss(idd, nom, raison, ville, adresse, codep, fax, tel1, tel2, mail, site, "Fournisseur ajouté");
                idd.Text = "0";
            }
            else
            {
                t.insertionFss(idd, nom, raison, ville, adresse, codep, fax, tel1, tel2, mail, site, "Fournisseur Modifié");
                idd.Text = "0";
            }
        }
    }
}
