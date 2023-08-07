using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacie.dialogues;
using Pharmacie.traitement;
using Pharmacie.Rapport;
using DevExpress.XtraReports.UI;

namespace Pharmacie.pages
{
    public partial class Famille : UserControl
    {
        Traitement t = new Traitement();
        //private DataGridView f1;
        public int s;
        
        public Famille()
        {
            InitializeComponent();
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            this.dataGridView2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

        }
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            AjoutFamille af = new AjoutFamille();
            af.title.Text = "Ajouter une rangée";
            //af.valider.Text = "Modifier";
            af.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AjoutFamille af = new AjoutFamille();
            af.title.Text = "Modifier une rangée";
            af.valider.Text = "Modifier";
           
                if (Convert.ToInt16(iddr.Text) > 0)
                {
                    t.depacerFRU(t.id, af.nom, af.desc, dataGridView2);
                    af.iddf.Text = "";
                    af.iddr.Text = Convert.ToString(t.id);
                    af.ShowDialog();
                }
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new AjoutFamille().ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AjoutFamille af = new AjoutFamille();
            af.title.Text = "Modifier la famille";
            af.valider.Text = "Modifier";
    
                if (Convert.ToInt16(iddf.Text) > 0)
                {
                    t.depacerFRU(t.id, af.nom, af.desc, dataGridView1);
                    af.iddr.Text = "";
                    af.iddf.Text = Convert.ToString(t.id);
                    af.ShowDialog();
                }
        }
        private void Famille_Load(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "T_famille",nbrf);
            t.chargement(dataGridView2, "T_rangement",nbrr);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.selection(t.id, e, dataGridView2);
            s = t.id;
            iddr.Text = Convert.ToInt16(s).ToString();
            iddf.Text = "";
            dataGridView1.ClearSelection();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.selection(t.id, e, dataGridView1);
           s = t.id;
            iddr.Text = "";
            iddf.Text = Convert.ToInt16(s).ToString();
            dataGridView2.ClearSelection();

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            t.supprimer(t.id, "T_rangement", "id", dataGridView2, "T_rangement",nbrr);
            //t.compter(nbrr, dataGridView2);
            //t.compter(nbrf, dataGridView1);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            t.supprimer(t.id, "T_famille", "id", dataGridView1, "T_famille",nbrf);
            //t.compter(nbrr, dataGridView2);
            //t.compter(nbrf, dataGridView1);

        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Liste_rangee l = new Liste_rangee();
            l.DataSource = t.Report("t_rangement");
            ReportPrintTool rp = new ReportPrintTool(l);
            rp.ShowPreviewDialog();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            ListeFamille l = new ListeFamille();
            l.DataSource = t.Report("t_famille");
            ReportPrintTool rp = new ReportPrintTool(l);
            rp.ShowPreviewDialog();
        }
    }
}
