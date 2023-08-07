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

namespace Pharmacie.pages
{
    public partial class Synthese : UserControl
    {
        Traitement t = new Traitement();
        public Synthese()
        {
            InitializeComponent();
            //if (Convert.ToDouble(S_sortie.Text) == 0)
            //{
            //    S_sortie.ForeColor = Color.Red;
            //}
            //else
            //{
            //    t.montant(S_sortie, "v_sortie", "ptv", "date_sortie", dt3, dt4);
            //}
    }

        private void Synthese_Load(object sender, EventArgs e)
        {
            t.compter(N_fss, "v_fournisseur");
            t.compter(N_prod, "v_article");
            t.compter(N_entree, "v_entree");
            t.compter(N_sortie, "v_sortie");
            t.calcul(s_prod, "prix", "v_article");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            t.montant(S_entree, "v_entree", "pua", "date_entree", dt1.Value, dt2.Value,N_entree);
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            t.montant(S_entree, "v_entree", "pua", "date_entree", dt1.Value, dt2.Value,N_entree);
        }

        private void dt3_ValueChanged(object sender, EventArgs e)
        {
            t.montant(S_sortie, "v_sortie", "ptv", "date_sortie", dt3.Value, dt4.Value,N_sortie);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dt4_ValueChanged(object sender, EventArgs e)
        {
            t.montant(S_sortie, "v_sortie", "ptv", "date_sortie", dt3.Value, dt4.Value, N_sortie);
        }
    }
}
