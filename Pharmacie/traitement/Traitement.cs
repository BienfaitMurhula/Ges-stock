using Pharmacie.connexion;
using Pharmacie.pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie.traitement
{

    class Traitement
    {

        private static Traitement tt;
        public SqlConnection con = null;
        public SqlCommand cmd;
        SqlDataAdapter dt;
        public SqlDataReader dr;
        // SqlConnection con = new SqlConnection(Connexion.chemin);
        Connexion c = null;
        public int id = 0;

        public void innitialiseConnect()
        {
            try
            {
                c = new Connexion();
                c.connect();
                con = new SqlConnection(Connexion.chemin);
            }
            catch (Exception)
            {
                throw new Exception("l'un de vos fichiers de configuration est incorrect");
            }
        }
        public static Traitement GetInstance()
        {
            if (tt == null)
                tt = new Traitement();
            return tt;
        }
        private static void setParameter(SqlCommand cmd, string name, DbType type, int length, object paramValue)
        {
            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;

            if (paramValue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;
                }
                a.Value = DBNull.Value;
            }
            else
                a.Value = paramValue;
            cmd.Parameters.Add(a);
        }

        internal void Copy(Label lab)
        {
            String date = DateTime.Now.ToString("yyyy");
            lab.Text = "© " + date + " Solution - Technologie Tous droits reservés";
        }

        public void appel(Panel p, UserControl u)
        {
            p.Controls.Clear();
            p.Controls.Add(u);
            p.Show();
        }
        public void chargement(DataGridView d, String sql, Control nbr)
        {
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand com = new SqlCommand("select * from " + sql + "", con);
                DataTable dt = new DataTable();
                SqlDataReader dtr = com.ExecuteReader();
                dt.Load(dtr);
                con.Close();
                d.DataSource = dt;
                d.ClearSelection();
                compter(nbr, d);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de chargement" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void compter(Control nbr, DataGridView d)
        {
            nbr.Text = $"{d.RowCount - 1}";
        }
        public void recherche(DataGridView d, String sql, Control c)
        {

            try
            {
                innitialiseConnect();
                con.Open();
                DataTable tab = new DataTable();
                dt = new SqlDataAdapter(sql, con);
                dt.Fill(tab);
                d.DataSource = tab;
                con.Close();
                compter(c, d);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de chargement" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void chargeCombo(ComboBox cmb, string nomChamp, string nomTable)
        {
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
                using (IDbCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = " select distinct " + nomChamp + " from " + nomTable + "";
                    IDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        string de = rd[nomChamp].ToString();
                        cmb.Items.Add(de);
                    }
                    con.Close();
                    rd.Close();
                    rd.Dispose();
                    cmd.Dispose();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        public void supprimer(int code, String table, string col, DataGridView d, string sql, Control nbr)
        {
            try
            {
                if (id > 0)
                {
                    innitialiseConnect();
                    DialogResult res = MessageBox.Show("Voulez-vous supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("delete from " + table + " where " + col + "= @id", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        chargement(d, sql, nbr);
                        MessageBox.Show("Suppression reussie ");
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de suppression " + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void viderControl(params Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Text = "";
            }
        }
        public void insertionFss(Control code, TextBox nom, TextBox raison, TextBox ville, TextBox adresse, TextBox codep, TextBox fax, MaskedTextBox tel1, MaskedTextBox te2, TextBox mail, TextBox site, String mess)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("exec sp_fournisseur @id,@nom,@raison,@ville,@adresse,@code, @fax, @tel1, @tel2, @mail,@site", con);
                cmd.Parameters.AddWithValue("@id", code.Text);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@raison", raison.Text);
                cmd.Parameters.AddWithValue("@ville", ville.Text);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@code", codep.Text);
                cmd.Parameters.AddWithValue("@fax", fax.Text);
                cmd.Parameters.AddWithValue("@tel1", tel1.Text);
                cmd.Parameters.AddWithValue("@tel2", te2.Text);
                cmd.Parameters.AddWithValue("@mail", mail.Text);
                cmd.Parameters.AddWithValue("@site", site.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(mess);
                //chargement(d, "v_fournisseur", nbr);
                //MessageBox.Show("Stock ajouté avec succès");
                viderControl(code, nom, raison, ville, adresse, codep, fax, tel1, te2, mail, site);
                //id = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void insertionArticle(Control code, Control famille, Control refer, TextBox design, Control fss, Control rang, Control pu, Control qte, Control qtemin, DateTimePicker date)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("exec sp_article @id,@famille,@ref,@fss,@rang, @pu, @qt, @qtm, @date, @des", con);
                cmd.Parameters.AddWithValue("@id", code.Text);
                cmd.Parameters.AddWithValue("@famille", famille.Text);
                cmd.Parameters.AddWithValue("@ref", refer.Text);
                cmd.Parameters.AddWithValue("@des", design.Text);
                cmd.Parameters.AddWithValue("@fss", fss.Text);
                cmd.Parameters.AddWithValue("@rang", rang.Text);
                cmd.Parameters.AddWithValue("@pu", pu.Text);
                cmd.Parameters.AddWithValue("@qt", qte.Text);
                cmd.Parameters.AddWithValue("@qtm", qtemin.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(date.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bien reussi");
                //chargement(d,"")
                viderControl(code, famille, refer, design, fss, rang, pu, qte, qtemin, date);
                id = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Sortie(int code, DateTimePicker date, Control refer, Control qte, Control pu, Control remise, TextBox comment, Control cl, Control prov)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("exec sp_sortie @id,@date, @ref, @qt,@pu, @rem, @comm,@cons,@prov", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(date.Text));
                cmd.Parameters.AddWithValue("@ref", refer.Text);
                cmd.Parameters.AddWithValue("@qt", qte.Text);
                cmd.Parameters.AddWithValue("@pu", pu.Text);
                cmd.Parameters.AddWithValue("@rem", remise.Text);
                cmd.Parameters.AddWithValue("@comm", comment.Text);
                cmd.Parameters.AddWithValue("@cons", cl.Text);
                cmd.Parameters.AddWithValue("@prov", prov.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bien reussi");
                viderControl(refer, qte, pu, remise, comment);
                id = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Entree(Control code, DateTimePicker date, Control refer, Control qte, TextBox pu, TextBox comment)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("exec sp_entree @date, @ref, @qt,@pu, @comm", con);
                //  cmd.Parameters.AddWithValue("@id", code.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(date.Text));
                cmd.Parameters.AddWithValue("@ref", refer.Text);
                cmd.Parameters.AddWithValue("@qt", qte.Text);
                cmd.Parameters.AddWithValue("@pu", pu.Text);
                cmd.Parameters.AddWithValue("@comm", comment.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bien reussi");
                viderControl(date, refer, qte, pu, comment);
                id = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Users(int code, Control username, TextBox password, TextBox confirm, Control fx, string table, DataGridView d, Control c)
        {
            if (!String.IsNullOrEmpty(username.Text))
            {
                if (String.Compare(password.Text, confirm.Text) == 0)
                {
                    try
                    {
                        innitialiseConnect();
                        con.Open();
                        cmd = new SqlCommand("exec sp_users @id,@user, @pwd, @fx", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@user", username.Text);
                        cmd.Parameters.AddWithValue("@pwd", password.Text);
                        cmd.Parameters.AddWithValue("@fx", fx.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Bien reussi");
                        chargement(d, table, c);
                        viderControl(username, password, fx, confirm);
                        id = 0;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erreur" + e.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Les mots passes ne sont pas identiques");
                }
            }
        }
        public void famille(Control code, Control nom, TextBox designation, String table, DataGridView d, String sql, Control nbr)
        {
            if (!String.IsNullOrEmpty(nom.Text))
            {
                try
                {
                    innitialiseConnect();
                    con.Open();
                    cmd = new SqlCommand("exec " + table + " @id, @nom, @des", con);
                    cmd.Parameters.AddWithValue("@id", code.Text);
                    cmd.Parameters.AddWithValue("@nom", nom.Text);
                    cmd.Parameters.AddWithValue("@des", designation.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bien reussi");
                    chargement(d, sql, nbr);
                    viderControl(nom, designation);
                    id = 0;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur" + e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void Invent(Control refer, TextBox qter, DataGridView d, String sql, Control nbr)
        {
            if (Convert.ToDouble(qter.Text) > 0)
            {
                try
                {
                    innitialiseConnect();
                    con.Open();
                    cmd = new SqlCommand("exec sp_Inventaire @ref, @qte", con);
                    cmd.Parameters.AddWithValue("@ref", refer.Text);
                    cmd.Parameters.AddWithValue("@qte", qter.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bien reussi");
                    chargement(d, sql, nbr);
                    viderControl(qter);
                    id = 0;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur" + e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void selection(int code, DataGridViewCellEventArgs e, DataGridView d)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = d.Rows[e.RowIndex];
                id = Convert.ToInt32(r.Cells[0].Value);
            }
        }

        public void depacerU(int code, Control username, Control fx, Control pass, Control pass1, Control conf, DataGridView d)
        {
            if (d.RowCount > 0)
            {
                id = Convert.ToInt32(d.CurrentRow.Cells[0].Value);
                username.Text = d.CurrentRow.Cells[1].Value.ToString();
                fx.Text = d.CurrentRow.Cells[2].Value.ToString();
                pass1.Text = d.CurrentRow.Cells[3].Value.ToString();
                byte[] textAsByte = Encoding.Default.GetBytes("12345678");
                byte[] textAsByte2 = Encoding.Default.GetBytes("123456789");

                SHA512 sha512 = SHA512Cng.Create();
                byte[] hash = sha512.ComputeHash(textAsByte);
                byte[] hash2 = sha512.ComputeHash(textAsByte2);
                pass.Text = Convert.ToBase64String(hash);
                conf.Text = Convert.ToBase64String(hash2);
            }
            else
            {
                MessageBox.Show("Aucune donnée à modifier");
            }
        }
        public void depacerFRU(int code, Control username, Control fx, DataGridView d)
        {
            if (id > 0)
            {
                id = Convert.ToInt32(d.CurrentRow.Cells[0].Value);
                username.Text = d.CurrentRow.Cells[1].Value.ToString();
                fx.Text = d.CurrentRow.Cells[2].Value.ToString();
                byte[] textAsByte = Encoding.Default.GetBytes("12345678");

                SHA512 sha512 = SHA512Cng.Create();
                byte[] hash = sha512.ComputeHash(textAsByte);
                //co.pass.Text = Convert.ToBase64String(hash);
                //co.conf.Text = Convert.ToBase64String(hash);
            }
            else
            {
                MessageBox.Show("Aucune donnée à modifier");
            }
        }
        public void depacerentree(Control code, Control famille, Control refer, Control design, Control fss, Control rang, Control qte, Control pu, DataGridView d)
        {
            if (id > 0)
            {
                id = Convert.ToInt32(d.CurrentRow.Cells[0].Value);
                code.Text = d.CurrentRow.Cells[0].Value.ToString();
                famille.Text = d.CurrentRow.Cells[1].Value.ToString();
                refer.Text = d.CurrentRow.Cells[2].Value.ToString();
                design.Text = d.CurrentRow.Cells[3].Value.ToString();
                fss.Text = d.CurrentRow.Cells[4].Value.ToString();
                rang.Text = d.CurrentRow.Cells[5].Value.ToString();
                qte.Text = d.CurrentRow.Cells[7].Value.ToString();
                pu.Text = d.CurrentRow.Cells[6].Value.ToString();
                famille.Enabled = false;

            }
            else
            {
                MessageBox.Show("Aucune donnée à modifier");
            }
        }
        public void depacerArticle(Control code, Control famille, Control refer, Control design, Control fss, Control rang, Control pu, Control qte, Control qtemin, DateTimePicker date, DataGridView d)
        {

            if (id > 0)
            {
                id = Convert.ToInt32(d.CurrentRow.Cells[0].Value);
                code.Text = d.CurrentRow.Cells[0].Value.ToString();
                famille.Text = d.CurrentRow.Cells[1].Value.ToString();
                refer.Text = d.CurrentRow.Cells[2].Value.ToString();
                design.Text = d.CurrentRow.Cells[3].Value.ToString();
                fss.Text = d.CurrentRow.Cells[4].Value.ToString();
                rang.Text = d.CurrentRow.Cells[5].Value.ToString();
                pu.Text = d.CurrentRow.Cells[6].Value.ToString();
                qte.Text = d.CurrentRow.Cells[7].Value.ToString();
                qtemin.Text = d.CurrentRow.Cells[8].Value.ToString();
                date.Text = d.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Aucune donnée à modifier");
            }

        }
        int i = 0;
        public void suivant(Control code, Control famille, Control refer, Control design)
        {
            innitialiseConnect();
            con.Open();
            cmd = new SqlCommand("select * from v_inventaire", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                code.Text = dr[0].ToString();
                famille.Text = dr[1].ToString();
                refer.Text = dr[2].ToString();
                design.Text = dr[3].ToString();
            }
        }
        public void depacerIvent(int code, Control famille, Control refer, Control design, DataGridView d)
        {
            famille.Text = d.CurrentRow.Cells[1].Value.ToString();
            refer.Text = d.CurrentRow.Cells[2].Value.ToString();
            design.Text = d.CurrentRow.Cells[3].Value.ToString();
        }
        public void depacerFss(int code, TextBox nom, TextBox raison, TextBox ville, TextBox adresse, TextBox codep, TextBox fax, MaskedTextBox tel1, MaskedTextBox te2, TextBox mail, TextBox site, DataGridView d)
        {

            if (id > 0)
            {
                id = Convert.ToInt32(d.CurrentRow.Cells[0].Value);
                nom.Text = d.CurrentRow.Cells[1].Value.ToString();
                raison.Text = d.CurrentRow.Cells[2].Value.ToString();
                ville.Text = d.CurrentRow.Cells[3].Value.ToString();
                adresse.Text = d.CurrentRow.Cells[4].Value.ToString();
                codep.Text = d.CurrentRow.Cells[5].Value.ToString();
                fax.Text = d.CurrentRow.Cells[6].Value.ToString();
                tel1.Text = d.CurrentRow.Cells[7].Value.ToString();
                te2.Text = d.CurrentRow.Cells[8].Value.ToString();
                mail.Text = d.CurrentRow.Cells[9].Value.ToString();
                site.Text = d.CurrentRow.Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Aucune donnée à modifier");
            }
        }
        public void rechercheDate(Control nbr, DataGridView d, DateTimePicker d1, DateTimePicker d2, string table, string col)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable(table))
                    {
                        using (cmd = new SqlCommand("select * from " + table + " where " + col + " between @da1 and @da2  order by code desc", con)) ;
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@da1", DateTime.Parse(d1.Text));
                            cmd.Parameters.AddWithValue("@da2", DateTime.Parse(d2.Text));
                            dt = new SqlDataAdapter(cmd);
                            dt.Fill(dta);
                            con.Close();
                            d.DataSource = dta;
                            compter(nbr, d);
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void Trie2(DataGridView d, Control cb)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable("v_inventaire"))
                    {
                        using (cmd = new SqlCommand("select * from v_inventaire order by " + cb.Text + " ", con)) ;
                        {
                            con.Open();
                            // cmd.Parameters.AddWithValue("@cb", cb.Text);
                            dt = new SqlDataAdapter(cmd);
                            dt.Fill(dta);
                            con.Close();
                            d.DataSource = dta;
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void Trie(DataGridView d, Control cb)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable("v_article"))
                    {
                        using (cmd = new SqlCommand("select * from v_article order by " + cb.Text + " ", con)) ;
                        {
                            con.Open();
                            // cmd.Parameters.AddWithValue("@cb", cb.Text);
                            dt = new SqlDataAdapter(cmd);
                            dt.Fill(dta);
                            con.Close();
                            d.DataSource = dta;
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void Triedate(DataGridView d, DateTimePicker dat)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable("v_article"))
                    {
                        using (cmd = new SqlCommand("select * from v_inventaireok where datecloture ='" + DateTime.Parse(dat.Text) + "' ", con)) ;
                        {
                            con.Open();
                            // cmd.Parameters.AddWithValue("@cb", cb.Text);
                            dt = new SqlDataAdapter(cmd);
                            dt.Fill(dta);
                            con.Close();
                            d.DataSource = dta;
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void Filtre(DataGridView d, Control cb, Control val)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable("v_article"))
                    {
                        using (cmd = new SqlCommand("select * from v_article where " + cb.Text + " like '%" + val.Text + "%'", con)) ;
                        {
                            con.Open();
                            // cmd.Parameters.AddWithValue("@cb", cb.Text);
                            dt = new SqlDataAdapter(cmd);
                            dt.Fill(dta);
                            con.Close();
                            d.DataSource = dta;
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }

        public void compter2(Control nbr, string table, string col2, DateTime dat1, DateTime dat2)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable(table))
                    {
                        using (cmd = new SqlCommand("select count(*) as cmp from " + table + " where " + col2 + " between  @d1 and @d2", con)) ;
                        {
                            con.Open();
                            setParameter(cmd, "@d1", DbType.DateTime, 30, dat1);
                            setParameter(cmd, "@d2", DbType.DateTime, 30, dat2);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                string k = dr["cmp"].ToString();
                                nbr.Text = k;
                            }
                            con.Close();
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void montant(Control tot, string table, string col, string col2, DateTime dat1, DateTime dat2, Control nbr)
        {
            try
            {
                innitialiseConnect();
                if (con.State == ConnectionState.Closed)
                    using (DataTable dta = new DataTable(table))
                    {
                        using (cmd = new SqlCommand("select isnull(sum(" + col + "),0) as tot from " + table + " where " + col2 + " between @da1 and @da2", con)) ;
                        {
                            con.Open();
                            setParameter(cmd, "@da1", DbType.DateTime, 30, dat1);
                            setParameter(cmd, "@da2", DbType.DateTime, 30, dat2);
                            //cmd.Parameters.AddWithValue("@da1", dat1);
                            //cmd.Parameters.AddWithValue("@da2", dat2);
                            // dt = new SqlDataAdapter(cmd);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                string k = dr["tot"].ToString() + " $";
                                tot.Text = k;
                            }
                            compter2(nbr, table, col2, dat1, dat2);
                            con.Close();

                        }
                    }

            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void calcul(string nbr, DataGridView d, DateTimePicker dt1, DateTimePicker dt2)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("select (sum(ptv)* sum(remise))/100 as tot from v_Sortie where Date_sortie  between '" + DateTime.Parse(dt1.Text) + "' and '" + DateTime.Parse(dt2.Text) + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nbr = dr["tot"].ToString();
                }
                //compter(nbr, d);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void backup(String sql)
        {
            MessageBox.Show("La sauvegarde est bien faite");
        }

        private static string backupPath = "";

        public String getBackupPath(TextBox txt)
        {
            if (txt.Text.Equals(""))
            {
                //backupPath = @"C:\BackupPharmacie";
                backupPath = ClsConstantes.Table.CheminBackup;
                try
                {
                    if (Directory.Exists(backupPath))
                    {
                        return backupPath;
                    }
                    DirectoryInfo di = Directory.CreateDirectory(backupPath);
                    backupPath = di.FullName;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                backupPath = txt.Text;
            }
            return backupPath;
        }//Pour le selectionner un Chemin d
        public String getBackupPath()
        {

            //backupPath = @"C:\BackupEcole";
            backupPath = ClsConstantes.Table.CheminBackup;
            try
            {
                if (Directory.Exists(backupPath))
                {
                    return backupPath;
                }
                DirectoryInfo di = Directory.CreateDirectory(backupPath);
                backupPath = di.FullName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return backupPath;
        }//Pour le selectionner un Chemin d

        public DataSet Report(string nomTable)
        {
            DataSet dst;
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
                //   cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public DataSet get_Report_Trier(string nomTable, string nomchamp, DateTimePicker val1, DateTimePicker val2)
        {
            DataSet dst;
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " between @date1 and @date2 ", con);
                cmd.Parameters.AddWithValue("@date1", DateTime.Parse(val1.Text));
                cmd.Parameters.AddWithValue("@date2", DateTime.Parse(val2.Text));
                //setParameter(cmd, "@date1", DbType.DateTime, 30, val1);
                //setParameter(cmd, "@date2", DbType.DateTime, 30, val2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public DataSet get_Report_Trier(string nomTable, string nomchamp, DateTime val1)
        {
            DataSet dst;
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " = @date1", con);
                setParameter(cmd, "@date1", DbType.DateTime, 30, val1);
                //cmd.Parameters.AddWithValue("@date1", val1.Text);
                //cmd.Parameters.AddWithValue("@date1", DateTime.Parse(val1.Text));
                // cmd.Parameters.AddWithValue("@date2", DateTime.Parse(val2.Text));
                //setParameter(cmd, "@date2", DbType.DateTime, 30, val2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public void recus(DataGridView d, Control nbr)
        {
            try
            {
                innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand com = new SqlCommand("select * from v_article where qte <= qtemin ", con);
                DataTable dt = new DataTable();
                SqlDataReader dtr = com.ExecuteReader();
                dt.Load(dtr);
                con.Close();
                d.DataSource = dt;
                // d.ClearSelection();
                compter(nbr, d);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de chargement" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void calcul(Control montant, string col, string table)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("select ISNULL(sum(" + col + "),0) as somme from " + table + " ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    montant.Text = dr["somme"].ToString() + " $";
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void compter(Control montant, string table)
        {
            try
            {
                innitialiseConnect();
                con.Open();
                cmd = new SqlCommand("select count(*) as nbr from " + table + "", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    montant.Text = dr["nbr"].ToString();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
        public void alarm(DataGridView d)
        {

            double qte;
            double qtem;
            for (int i = 0; i < d.RowCount - 1; i++)
            {
                qte = Convert.ToDouble(d.Rows[i].Cells[7].Value);
                qtem = Convert.ToDouble(d.Rows[i].Cells[8].Value);
                if (qte <= qtem)
                {

                    // d.Columns[8].SortMode = DataGridViewColumnSortMode.Automatic;
                    d.Rows[i].Cells[8].Style.BackColor = Color.OrangeRed;
                    // d.Rows[i].Cells[8].Style.ForeColor = Color.White;

                }
            }
        }
        public void iventalarm(DataGridView d)
        {

            double qte = Convert.ToDouble(d.Rows[i].Cells[6].Value);
            double qter = Convert.ToDouble(d.Rows[i].Cells[7].Value);
            for (int i = 0; i < d.RowCount - 1; i++)
            {
                // qter = 0;
                if (qter > qte)
                {
                    d.Rows[i].Cells[8].Style.BackColor = Color.DarkRed;
                    d.Rows[i].Cells[8].Style.ForeColor = Color.White;
                    break;
                }
                else if (qter < qte)
                {
                    d.Rows[i].Cells[8].Style.BackColor = Color.DarkGreen;
                    d.Rows[i].Cells[8].Style.ForeColor = Color.White;
                    break;
                }
                else if (Convert.ToString(qter).ToString() == "")
                {

                    break;
                }
            }

        }
        //public void al(DataGridView d)
        //{
        //    double  dif;
        //   // qte = Convert.ToDouble(d.Rows[i].Cells[6].Value);
        //    dif = Convert.ToDouble(d.Rows[i].Cells[8].Value);
        //    for (int i = 0; i < d.RowCount - 1; i++)
        //    {
        //        if (dif > 0)
        //        {


        //        }
        //    }
        //}
    }
}

