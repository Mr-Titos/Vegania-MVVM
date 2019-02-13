namespace DevellopementCursor
{
    partial class AjoutPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutPart));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxreduc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.duplicata = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxniv = new System.Windows.Forms.TextBox();
            this.searchboxpart = new System.Windows.Forms.TextBox();
            this.searchpart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchpart)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Reduction";
            // 
            // boxreduc
            // 
            this.boxreduc.Location = new System.Drawing.Point(523, 80);
            this.boxreduc.Name = "boxreduc";
            this.boxreduc.Size = new System.Drawing.Size(100, 22);
            this.boxreduc.TabIndex = 4;
            this.boxreduc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxreduc_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // duplicata
            // 
            this.duplicata.AutoSize = true;
            this.duplicata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.duplicata.ForeColor = System.Drawing.Color.Red;
            this.duplicata.Location = new System.Drawing.Point(253, 137);
            this.duplicata.Name = "duplicata";
            this.duplicata.Size = new System.Drawing.Size(212, 18);
            this.duplicata.TabIndex = 31;
            this.duplicata.Text = "Certains champs sont invalide !";
            this.duplicata.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(250, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ajouter un partenaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Niveau";
            // 
            // boxniv
            // 
            this.boxniv.Location = new System.Drawing.Point(324, 80);
            this.boxniv.Name = "boxniv";
            this.boxniv.Size = new System.Drawing.Size(100, 22);
            this.boxniv.TabIndex = 3;
            this.boxniv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxniv_KeyDown);
            // 
            // searchboxpart
            // 
            this.searchboxpart.Location = new System.Drawing.Point(103, 75);
            this.searchboxpart.Name = "searchboxpart";
            this.searchboxpart.Size = new System.Drawing.Size(85, 22);
            this.searchboxpart.TabIndex = 1;
            this.searchboxpart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchpart
            // 
            this.searchpart.Image = ((System.Drawing.Image)(resources.GetObject("searchpart.Image")));
            this.searchpart.Location = new System.Drawing.Point(194, 74);
            this.searchpart.Name = "searchpart";
            this.searchpart.Size = new System.Drawing.Size(25, 24);
            this.searchpart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchpart.TabIndex = 42;
            this.searchpart.TabStop = false;
            // 
            // AjoutPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 227);
            this.Controls.Add(this.searchpart);
            this.Controls.Add(this.searchboxpart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxreduc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.duplicata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxniv);
            this.Name = "AjoutPart";
            this.Text = "AjoutPart";
            ((System.ComponentModel.ISupportInitialize)(this.searchpart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxreduc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label duplicata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxniv;
        private System.Windows.Forms.TextBox searchboxpart;
        private System.Windows.Forms.PictureBox searchpart;
    }
}