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
using DevExpress.XtraReports.UI;
using Pharmacie.Rapport;

namespace Pharmacie.pages
{
    public partial class Inventaire : UserControl
    {
        Traitement t = new Traitement();
        AjoutIventaire ai = new AjoutIventaire();
        public static DataGridView f1;
        public static Control f2;
        public Inventaire()
        {
            InitializeComponent();
            f1 = dataGridView1;
            f2 = nbr;
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            t.chargement(dataGridView1, "v_inventaire", nbr);
        }

        private void val_TextChanged(object sender, EventArgs e)
        {
            t.recherche(dataGridView1, "select * from v_inventaireok where " + flt.Text + " like  '%" + val.Text + "%'", nbr);
           // t.Filtre(dataGridView1, flt, val);
        }

        private void flt_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.recherche(dataGridView1, "select * from v_inventaireok where " + flt.Text + " like  '%" + val.Text + "%'", nbr);
           // t.Filtre(dataGridView1, flt, val);
        }

        private void cmbtrie_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.Trie2(dataGridView1, cmbtrie);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.depacerIvent(t.id, ai.famille, ai.refer, ai.des, dataGridView1);
            ai.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_inventaireok", nbr);
           // t.iventalarm(dataGridView1);
            // t.al(dataGridView1);
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (!(dateTimePicker1.Value.Equals("")))
            {
                RapportInventaire ri = new RapportInventaire();
                ReportPrintTool rp = new ReportPrintTool(ri);
                ri.DataSource = t.get_Report_Trier("v_inventaireok", "datecloture", dateTimePicker1, dateTimePicker2);
                //ri.DataSource = t.get_Report_Trier("v_inventaireok", "datecloture", dateTimePicker1.Value);
                rp.ShowPreviewDialog();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_inventaire", nbr);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            t.rechercheDate(nbr, dataGridView1, dateTimePicker1, dateTimePicker2, "v_inventaireok", "datecloture");
            //t.Triedate(dataGridView1, dateTimePicker1);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            t.rechercheDate(nbr, dataGridView1, dateTimePicker1, dateTimePicker2, "v_inventaireok", "datecloture");

        }
    }
}
