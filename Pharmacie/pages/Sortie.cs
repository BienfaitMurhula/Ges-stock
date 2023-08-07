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
using Pharmacie.Rapport;
using DevExpress.XtraReports.UI;

namespace Pharmacie.pages
{
    public partial class Sortie : UserControl
    {
        Traitement t = new Traitement(); 
        public Sortie()
        {
            InitializeComponent();
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
        }
        private void Sortie_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            t.chargement(dataGridView1, "v_sortie order by code desc",nbr);
           // nbr.Text = $"Nombre {dataGridView1.RowCount}";
            //t.calcul(nbr, "v_sortie");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_sortie order by code desc", nbr);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            t.rechercheDate(nbr, dataGridView1, dateTimePicker1, dateTimePicker2, "v_sortie ", " date_sortie");
        }

        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            t.rechercheDate(nbr, dataGridView1, dateTimePicker1, dateTimePicker2, "v_sortie ", "date_sortie");
            //t.calcul(tot.Text, dataGridView1, dateTimePicker1, dateTimePicker2);

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ListeSortie l = new ListeSortie();
            l.DataSource = t.get_Report_Trier("v_sortie", "date_sortie", dateTimePicker1, dateTimePicker2);
            ReportPrintTool rp = new ReportPrintTool(l);
            rp.ShowPreviewDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.recherche(dataGridView1, "select * from v_sortie where types = '"+comboBox1.Text+"'", nbr);
        }
    }
}
