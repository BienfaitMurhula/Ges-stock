using Pharmacie.connexion;
using Pharmacie.dialogues;
using Pharmacie.pages;
using Pharmacie.traitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pharmacie
{
    public partial class Login : Form
    {
        Traitement t = new Traitement();
        SqlCommand cmd;
        SqlDataReader dr;
       // Form1 f = new Form1(xy);
        //Articles ar = new Articles();
        //Fournisseur fo = new Fournisseur();
        //fonction fc = new fonction();
        //public string fonct;
        public static string xy;
        public Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            login(usern, pass);
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            t.Copy(label4);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmConfig().Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            public string fx;
        public void login(Control user, Control pass)
        {
            try
            {
                t.innitialiseConnect();
                
                t.con.Open();
                cmd = new SqlCommand("select username,passwords,Fonction from t_users   where Username = @user and passwords = @pass", t.con);
                cmd.Parameters.AddWithValue("user", user.Text);
                cmd.Parameters.AddWithValue("pass", pass.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                     fx = (dr["Fonction"]).ToString();
                    
                    if (fx == "Admin")
                    {
                        this.Hide();
                        xy = fx;
                        new Form1(fx).Show();

                    }
                    else if (fx == "Pharmacien(e)")
                    {
                        this.Hide();
                        new Form1(fx);
                        xy = fx;
                        new Form1(fx).Show();
                    }
                    
                }else
                    {
                        MessageBox.Show("Vérifier vos identifiants svp !");
                        user.ResetText();
                        pass.ResetText();
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("identifiants incorrects" + e.Message);
                this.Show();
            }
            finally
            {
                t.con.Close();
            }
        }

        //AjoutArticle a = new AjoutArticle();
        //Verification v = new Verification();
        //public void Verification(Control pass)
        //{
        //    try
        //    {
        //        t.innitialiseConnect();
        //        t.con.Open();
        //        cmd = new SqlCommand("select passwords,Fonction from t_users   where passwords = @pass", t.con);
        //        //cmd.Parameters.AddWithValue("user", user.Text);
        //        cmd.Parameters.AddWithValue("pass", pass.Text);
        //        dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            string fx = (dr["Fonction"]).ToString();
        //            string pwd = (dr["passwords"]).ToString();
        //            if (fx == "Admin" && pwd == "passwords")
        //            {
        //                t.depacerArticle(a.idd, a.famille, a.refer, a.des, a.fss, a.rang, a.pu, a.qt, a.qtm, a.datep, ar.dataGridView1);
        //                a.ShowDialog();
        //            }
        //            else { }

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("identifiants incorrects" + e.Message);
        //        // new Login().Hide();
        //        new Login().Show();
        //    }
        //    finally
        //    {
        //        t.con.Close();
        //    }
        //}
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = true;
            }
            else
            {
                pass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pass_MouseLeave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                errorProvider1.SetError(pass, " Mot de passe obligatoire");
                pass.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void usern_MouseLeave(object sender, EventArgs e)
        {
            if (usern.Text == "")
            {
                errorProvider1.SetError(usern, " Nom d'utilisateur obligatoire");
                usern.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
    
}
