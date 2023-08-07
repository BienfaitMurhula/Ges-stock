namespace Pharmacie.dialogues
{
    partial class AjoutIventaire
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
            this.refer = new System.Windows.Forms.TextBox();
            this.des = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.qte = new System.Windows.Forms.TextBox();
            this.famille = new System.Windows.Forms.TextBox();
            this.valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // refer
            // 
            this.refer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.refer.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refer.Location = new System.Drawing.Point(157, 189);
            this.refer.Multiline = true;
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(405, 44);
            this.refer.TabIndex = 65;
            this.refer.TextChanged += new System.EventHandler(this.refer_TextChanged);
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.des.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.des.Location = new System.Drawing.Point(157, 242);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(405, 44);
            this.des.TabIndex = 63;
            this.des.TextChanged += new System.EventHandler(this.des_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-3, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 46);
            this.label8.TabIndex = 62;
            this.label8.Text = "Référence";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 46);
            this.label7.TabIndex = 61;
            this.label7.Text = "Désignation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-5, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 46);
            this.label4.TabIndex = 58;
            this.label4.Text = "Quantité";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 54;
            this.label1.Text = "Famille";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacie.Properties.Resources.LOGO_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(118, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(478, 83);
            this.title.TabIndex = 55;
            this.title.Text = "Entrée la Qte réele";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-13, 99);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(601, 21);
            this.bunifuSeparator1.TabIndex = 56;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // qte
            // 
            this.qte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.qte.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.qte.Location = new System.Drawing.Point(157, 292);
            this.qte.Multiline = true;
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(405, 44);
            this.qte.TabIndex = 69;
            // 
            // famille
            // 
            this.famille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.famille.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famille.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.famille.Location = new System.Drawing.Point(157, 139);
            this.famille.Multiline = true;
            this.famille.Name = "famille";
            this.famille.Size = new System.Drawing.Size(405, 44);
            this.famille.TabIndex = 70;
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
            this.valider.Location = new System.Drawing.Point(14, 386);
            this.valider.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.valider.Name = "valider";
            this.valider.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.valider.OnHovercolor = System.Drawing.Color.Silver;
            this.valider.OnHoverTextColor = System.Drawing.Color.White;
            this.valider.selected = true;
            this.valider.Size = new System.Drawing.Size(225, 54);
            this.valider.TabIndex = 72;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(327, 386);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(225, 54);
            this.bunifuFlatButton1.TabIndex = 71;
            this.bunifuFlatButton1.Text = "Annuler";
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
            this.bunifuFlatButton2.ButtonText = "Produit Suivant";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(66, 483);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(450, 54);
            this.bunifuFlatButton2.TabIndex = 73;
            this.bunifuFlatButton2.Text = "Produit Suivant";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Visible = false;
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.title;
            this.bunifuDragControl1.Vertical = true;
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.Location = new System.Drawing.Point(-3, 125);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(38, 26);
            this.code.TabIndex = 74;
            this.code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.code.Visible = false;
            // 
            // AjoutIventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(598, 579);
            this.Controls.Add(this.code);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.famille);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.refer);
            this.Controls.Add(this.des);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutIventaire";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjoutIventaire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox refer;
        public System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label title;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.TextBox qte;
        public System.Windows.Forms.TextBox famille;
        public Bunifu.Framework.UI.BunifuFlatButton valider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label code;
    }
}