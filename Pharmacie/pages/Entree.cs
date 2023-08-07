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
    public partial class Entree : UserControl
    {
        Traitement t = new Traitement();
        public Entree()
        {
            InitializeComponent();
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
        }

        private void Entree_Load(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_Entree order by code desc", nbr);
           // t.montant(cap.Text, "v_entree", "pte", "date_entree", dateTimePicker1, dateTimePicker2);
            //t.calcul(nbr, "v_Entree");
            // nbr.Text = $"Nombre {dataGridView1.RowCount}";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_Entree order by code desc", nbr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.selection(t.id, e, dataGridView1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            t.rechercheDate(nbr, dataGridView1, dateTimePicker1, dateTimePicker2, "v_Entree", " date_entree");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            t.rechercheDate(nbr, dataGridView1, dateTimePicker1, dateTimePicker2, "v_Entree", " date_entree");
        }
       
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ListeEntree l = new ListeEntree();
            l.DataSource = t.get_Report_Trier("v_entree", " date_entree",dateTimePicker1, dateTimePicker2);
            ReportPrintTool rp = new ReportPrintTool(l);
            rp.ShowPreviewDialog();
        }
    }
}
