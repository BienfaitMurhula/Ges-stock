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
    public partial class AjoutIventaire : Form
    {
        Traitement t = new Traitement();
        public AjoutIventaire()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void fss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void famille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refer_TextChanged(object sender, EventArgs e)
        {

        }

        private void pa_TextChanged(object sender, EventArgs e)
        {

        }

        private void des_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void qte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            t.suivant(code,famille, refer, des);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            t.Invent(refer, qte, Inventaire.f1, "v_inventaire", Inventaire.f2);
        }
    }
}
