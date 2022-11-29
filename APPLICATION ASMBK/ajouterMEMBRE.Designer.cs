namespace APPLICATION_ASMBK
{
    partial class ajouterMEMBRE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouterMEMBRE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fermer = new System.Windows.Forms.Button();
            this.textSECTEUR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tsexe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.matricule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tcontact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tadresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 48);
            this.panel1.TabIndex = 0;
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.Transparent;
            this.fermer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fermer.BackgroundImage")));
            this.fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.fermer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.fermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Location = new System.Drawing.Point(611, 0);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(57, 48);
            this.fermer.TabIndex = 5;
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // textSECTEUR
            // 
            this.textSECTEUR.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSECTEUR.Location = new System.Drawing.Point(288, 237);
            this.textSECTEUR.Multiline = true;
            this.textSECTEUR.Name = "textSECTEUR";
            this.textSECTEUR.Size = new System.Drawing.Size(318, 28);
            this.textSECTEUR.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "SECTEUR";
            // 
            // Tsexe
            // 
            this.Tsexe.FormattingEnabled = true;
            this.Tsexe.Items.AddRange(new object[] {
            "FEMININ",
            "MASCULIN"});
            this.Tsexe.Location = new System.Drawing.Point(288, 307);
            this.Tsexe.Name = "Tsexe";
            this.Tsexe.Size = new System.Drawing.Size(189, 21);
            this.Tsexe.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "SEXE";
            // 
            // matricule
            // 
            this.matricule.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule.Location = new System.Drawing.Point(288, 269);
            this.matricule.Multiline = true;
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(318, 28);
            this.matricule.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "NUMERO MATRICU :";
            // 
            // Tcontact
            // 
            this.Tcontact.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcontact.Location = new System.Drawing.Point(288, 206);
            this.Tcontact.Multiline = true;
            this.Tcontact.Name = "Tcontact";
            this.Tcontact.Size = new System.Drawing.Size(318, 28);
            this.Tcontact.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "NUMERO DE TEL :";
            // 
            // Tadresse
            // 
            this.Tadresse.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tadresse.Location = new System.Drawing.Point(288, 168);
            this.Tadresse.Multiline = true;
            this.Tadresse.Name = "Tadresse";
            this.Tadresse.Size = new System.Drawing.Size(318, 28);
            this.Tadresse.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "ADRESSE MEMBRE :";
            // 
            // Tnom
            // 
            this.Tnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tnom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnom.Location = new System.Drawing.Point(288, 134);
            this.Tnom.Margin = new System.Windows.Forms.Padding(3, 2, 2, 3);
            this.Tnom.Multiline = true;
            this.Tnom.Name = "Tnom";
            this.Tnom.Size = new System.Drawing.Size(318, 28);
            this.Tnom.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "NOM ET POSTNOM : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(507, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 147);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Tid
            // 
            this.Tid.Location = new System.Drawing.Point(584, 56);
            this.Tid.Multiline = true;
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(66, 20);
            this.Tid.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Numero d\'enregistrement";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(436, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 52);
            this.panel2.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(314, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 60);
            this.button1.TabIndex = 42;
            this.button1.Text = "Ajouter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(171, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 60);
            this.button3.TabIndex = 44;
            this.button3.Text = "Modifier";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(32, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 60);
            this.button2.TabIndex = 43;
            this.button2.Text = "Supprimer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ajouterMEMBRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(671, 463);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textSECTEUR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tsexe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tcontact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tadresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ajouterMEMBRE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajouterMEMBRE";
            this.Load += new System.EventHandler(this.ajouterMEMBRE_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.TextBox textSECTEUR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Tsexe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox matricule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tcontact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tadresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}