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
    public partial class AjoutEntree : Form
    {
        Traitement t = new Traitement();
        public AjoutEntree()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            t.Entree(idd, date, refer, qte, pa, comment);
        }
    }
}
