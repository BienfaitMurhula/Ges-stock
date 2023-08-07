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
    public partial class AjoutArticle : Form
    {
        Traitement t = new Traitement();
        public AjoutArticle()
        {
            InitializeComponent();
            charger();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void AjoutArticle_Load(object sender, EventArgs e)
        {
           // charger();
        }

        private void charger()
        {
            t.chargeCombo(rang, "nom_rangement", "t_rangement");
            t.chargeCombo(fss, "Nom_complet", "t_fournisseur");
            t.chargeCombo(famille, "nom_famille", "t_famille");
        }

        private void valider_Click(object sender, EventArgs e)
        {
            if (valider.Text.Equals("Enregistrer"))
            {
            t.insertionArticle(idd, famille, refer, des, fss, rang, pu, qt, qtm, datep);
            }
            else if(Convert.ToInt16(idd.Text) > 0)
            {
                t.insertionArticle(idd, famille, refer, des, fss, rang, pu, qt, qtm, datep);
            }
            
        }

        private void famille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refer_TextChanged(object sender, EventArgs e)
        {

        }

        private void des_TextChanged(object sender, EventArgs e)
        {

        }

        private void fss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
