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
using Pharmacie.dialogues;

namespace Pharmacie.pages
{
    public partial class Parametre : UserControl
    {
        Traitement t = new Traitement();
        public Parametre()
        {
            InitializeComponent();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Compte());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new Sauvegarder().ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Synthese());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }
    }
}
