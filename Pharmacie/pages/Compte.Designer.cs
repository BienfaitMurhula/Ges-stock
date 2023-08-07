namespace Pharmacie.pages
{
    partial class Compte
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.fx = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.conf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbr = new System.Windows.Forms.Label();
            this.det = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pass1 = new System.Windows.Forms.Label();
            this.fx1 = new System.Windows.Forms.Label();
            this.user1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(16, 89);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1361, 15);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1470, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "Créer un utilisateur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fx
            // 
            this.fx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.fx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fx.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fx.FormattingEnabled = true;
            this.fx.Items.AddRange(new object[] {
            "Admin",
            "Pharmacien(e)"});
            this.fx.Location = new System.Drawing.Point(188, 282);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(405, 39);
            this.fx.TabIndex = 25;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pass.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pass.Location = new System.Drawing.Point(188, 193);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(405, 44);
            this.pass.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 46);
            this.label8.TabIndex = 22;
            this.label8.Text = "Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 46);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fonction";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(12, 137);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(176, 46);
            this.user.TabIndex = 20;
            this.user.Text = "Username";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Username.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Username.Location = new System.Drawing.Point(188, 143);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(405, 44);
            this.Username.TabIndex = 23;
            // 
            // valider
            // 
            this.valider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
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
            this.valider.Location = new System.Drawing.Point(48, 373);
            this.valider.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.valider.Name = "valider";
            this.valider.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.valider.OnHovercolor = System.Drawing.Color.Silver;
            this.valider.OnHoverTextColor = System.Drawing.Color.White;
            this.valider.selected = false;
            this.valider.Size = new System.Drawing.Size(186, 54);
            this.valider.TabIndex = 27;
            this.valider.Text = "Enregistrer";
            this.valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valider.Textcolor = System.Drawing.Color.White;
            this.valider.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "Supprimer";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(440, 373);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(184, 54);
            this.bunifuFlatButton1.TabIndex = 26;
            this.bunifuFlatButton1.Text = "Supprimer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton2.ButtonText = "Modifier";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(244, 373);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(186, 54);
            this.bunifuFlatButton2.TabIndex = 28;
            this.bunifuFlatButton2.Text = "Modifier";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // conf
            // 
            this.conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.conf.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.conf.Location = new System.Drawing.Point(188, 237);
            this.conf.Multiline = true;
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(405, 44);
            this.conf.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 46);
            this.label2.TabIndex = 31;
            this.label2.Text = "Confirmer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nbr
            // 
            this.nbr.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr.ForeColor = System.Drawing.Color.White;
            this.nbr.Location = new System.Drawing.Point(10, 572);
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(108, 46);
            this.nbr.TabIndex = 32;
            this.nbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nbr.Visible = false;
            // 
            // det
            // 
            this.det.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.det.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.det.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.det.BorderRadius = 0;
            this.det.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.det.ButtonText = "Détail";
            this.det.Cursor = System.Windows.Forms.Cursors.Hand;
            this.det.DisabledColor = System.Drawing.Color.Gray;
            this.det.Iconcolor = System.Drawing.Color.Transparent;
            this.det.Iconimage = null;
            this.det.Iconimage_right = null;
            this.det.Iconimage_right_Selected = null;
            this.det.Iconimage_Selected = null;
            this.det.IconMarginLeft = 0;
            this.det.IconMarginRight = 0;
            this.det.IconRightVisible = true;
            this.det.IconRightZoom = 0D;
            this.det.IconVisible = true;
            this.det.IconZoom = 90D;
            this.det.IsTab = false;
            this.det.Location = new System.Drawing.Point(440, 453);
            this.det.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.det.Name = "det";
            this.det.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.det.OnHovercolor = System.Drawing.Color.Silver;
            this.det.OnHoverTextColor = System.Drawing.Color.White;
            this.det.selected = false;
            this.det.Size = new System.Drawing.Size(184, 54);
            this.det.TabIndex = 33;
            this.det.Text = "Détail";
            this.det.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.det.Textcolor = System.Drawing.Color.White;
            this.det.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.det.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            this.det.MouseLeave += new System.EventHandler(this.det_MouseLeave);
            // 
            // pass1
            // 
            this.pass1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass1.ForeColor = System.Drawing.Color.White;
            this.pass1.Location = new System.Drawing.Point(58, 517);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(176, 46);
            this.pass1.TabIndex = 36;
            this.pass1.Text = "Password";
            this.pass1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fx1
            // 
            this.fx1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fx1.ForeColor = System.Drawing.Color.White;
            this.fx1.Location = new System.Drawing.Point(58, 563);
            this.fx1.Name = "fx1";
            this.fx1.Size = new System.Drawing.Size(176, 55);
            this.fx1.TabIndex = 35;
            this.fx1.Text = "Fonction";
            this.fx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user1
            // 
            this.user1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1.ForeColor = System.Drawing.Color.White;
            this.user1.Location = new System.Drawing.Point(58, 468);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(176, 46);
            this.user1.TabIndex = 34;
            this.user1.Text = "Username";
            this.user1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(661, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(797, 506);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.fx1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.det);
            this.Controls.Add(this.nbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.fx);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.user);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Name = "Compte";
            this.Size = new System.Drawing.Size(1473, 618);
            this.Load += new System.EventHandler(this.Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox fx;
        public System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label user;
        public System.Windows.Forms.TextBox Username;
        public Bunifu.Framework.UI.BunifuFlatButton valider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public System.Windows.Forms.TextBox conf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nbr;
        private Bunifu.Framework.UI.BunifuFlatButton det;
        private System.Windows.Forms.Label pass1;
        private System.Windows.Forms.Label fx1;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
