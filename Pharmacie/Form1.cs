using Pharmacie.dialogues;
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

namespace Pharmacie
{
    public partial class Form1 : Form
    {
        Traitement t = new Traitement();
        public static Control bt = new Control();

        Articles a = new Articles(Login.xy);
        public Form1(string l)
        {
            InitializeComponent();
            t.appel(pan, new Entree());
            label3.Text = l;
            //a.label5.Text = l;
            bt = parame;
            if (Login.xy == "Admin")
            {
            }
            else
            {
                t.appel(pan, new Articles(l));
                ivent.Visible = false;
                parame.Visible = false;
            }
        }
        public void afficher(params Control[] c)
        {
            if (!(label3.Text.Equals("Admin")))
            {
                foreach (Control a in c)
                {
                    a.Visible = false;
                }
            }
        }
        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // a.label4.Text = label3.Text;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Copy(label1);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Sauvegarder s = new Sauvegarder();
            s.saveBackup();
            Application.Exit();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Articles(Login.xy));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Entree());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Sortie());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Fournisseur());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Famille());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Inventaire());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.appel(pan, new Parametre());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //timer1.Enabled = true;
           // t.appel(pan, new Articles(Login.xy));
           // timer1.Interval=50;
            timer1.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }
    }
}
