namespace Pharmacie.dialogues
{
    partial class AjoutFamille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutFamille));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iddr = new System.Windows.Forms.Label();
            this.iddf = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 83);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.title.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(715, 83);
            this.title.TabIndex = 3;
            this.title.Text = "Ajouter une famille";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.iddr);
            this.panel2.Controls.Add(this.iddf);
            this.panel2.Controls.Add(this.desc);
            this.panel2.Controls.Add(this.nom);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.valider);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 324);
            this.panel2.TabIndex = 1;
            // 
            // iddr
            // 
            this.iddr.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddr.ForeColor = System.Drawing.Color.White;
            this.iddr.Location = new System.Drawing.Point(3, 3);
            this.iddr.Name = "iddr";
            this.iddr.Size = new System.Drawing.Size(43, 27);
            this.iddr.TabIndex = 27;
            this.iddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iddf
            // 
            this.iddf.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddf.ForeColor = System.Drawing.Color.White;
            this.iddf.Location = new System.Drawing.Point(52, 3);
            this.iddf.Name = "iddf";
            this.iddf.Size = new System.Drawing.Size(57, 27);
            this.iddf.TabIndex = 26;
            this.iddf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.desc.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.desc.Location = new System.Drawing.Point(219, 95);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(405, 44);
            this.desc.TabIndex = 25;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.nom.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nom.Location = new System.Drawing.Point(219, 42);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(405, 44);
            this.nom.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valider
            // 
            this.valider.Activecolor = System.Drawing.Color.Black;
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
            this.valider.Location = new System.Drawing.Point(63, 224);
            this.valider.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.valider.Name = "valider";
            this.valider.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.valider.OnHovercolor = System.Drawing.Color.Silver;
            this.valider.OnHoverTextColor = System.Drawing.Color.White;
            this.valider.selected = false;
            this.valider.Size = new System.Drawing.Size(225, 54);
            this.valider.TabIndex = 14;
            this.valider.Text = "Enregistrer";
            this.valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valider.Textcolor = System.Drawing.Color.White;
            this.valider.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Black;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(376, 224);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(225, 54);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Annuler";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.title;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(718, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutFamille";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton valider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox desc;
        public System.Windows.Forms.TextBox nom;
        public System.Windows.Forms.Label iddf;
        public System.Windows.Forms.Label iddr;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}