namespace Pharmacie.dialogues
{
    partial class AjoutArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idd = new System.Windows.Forms.Label();
            this.datep = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.qtm = new System.Windows.Forms.MaskedTextBox();
            this.qt = new System.Windows.Forms.MaskedTextBox();
            this.fss = new System.Windows.Forms.ComboBox();
            this.famille = new System.Windows.Forms.ComboBox();
            this.rang = new System.Windows.Forms.ComboBox();
            this.refer = new System.Windows.Forms.TextBox();
            this.pu = new System.Windows.Forms.TextBox();
            this.des = new System.Windows.Forms.TextBox();
            this.valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(129, -5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(559, 132);
            this.title.TabIndex = 2;
            this.title.Text = "Créer un nouvel Article";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 132);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacie.Properties.Resources.LOGO_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.idd);
            this.panel2.Controls.Add(this.datep);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.qtm);
            this.panel2.Controls.Add(this.qt);
            this.panel2.Controls.Add(this.fss);
            this.panel2.Controls.Add(this.famille);
            this.panel2.Controls.Add(this.rang);
            this.panel2.Controls.Add(this.refer);
            this.panel2.Controls.Add(this.pu);
            this.panel2.Controls.Add(this.des);
            this.panel2.Controls.Add(this.valider);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 647);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // idd
            // 
            this.idd.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idd.ForeColor = System.Drawing.Color.White;
            this.idd.Location = new System.Drawing.Point(12, 15);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(92, 26);
            this.idd.TabIndex = 58;
            this.idd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idd.Visible = false;
            // 
            // datep
            // 
            this.datep.CalendarFont = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datep.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.datep.Location = new System.Drawing.Point(188, 289);
            this.datep.Name = "datep";
            this.datep.Size = new System.Drawing.Size(405, 39);
            this.datep.TabIndex = 57;
            this.datep.ValueChanged += new System.EventHandler(this.datep_ValueChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 46);
            this.label9.TabIndex = 56;
            this.label9.Text = "Date peremption";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qtm
            // 
            this.qtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.qtm.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.qtm.Location = new System.Drawing.Point(188, 436);
            this.qtm.Name = "qtm";
            this.qtm.Size = new System.Drawing.Size(405, 43);
            this.qtm.TabIndex = 55;
            // 
            // qt
            // 
            this.qt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.qt.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.qt.Location = new System.Drawing.Point(188, 387);
            this.qt.Name = "qt";
            this.qt.Size = new System.Drawing.Size(405, 43);
            this.qt.TabIndex = 54;
            // 
            // fss
            // 
            this.fss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.fss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fss.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fss.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fss.FormattingEnabled = true;
            this.fss.Location = new System.Drawing.Point(188, 197);
            this.fss.Name = "fss";
            this.fss.Size = new System.Drawing.Size(405, 39);
            this.fss.TabIndex = 20;
            this.fss.SelectedIndexChanged += new System.EventHandler(this.fss_SelectedIndexChanged);
            // 
            // famille
            // 
            this.famille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.famille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.famille.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famille.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.famille.FormattingEnabled = true;
            this.famille.Location = new System.Drawing.Point(188, 52);
            this.famille.Name = "famille";
            this.famille.Size = new System.Drawing.Size(405, 39);
            this.famille.TabIndex = 19;
            this.famille.SelectedIndexChanged += new System.EventHandler(this.famille_SelectedIndexChanged);
            // 
            // rang
            // 
            this.rang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.rang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rang.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rang.FormattingEnabled = true;
            this.rang.Location = new System.Drawing.Point(188, 242);
            this.rang.Name = "rang";
            this.rang.Size = new System.Drawing.Size(405, 39);
            this.rang.TabIndex = 18;
            this.rang.SelectedIndexChanged += new System.EventHandler(this.rang_SelectedIndexChanged);
            // 
            // refer
            // 
            this.refer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.refer.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refer.Location = new System.Drawing.Point(188, 97);
            this.refer.Multiline = true;
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(405, 44);
            this.refer.TabIndex = 17;
            this.refer.TextChanged += new System.EventHandler(this.refer_TextChanged);
            // 
            // pu
            // 
            this.pu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pu.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pu.Location = new System.Drawing.Point(188, 337);
            this.pu.Multiline = true;
            this.pu.Name = "pu";
            this.pu.Size = new System.Drawing.Size(405, 44);
            this.pu.TabIndex = 16;
            this.pu.TextChanged += new System.EventHandler(this.pu_TextChanged);
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.des.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.des.Location = new System.Drawing.Point(188, 147);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(405, 44);
            this.des.TabIndex = 13;
            this.des.TextChanged += new System.EventHandler(this.des_TextChanged);
            // 
            // valider
            // 
            this.valider.Activecolor = System.Drawing.Color.Black;
            this.valider.BackColor = System.Drawing.Color.Black;
            this.valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.valider.BorderRadius = 0;
            this.valider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valider.ButtonText = "Enregistrer";
            this.valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider.DisabledColor = System.Drawing.Color.Gray;
            this.valider.Iconcolor = System.Drawing.Color.Transparent;
            this.valider.Iconimage = null;
            this.valider.Iconimage_right = null;
            this.valider.Iconimage_right_Selected = null;
            this.valider.Iconimage_Selected = null;
            this.valider.IconMarginLeft = 0;
            this.valider.IconMarginRight = 0;
            this.valider.IconRightVisible = true;
            this.valider.IconRightZoom = 0D;
            this.valider.IconVisible = true;
            this.valider.IconZoom = 90D;
            this.valider.IsTab = false;
            this.valider.Location = new System.Drawing.Point(37, 505);
            this.valider.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.valider.Name = "valider";
            this.valider.Normalcolor = System.Drawing.Color.Black;
            this.valider.OnHovercolor = System.Drawing.Color.Silver;
            this.valider.OnHoverTextColor = System.Drawing.Color.White;
            this.valider.selected = false;
            this.valider.Size = new System.Drawing.Size(225, 54);
            this.valider.TabIndex = 12;
            this.valider.Text = "Enregistrer";
            this.valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valider.Textcolor = System.Drawing.Color.White;
            this.valider.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "Annuler";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(350, 505);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(225, 54);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "Annuler";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 46);
            this.label8.TabIndex = 10;
            this.label8.Text = "Référence";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "Désignation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantité min.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantité";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix. U.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rangement";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fournisseur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(665, 21);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Famille";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.title;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AjoutArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(691, 779);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutArticle";
            this.Load += new System.EventHandler(this.AjoutArticle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.Label title;
        public Bunifu.Framework.UI.BunifuFlatButton valider;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox refer;
        public System.Windows.Forms.TextBox pu;
        public System.Windows.Forms.TextBox des;
        public System.Windows.Forms.ComboBox fss;
        public System.Windows.Forms.ComboBox famille;
        public System.Windows.Forms.ComboBox rang;
        public System.Windows.Forms.MaskedTextBox qtm;
        public System.Windows.Forms.MaskedTextBox qt;
        public System.Windows.Forms.DateTimePicker datep;
        public System.Windows.Forms.Label idd;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}