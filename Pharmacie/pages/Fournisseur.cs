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
using Bunifu.Framework.UI;

namespace Pharmacie.pages
{
    public partial class Fournisseur : UserControl
    {
        Traitement t = new Traitement();
        AjoutFournisseur a = new AjoutFournisseur();
        Form1 f = new Form1(Login.xy);
        public Fournisseur()
        {
            InitializeComponent();
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            label1.Text = Login.xy;
            if (!(label1.Text == "Admin"))
            {

                mod.Visible = false;
                supp.Visible = false;
            }
            else
            {
                mod.Visible = true;
                supp.Visible = true;
            }

        }
        
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            new AjoutFournisseur().ShowDialog();
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_fournisseur", nbr);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_fournisseur", nbr);
            textBox1.ResetText();
            cbfss.ResetText();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AjoutFournisseur fss = new AjoutFournisseur();
            fss.title.Text = "Modifier fournisseur";
            fss.valider.Text = "Modifier";
            if (t.id > 0)
            {
                t.depacerFss(t.id, fss.nom, fss.raison, fss.ville, fss.adresse, fss.codep, fss.fax, fss.tel1, fss.tel2, fss.mail, fss.site, dataGridView1);
                fss.idd.Text = Convert.ToInt16(t.id).ToString();
                fss.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.selection(t.id, e, dataGridView1);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            t.supprimer(t.id, "t_fournisseur", "id", dataGridView1, "v_fournisseur", nbr);
            t.compter(nbr, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t.recherche(dataGridView1, "select * from v_fournisseur where " + cbfss.Text + " like  '%" + textBox1.Text + "%'", nbr);

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ListeFss l = new ListeFss();
            l.DataSource = t.Report("v_fournisseur");
            ReportPrintTool rp = new ReportPrintTool(l);
            rp.ShowPreviewDialog();
        }

        private void cbfss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
