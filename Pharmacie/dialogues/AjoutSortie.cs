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
    public partial class AjoutSortie : Form
    {
        Traitement t = new Traitement();
        public AjoutSortie()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            t.Sortie(t.id, dateS, refer, qte, pv, rem, comment,cli,prove);
            
        }
    }
}
