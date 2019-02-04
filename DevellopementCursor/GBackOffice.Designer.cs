namespace DevellopementCursor
{
    partial class Maquette
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gprod = new System.Windows.Forms.TabPage();
            this.panelCat = new System.Windows.Forms.Panel();
            this.ajcat = new System.Windows.Forms.Button();
            this.supcat = new System.Windows.Forms.Button();
            this.modcat = new System.Windows.Forms.Button();
            this.useless = new System.Windows.Forms.Label();
            this.LibCatLab = new System.Windows.Forms.Label();
            this.LibCatbox = new System.Windows.Forms.TextBox();
            this.NumCatBox = new System.Windows.Forms.TextBox();
            this.NumCatLab = new System.Windows.Forms.Label();
            this.panelProd = new System.Windows.Forms.Panel();
            this.ajprod = new System.Windows.Forms.Button();
            this.supprod = new System.Windows.Forms.Button();
            this.useless2 = new System.Windows.Forms.Label();
            this.modprod = new System.Windows.Forms.Button();
            this.descprod = new System.Windows.Forms.TextBox();
            this.DescriptionProd = new System.Windows.Forms.Label();
            this.libprod = new System.Windows.Forms.TextBox();
            this.idProdBox = new System.Windows.Forms.TextBox();
            this.NumCat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numcatboxprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actuprod = new System.Windows.Forms.Button();
            this.actucat = new System.Windows.Forms.Button();
            this.listcat = new System.Windows.Forms.ListBox();
            this.Gpart = new System.Windows.Forms.TabPage();
            this.Gclient = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabindex = new System.Windows.Forms.TabControl();
            this.labprixprod = new System.Windows.Forms.Label();
            this.prixprod = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Gprod.SuspendLayout();
            this.panelCat.SuspendLayout();
            this.panelProd.SuspendLayout();
            this.Gclient.SuspendLayout();
            this.tabindex.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gprod
            // 
            this.Gprod.Controls.Add(this.panelCat);
            this.Gprod.Controls.Add(this.panelProd);
            this.Gprod.Controls.Add(this.actuprod);
            this.Gprod.Controls.Add(this.actucat);
            this.Gprod.Controls.Add(this.listcat);
            this.Gprod.Location = new System.Drawing.Point(4, 25);
            this.Gprod.Name = "Gprod";
            this.Gprod.Size = new System.Drawing.Size(979, 529);
            this.Gprod.TabIndex = 3;
            this.Gprod.Text = "Gerer Produits";
            this.Gprod.UseVisualStyleBackColor = true;
            // 
            // panelCat
            // 
            this.panelCat.Controls.Add(this.ajcat);
            this.panelCat.Controls.Add(this.supcat);
            this.panelCat.Controls.Add(this.modcat);
            this.panelCat.Controls.Add(this.useless);
            this.panelCat.Controls.Add(this.LibCatLab);
            this.panelCat.Controls.Add(this.LibCatbox);
            this.panelCat.Controls.Add(this.NumCatBox);
            this.panelCat.Controls.Add(this.NumCatLab);
            this.panelCat.Location = new System.Drawing.Point(227, 48);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(735, 169);
            this.panelCat.TabIndex = 18;
            this.panelCat.Visible = false;
            // 
            // ajcat
            // 
            this.ajcat.Location = new System.Drawing.Point(201, 124);
            this.ajcat.Name = "ajcat";
            this.ajcat.Size = new System.Drawing.Size(87, 33);
            this.ajcat.TabIndex = 11;
            this.ajcat.Text = "Ajouter";
            this.ajcat.UseVisualStyleBackColor = true;
            this.ajcat.Click += new System.EventHandler(this.ajcat_Click);
            // 
            // supcat
            // 
            this.supcat.Location = new System.Drawing.Point(108, 124);
            this.supcat.Name = "supcat";
            this.supcat.Size = new System.Drawing.Size(87, 33);
            this.supcat.TabIndex = 10;
            this.supcat.Text = "Supprimer";
            this.supcat.UseVisualStyleBackColor = true;
            this.supcat.Click += new System.EventHandler(this.supcat_Click);
            // 
            // modcat
            // 
            this.modcat.Location = new System.Drawing.Point(12, 124);
            this.modcat.Name = "modcat";
            this.modcat.Size = new System.Drawing.Size(90, 33);
            this.modcat.TabIndex = 9;
            this.modcat.Text = "Modifier";
            this.modcat.UseVisualStyleBackColor = true;
            this.modcat.Click += new System.EventHandler(this.modcat_Click);
            // 
            // useless
            // 
            this.useless.AutoSize = true;
            this.useless.Location = new System.Drawing.Point(591, 22);
            this.useless.Name = "useless";
            this.useless.Size = new System.Drawing.Size(69, 17);
            this.useless.TabIndex = 8;
            this.useless.Text = "Categorie";
            this.useless.Visible = false;
            // 
            // LibCatLab
            // 
            this.LibCatLab.AutoSize = true;
            this.LibCatLab.Location = new System.Drawing.Point(91, 22);
            this.LibCatLab.Name = "LibCatLab";
            this.LibCatLab.Size = new System.Drawing.Size(49, 17);
            this.LibCatLab.TabIndex = 7;
            this.LibCatLab.Text = "Libellé";
            // 
            // LibCatbox
            // 
            this.LibCatbox.Location = new System.Drawing.Point(94, 53);
            this.LibCatbox.Name = "LibCatbox";
            this.LibCatbox.Size = new System.Drawing.Size(124, 22);
            this.LibCatbox.TabIndex = 4;
            // 
            // NumCatBox
            // 
            this.NumCatBox.Location = new System.Drawing.Point(9, 53);
            this.NumCatBox.Name = "NumCatBox";
            this.NumCatBox.ReadOnly = true;
            this.NumCatBox.Size = new System.Drawing.Size(55, 22);
            this.NumCatBox.TabIndex = 5;
            // 
            // NumCatLab
            // 
            this.NumCatLab.AutoSize = true;
            this.NumCatLab.Location = new System.Drawing.Point(9, 22);
            this.NumCatLab.Name = "NumCatLab";
            this.NumCatLab.Size = new System.Drawing.Size(21, 17);
            this.NumCatLab.TabIndex = 6;
            this.NumCatLab.Text = "ID";
            // 
            // panelProd
            // 
            this.panelProd.Controls.Add(this.labprixprod);
            this.panelProd.Controls.Add(this.prixprod);
            this.panelProd.Controls.Add(this.ajprod);
            this.panelProd.Controls.Add(this.supprod);
            this.panelProd.Controls.Add(this.useless2);
            this.panelProd.Controls.Add(this.modprod);
            this.panelProd.Controls.Add(this.descprod);
            this.panelProd.Controls.Add(this.DescriptionProd);
            this.panelProd.Controls.Add(this.libprod);
            this.panelProd.Controls.Add(this.idProdBox);
            this.panelProd.Controls.Add(this.NumCat);
            this.panelProd.Controls.Add(this.label2);
            this.panelProd.Controls.Add(this.numcatboxprod);
            this.panelProd.Controls.Add(this.label1);
            this.panelProd.Location = new System.Drawing.Point(227, 234);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(735, 169);
            this.panelProd.TabIndex = 17;
            this.panelProd.Visible = false;
            // 
            // ajprod
            // 
            this.ajprod.Location = new System.Drawing.Point(201, 133);
            this.ajprod.Name = "ajprod";
            this.ajprod.Size = new System.Drawing.Size(87, 33);
            this.ajprod.TabIndex = 12;
            this.ajprod.Text = "Ajouter";
            this.ajprod.UseVisualStyleBackColor = true;
            this.ajprod.Click += new System.EventHandler(this.ajprod_Click);
            // 
            // supprod
            // 
            this.supprod.Location = new System.Drawing.Point(108, 133);
            this.supprod.Name = "supprod";
            this.supprod.Size = new System.Drawing.Size(87, 33);
            this.supprod.TabIndex = 12;
            this.supprod.Text = "Supprimer";
            this.supprod.UseVisualStyleBackColor = true;
            this.supprod.Click += new System.EventHandler(this.supprod_Click);
            // 
            // useless2
            // 
            this.useless2.AutoSize = true;
            this.useless2.Location = new System.Drawing.Point(591, 34);
            this.useless2.Name = "useless2";
            this.useless2.Size = new System.Drawing.Size(60, 17);
            this.useless2.TabIndex = 9;
            this.useless2.Text = "Produits";
            this.useless2.Visible = false;
            // 
            // modprod
            // 
            this.modprod.Location = new System.Drawing.Point(12, 133);
            this.modprod.Name = "modprod";
            this.modprod.Size = new System.Drawing.Size(90, 33);
            this.modprod.TabIndex = 11;
            this.modprod.Text = "Modifier";
            this.modprod.UseVisualStyleBackColor = true;
            this.modprod.Click += new System.EventHandler(this.modprod_Click);
            // 
            // descprod
            // 
            this.descprod.Location = new System.Drawing.Point(431, 65);
            this.descprod.Multiline = true;
            this.descprod.Name = "descprod";
            this.descprod.Size = new System.Drawing.Size(145, 77);
            this.descprod.TabIndex = 15;
            // 
            // DescriptionProd
            // 
            this.DescriptionProd.AutoSize = true;
            this.DescriptionProd.Location = new System.Drawing.Point(428, 34);
            this.DescriptionProd.Name = "DescriptionProd";
            this.DescriptionProd.Size = new System.Drawing.Size(79, 17);
            this.DescriptionProd.TabIndex = 16;
            this.DescriptionProd.Text = "Description";
            // 
            // libprod
            // 
            this.libprod.Location = new System.Drawing.Point(184, 65);
            this.libprod.Name = "libprod";
            this.libprod.Size = new System.Drawing.Size(124, 22);
            this.libprod.TabIndex = 9;
            // 
            // idProdBox
            // 
            this.idProdBox.Location = new System.Drawing.Point(12, 65);
            this.idProdBox.Name = "idProdBox";
            this.idProdBox.ReadOnly = true;
            this.idProdBox.Size = new System.Drawing.Size(55, 22);
            this.idProdBox.TabIndex = 10;
            // 
            // NumCat
            // 
            this.NumCat.AutoSize = true;
            this.NumCat.Location = new System.Drawing.Point(94, 34);
            this.NumCat.Name = "NumCat";
            this.NumCat.Size = new System.Drawing.Size(58, 17);
            this.NumCat.TabIndex = 14;
            this.NumCat.Text = "NumCat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // numcatboxprod
            // 
            this.numcatboxprod.Location = new System.Drawing.Point(97, 65);
            this.numcatboxprod.Name = "numcatboxprod";
            this.numcatboxprod.Size = new System.Drawing.Size(55, 22);
            this.numcatboxprod.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Libellé";
            // 
            // actuprod
            // 
            this.actuprod.Location = new System.Drawing.Point(37, 455);
            this.actuprod.Name = "actuprod";
            this.actuprod.Size = new System.Drawing.Size(89, 28);
            this.actuprod.TabIndex = 8;
            this.actuprod.Text = "Produits";
            this.actuprod.UseVisualStyleBackColor = true;
            this.actuprod.Click += new System.EventHandler(this.actuprod_Click);
            // 
            // actucat
            // 
            this.actucat.Location = new System.Drawing.Point(132, 455);
            this.actucat.Name = "actucat";
            this.actucat.Size = new System.Drawing.Size(89, 28);
            this.actucat.TabIndex = 3;
            this.actucat.Text = "Categories";
            this.actucat.UseVisualStyleBackColor = true;
            this.actucat.Click += new System.EventHandler(this.button2_Click);
            // 
            // listcat
            // 
            this.listcat.BackColor = System.Drawing.Color.LightGray;
            this.listcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listcat.FormattingEnabled = true;
            this.listcat.HorizontalScrollbar = true;
            this.listcat.ItemHeight = 20;
            this.listcat.Location = new System.Drawing.Point(37, 36);
            this.listcat.Name = "listcat";
            this.listcat.Size = new System.Drawing.Size(184, 384);
            this.listcat.TabIndex = 2;
            this.listcat.SelectedIndexChanged += new System.EventHandler(this.listcat_SelectedIndexChanged);
            // 
            // Gpart
            // 
            this.Gpart.Location = new System.Drawing.Point(4, 25);
            this.Gpart.Name = "Gpart";
            this.Gpart.Padding = new System.Windows.Forms.Padding(3);
            this.Gpart.Size = new System.Drawing.Size(979, 529);
            this.Gpart.TabIndex = 1;
            this.Gpart.Text = "Gerer Partenaire";
            this.Gpart.UseVisualStyleBackColor = true;
            // 
            // Gclient
            // 
            this.Gclient.BackColor = System.Drawing.SystemColors.Window;
            this.Gclient.Controls.Add(this.listBox1);
            this.Gclient.Controls.Add(this.textBox1);
            this.Gclient.Controls.Add(this.button1);
            this.Gclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gclient.Location = new System.Drawing.Point(4, 25);
            this.Gclient.Name = "Gclient";
            this.Gclient.Padding = new System.Windows.Forms.Padding(3);
            this.Gclient.Size = new System.Drawing.Size(979, 529);
            this.Gclient.TabIndex = 0;
            this.Gclient.Text = "Gerer Client";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 24);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(36, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabindex
            // 
            this.tabindex.Controls.Add(this.Gclient);
            this.tabindex.Controls.Add(this.Gpart);
            this.tabindex.Controls.Add(this.Gprod);
            this.tabindex.Location = new System.Drawing.Point(0, -2);
            this.tabindex.Name = "tabindex";
            this.tabindex.SelectedIndex = 0;
            this.tabindex.Size = new System.Drawing.Size(987, 558);
            this.tabindex.TabIndex = 0;
            // 
            // labprixprod
            // 
            this.labprixprod.AutoSize = true;
            this.labprixprod.Location = new System.Drawing.Point(333, 34);
            this.labprixprod.Name = "labprixprod";
            this.labprixprod.Size = new System.Drawing.Size(31, 17);
            this.labprixprod.TabIndex = 18;
            this.labprixprod.Text = "Prix";
            // 
            // prixprod
            // 
            this.prixprod.Location = new System.Drawing.Point(336, 65);
            this.prixprod.Name = "prixprod";
            this.prixprod.Size = new System.Drawing.Size(55, 22);
            this.prixprod.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(36, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 384);
            this.listBox1.TabIndex = 3;
            // 
            // Maquette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 555);
            this.Controls.Add(this.tabindex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Maquette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquette";
            this.Load += new System.EventHandler(this.Maquette_Load);
            this.Gprod.ResumeLayout(false);
            this.panelCat.ResumeLayout(false);
            this.panelCat.PerformLayout();
            this.panelProd.ResumeLayout(false);
            this.panelProd.PerformLayout();
            this.Gclient.ResumeLayout(false);
            this.Gclient.PerformLayout();
            this.tabindex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Gprod;
        private System.Windows.Forms.TabPage Gpart;
        private System.Windows.Forms.TabPage Gclient;
        private System.Windows.Forms.TabControl tabindex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button actucat;
        private System.Windows.Forms.ListBox listcat;
        private System.Windows.Forms.Label LibCatLab;
        private System.Windows.Forms.Label NumCatLab;
        private System.Windows.Forms.TextBox NumCatBox;
        private System.Windows.Forms.TextBox LibCatbox;
        private System.Windows.Forms.Label DescriptionProd;
        private System.Windows.Forms.TextBox descprod;
        private System.Windows.Forms.Label NumCat;
        private System.Windows.Forms.TextBox numcatboxprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idProdBox;
        private System.Windows.Forms.TextBox libprod;
        private System.Windows.Forms.Button actuprod;
        private System.Windows.Forms.Panel panelCat;
        private System.Windows.Forms.Label useless;
        private System.Windows.Forms.Panel panelProd;
        private System.Windows.Forms.Label useless2;
        private System.Windows.Forms.Button supcat;
        private System.Windows.Forms.Button modcat;
        private System.Windows.Forms.Button supprod;
        private System.Windows.Forms.Button modprod;
        private System.Windows.Forms.Button ajcat;
        private System.Windows.Forms.Button ajprod;
        private System.Windows.Forms.Label labprixprod;
        private System.Windows.Forms.TextBox prixprod;
        private System.Windows.Forms.ListBox listBox1;
    }
}

