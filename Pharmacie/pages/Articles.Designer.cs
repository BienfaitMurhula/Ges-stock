namespace Pharmacie.pages
{
    partial class Articles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nbr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.val = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flt = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtrie = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ajout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nbr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 837);
            this.panel1.TabIndex = 0;
            // 
            // nbr
            // 
            this.nbr.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr.ForeColor = System.Drawing.Color.White;
            this.nbr.Location = new System.Drawing.Point(750, 776);
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(100, 42);
            this.nbr.TabIndex = 8;
            this.nbr.Text = "000";
            this.nbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(608, 776);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 42);
            this.label7.TabIndex = 7;
            this.label7.Text = "NB. Articles : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 659);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.val);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.flt);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(420, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtre";
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(558, 28);
            this.val.Multiline = true;
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(175, 47);
            this.val.TabIndex = 3;
            this.val.TextChanged += new System.EventHandler(this.val_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valeur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choix de champ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flt
            // 
            this.flt.FormattingEnabled = true;
            this.flt.Items.AddRange(new object[] {
            "Nom_famille",
            "Reference",
            "Designation",
            "Nom_Fournisseur",
            "Nom_rangement",
            "qte",
            "prix"});
            this.flt.Location = new System.Drawing.Point(179, 28);
            this.flt.Name = "flt";
            this.flt.Size = new System.Drawing.Size(270, 39);
            this.flt.TabIndex = 1;
            this.flt.SelectedIndexChanged += new System.EventHandler(this.flt_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbtrie);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trie";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trier par";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbtrie
            // 
            this.cmbtrie.FormattingEnabled = true;
            this.cmbtrie.Items.AddRange(new object[] {
            "Nom_famille",
            "Reference",
            "Designation",
            "prix",
            "qte"});
            this.cmbtrie.Location = new System.Drawing.Point(112, 28);
            this.cmbtrie.Name = "cmbtrie";
            this.cmbtrie.Size = new System.Drawing.Size(251, 39);
            this.cmbtrie.TabIndex = 1;
            this.cmbtrie.SelectedIndexChanged += new System.EventHandler(this.cmbtrie_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bunifuFlatButton5);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.ajout);
            this.panel2.Controls.Add(this.mod);
            this.panel2.Controls.Add(this.supp);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 837);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "Rafraichir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(6, 89);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(192, 47);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Rafraichir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "ok";
            this.label5.Visible = false;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton5.ButtonText = "Imprimer";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(5, 715);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(192, 47);
            this.bunifuFlatButton5.TabIndex = 10;
            this.bunifuFlatButton5.Text = "Imprimer";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuFlatButton3);
            this.groupBox3.Controls.Add(this.bunifuFlatButton8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(-2, 463);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrées-Sorties";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton3.ButtonText = "Entrées";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(7, 43);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 66);
            this.bunifuFlatButton3.TabIndex = 5;
            this.bunifuFlatButton3.Text = "Entrées";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton8.ButtonText = "Sortie";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(8, 125);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(189, 59);
            this.bunifuFlatButton8.TabIndex = 10;
            this.bunifuFlatButton8.Text = "Sortie";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // ajout
            // 
            this.ajout.Activecolor = System.Drawing.Color.Transparent;
            this.ajout.BackColor = System.Drawing.Color.Transparent;
            this.ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajout.BorderRadius = 0;
            this.ajout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ajout.ButtonText = "Ajouter";
            this.ajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajout.DisabledColor = System.Drawing.Color.Gray;
            this.ajout.ForeColor = System.Drawing.Color.White;
            this.ajout.Iconcolor = System.Drawing.Color.Transparent;
            this.ajout.Iconimage = null;
            this.ajout.Iconimage_right = null;
            this.ajout.Iconimage_right_Selected = null;
            this.ajout.Iconimage_Selected = null;
            this.ajout.IconMarginLeft = 0;
            this.ajout.IconMarginRight = 0;
            this.ajout.IconRightVisible = true;
            this.ajout.IconRightZoom = 0D;
            this.ajout.IconVisible = true;
            this.ajout.IconZoom = 90D;
            this.ajout.IsTab = false;
            this.ajout.Location = new System.Drawing.Point(6, 209);
            this.ajout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ajout.Name = "ajout";
            this.ajout.Normalcolor = System.Drawing.Color.Transparent;
            this.ajout.OnHovercolor = System.Drawing.Color.DimGray;
            this.ajout.OnHoverTextColor = System.Drawing.Color.White;
            this.ajout.selected = false;
            this.ajout.Size = new System.Drawing.Size(192, 47);
            this.ajout.TabIndex = 9;
            this.ajout.Text = "Ajouter";
            this.ajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ajout.Textcolor = System.Drawing.Color.White;
            this.ajout.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // mod
            // 
            this.mod.Activecolor = System.Drawing.Color.Transparent;
            this.mod.BackColor = System.Drawing.Color.Transparent;
            this.mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mod.BorderRadius = 0;
            this.mod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mod.ButtonText = "Modifier";
            this.mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mod.DisabledColor = System.Drawing.Color.Gray;
            this.mod.ForeColor = System.Drawing.Color.White;
            this.mod.Iconcolor = System.Drawing.Color.Transparent;
            this.mod.Iconimage = null;
            this.mod.Iconimage_right = null;
            this.mod.Iconimage_right_Selected = null;
            this.mod.Iconimage_Selected = null;
            this.mod.IconMarginLeft = 0;
            this.mod.IconMarginRight = 0;
            this.mod.IconRightVisible = true;
            this.mod.IconRightZoom = 0D;
            this.mod.IconVisible = true;
            this.mod.IconZoom = 90D;
            this.mod.IsTab = false;
            this.mod.Location = new System.Drawing.Point(6, 268);
            this.mod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mod.Name = "mod";
            this.mod.Normalcolor = System.Drawing.Color.Transparent;
            this.mod.OnHovercolor = System.Drawing.Color.DimGray;
            this.mod.OnHoverTextColor = System.Drawing.Color.White;
            this.mod.selected = false;
            this.mod.Size = new System.Drawing.Size(192, 47);
            this.mod.TabIndex = 8;
            this.mod.Text = "Modifier";
            this.mod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mod.Textcolor = System.Drawing.Color.White;
            this.mod.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // supp
            // 
            this.supp.Activecolor = System.Drawing.Color.Transparent;
            this.supp.BackColor = System.Drawing.Color.Transparent;
            this.supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supp.BorderRadius = 0;
            this.supp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supp.ButtonText = "supprimer";
            this.supp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supp.DisabledColor = System.Drawing.Color.Gray;
            this.supp.ForeColor = System.Drawing.Color.White;
            this.supp.Iconcolor = System.Drawing.Color.Transparent;
            this.supp.Iconimage = null;
            this.supp.Iconimage_right = null;
            this.supp.Iconimage_right_Selected = null;
            this.supp.Iconimage_Selected = null;
            this.supp.IconMarginLeft = 0;
            this.supp.IconMarginRight = 0;
            this.supp.IconRightVisible = true;
            this.supp.IconRightZoom = 0D;
            this.supp.IconVisible = true;
            this.supp.IconZoom = 90D;
            this.supp.IsTab = false;
            this.supp.Location = new System.Drawing.Point(6, 327);
            this.supp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supp.Name = "supp";
            this.supp.Normalcolor = System.Drawing.Color.Transparent;
            this.supp.OnHovercolor = System.Drawing.Color.DimGray;
            this.supp.OnHoverTextColor = System.Drawing.Color.White;
            this.supp.selected = false;
            this.supp.Size = new System.Drawing.Size(192, 47);
            this.supp.TabIndex = 7;
            this.supp.Text = "supprimer";
            this.supp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supp.Textcolor = System.Drawing.Color.White;
            this.supp.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton4.ButtonText = "Alarme";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(6, 146);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(192, 47);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Text = "Alarme";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Articles";
            this.Size = new System.Drawing.Size(1479, 837);
            this.Load += new System.EventHandler(this.Articles_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtrie;
        private System.Windows.Forms.Label nbr;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        public Bunifu.Framework.UI.BunifuFlatButton supp;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public Bunifu.Framework.UI.BunifuFlatButton mod;
        public Bunifu.Framework.UI.BunifuFlatButton ajout;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.Label label5;
    }
}
