using Pharmacie.connexion;
using Pharmacie.traitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie.dialogues
{
    public partial class FrmConfig : Form
    {
        Traitement t = new Traitement();
        public FrmConfig()
        {
            InitializeComponent();
        }
        String chem;
        void chargercombo()
        {
            //cbodata.Items.Add(Environment.MachineName);
            cbodata.Items.Add(".");
            cbodata.Items.Add("(local)");
            cbodata.Items.Add(@".\SQLEXPRESS");
            cbodata.Items.Add(string.Format(@"{0}", Environment.MachineName));
            cbodata.SelectedIndex = 3;
        }
        void connecter()
        {
            PubCon.dataS = cbodata.Text;
            PubCon.initcat = txtbdd.Text;
            PubCon.id = txtuserId.Text;
            PubCon.pass = txtpass.Text;
        }
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            chargercombo();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbodata.Text.Trim() == "" || txtbdd.Text.Trim() == "" || txtuserId.Text.Trim() == "" || txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Completer tous les champs necessaires SVP", "Champs Obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                connecter();
                chem = "Data Source=" + PubCon.dataS + "; Initial Catalog=" + PubCon.initcat + "; User Id=" + PubCon.id + "; Password=" + PubCon.pass + ";";
                PubCon.testFile();
                File.WriteAllText(ClsConstantes.Table.chemin, chem.ToString());
                this.Close();
                new Login().Show();
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pan.Controls.Add(panel2);
            //pan.Show();
        }

        private void restaurerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Restore().ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }
    }
}
