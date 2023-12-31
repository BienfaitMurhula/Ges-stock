﻿using Pharmacie.connexion;
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

namespace Pharmacie.dialogues
{
    public partial class Sauvegarder : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Traitement bd = new Traitement();
        Connexion ap = new Connexion();

        public Sauvegarder()
        {
            InitializeComponent();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    personalizePath.Text = dlg.SelectedPath;
                    btnSauvegarde.Enabled = true;
                }
            }
            catch (Exception)
            { }
        }

        private void btnSauvegarde_Click(object sender, EventArgs e)
        {
            saveBackup();
        }

        public void saveBackup()
        {
            try
            {
                ap.connect();
                con = new SqlConnection(Connexion.chemin);
                string database = con.Database.ToString();

                if (bd.getBackupPath(personalizePath) == string.Empty)
                {
                    MessageBox.Show("Veuillez selectionner d'abord un emplacement s.v.p.!");
                }
                else
                {

                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + bd.getBackupPath(personalizePath) + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sauvegarde effectué avec succés", "Confirmation Sauvegarde");
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Sauvegarder_Load(object sender, EventArgs e)
        {
            try
            {
                personalizePath.Text = bd.getBackupPath(personalizePath);
            }
            catch (Exception)
            { }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }
    }
}
