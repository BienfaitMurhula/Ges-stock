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
using Pharmacie.Rapport;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using Pharmacie.connexion;

namespace Pharmacie.pages
{
    public partial class Articles : UserControl
    {
        Traitement t = new Traitement();
        AjoutSortie aso = new AjoutSortie();
        //Form1 frm = new Form1();
        public static DataGridView data;
        fonction f = new fonction();
        public static Control sup = new Control();
        private string fo;
        //public static string valeur;
        //  public static Control cl;

        public Articles(String l)
        {
            InitializeComponent();
            label5.Text = l;
            if (!(label5.Text == "Admin"))
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setFonction(string a)
        {
            this.fo = a;
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular);
            t.chargement(dataGridView1, "v_article", nbr);
            t.compter(nbr, dataGridView1);
            //t.calcul(nbr, "t_article");

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            new AjoutArticle().ShowDialog();
        }

        AjoutArticle a = new AjoutArticle();
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //if (Form1.btn.Text == "Admin")
            //{
            //------------------------
            a.title.Text = "Modifier les articles";
            a.valider.Text = "Modifier";
            a.qt.Enabled = false;
            t.depacerArticle(a.idd, a.famille, a.refer, a.des, a.fss, a.rang, a.pu, a.qt, a.qtm, a.datep, dataGridView1);
            a.ShowDialog();
            //--------------------------------

            //}
            //else
            //{

            //MessageBox.Show("Veuillez contacter votre administrateur svp !!");
            //new Verification().ShowDialog();
            //try
            //{
            //    t.innitialiseConnect();
            //    t.con.Open();
            //    t.cmd = new SqlCommand("select passwords from t_users   where passwords = @pass and fonction = 'Admin'", t.con);
            //    //cmd.Parameters.AddWithValue("user", user.Text);
            //    t.cmd.Parameters.AddWithValue("pass", Verification.ps);
            //    t.dr = t.cmd.ExecuteReader();
            //    if (t.dr.Read())
            //    {
            //        // string fx = (t.dr["Fonction"]).ToString();
            //        string pwd = (t.dr["passwords"]).ToString();
            //        if (pwd == Verification.ps.Text)
            //        {
            //            a.title.Text = "Modifier les articles";
            //            a.valider.Text = "Modifier";
            //            a.qt.Enabled = false;
            //            this.Hide();
            //            t.depacerArticle(a.idd, a.famille, a.refer, a.des, a.fss, a.rang, a.pu, a.qt, a.qtm, a.datep, dataGridView1);
            //            a.ShowDialog();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Mot de passe incorrect \n veuillez recommencer svp !!");
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("identifiants incorrects" + ex.Message);
            //    // new Login().Hide();
            //    // new Login().Show();
            //}
            //finally
            //{
            //    t.con.Close();
            //}
        }
        // }
        //public void verifier(Control pass)
        //{
        //    try
        //    {
        //        t.innitialiseConnect();
        //        t.con.Open();
        //        t.cmd = new SqlCommand("select passwords from t_users   where passwords = @pass and fonction = 'Admin'", t.con);
        //        //cmd.Parameters.AddWithValue("user", user.Text);
        //        t.cmd.Parameters.AddWithValue("pass", pass.Text);
        //        t.dr = t.cmd.ExecuteReader();
        //        if (t.dr.Read())
        //        {
        //           // string fx = (t.dr["Fonction"]).ToString();
        //            string pwd = (t.dr["passwords"]).ToString();
        //            if (pwd == pass.Text)
        //            {
        //                a.title.Text = "Modifier les articles";
        //                a.valider.Text = "Modifier";
        //                a.qt.Enabled = false;
        //                this.Hide();
        //                t.depacerArticle(a.idd, a.famille, a.refer, a.des, a.fss, a.rang, a.pu, a.qt, a.qtm, a.datep, dataGridView1);
        //                a.ShowDialog();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Mot de passe incorrect \n veuillez recommencer svp !!");
        //            }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("identifiants incorrects" + e.Message);
        //        // new Login().Hide();
        //        // new Login().Show();
        //    }
        //    finally
        //    {
        //        t.con.Close();
        //    }
        //  }
        AjoutEntree aj = new AjoutEntree();
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (t.id > 0)
            {
                t.depacerentree(aj.idd, aj.famille, aj.refer, aj.des, aj.fss, aj.rang, aj.qts, aj.pa, dataGridView1);
                aj.famille.Enabled = false;
                aj.refer.Enabled = false;
                aj.des.Enabled = false;
                aj.fss.Enabled = false;
                aj.rang.Enabled = false;
                aj.qte.Text = "0";
                aj.idd.Visible = false;
                aj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un élément svp !");
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (t.id > 0)
            {
                t.depacerentree(aso.idd, aso.famille, aso.refer, aso.des, aso.fss, aso.rang, aso.qtee, aso.pv, dataGridView1);
                aso.famille.Enabled = false;
                aso.refer.Enabled = false;
                aso.des.Enabled = false;
                aso.fss.Enabled = false;
                aso.rang.Enabled = false;
                aj.qte.Text = "0";
                aso.idd.Visible = false;
                aso.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un élément svp !");
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            t.supprimer(t.id, "t_article", "id", dataGridView1, "v_article", nbr);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_article", nbr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.selection(t.id, e, dataGridView1);
            //cap.Text = Convert.ToInt16(t.id).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbtrie_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.Trie(dataGridView1, cmbtrie);
        }

        private void flt_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.Filtre(dataGridView1, flt, val);
        }

        private void val_TextChanged(object sender, EventArgs e)
        {
            t.Filtre(dataGridView1, flt, val);
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            ListeAdticles l = new ListeAdticles();
            l.DataSource = t.Report("v_article");
            ReportPrintTool rp = new ReportPrintTool(l);
            rp.ShowPreviewDialog();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            pesemtion(e);

            t.alarm(dataGridView1);

        }

        private void pesemtion(DataGridViewCellFormattingEventArgs e)
        {

            // var expire = null;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                var expire = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells[9].Value);
                var today = DateTime.Today;
                var expiredplus = expire >= today.AddMonths(6);
                var expired = expire >= today.AddMonths(6);
                var expiration = expire <= today.AddMonths(3);
                // var expireToBe = expire >= today.AddDays(-30);
                if (expiredplus)
                {
                    this.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Green;
                    continue;
                }
                else if (expiration)
                {
                    this.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Red;
                    continue;
                }
                else
                {
                    this.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Orange;
                    continue;
                }
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
           // t.alarm(dataGridView1);
            t.recus(dataGridView1, nbr);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            t.chargement(dataGridView1, "v_article", nbr);
        }
    }
}
