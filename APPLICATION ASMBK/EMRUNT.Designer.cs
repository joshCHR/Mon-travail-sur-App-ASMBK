namespace APPLICATION_ASMBK
{
    partial class EMRUNT
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMRUNT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textmontant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TABLE = new System.Windows.Forms.DataGridView();
            this.TABLE2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.REFMEMBRE = new System.Windows.Forms.TextBox();
            this.recherche = new System.Windows.Forms.RichTextBox();
            this.RECHER = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CHERCHE = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(36, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 155);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero d\'emprunt ";
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(724, 55);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(56, 20);
            this.textnum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "MEMBRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "MONTANT EMPRUNTER";
            // 
            // textmontant
            // 
            this.textmontant.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmontant.Location = new System.Drawing.Point(203, 101);
            this.textmontant.Multiline = true;
            this.textmontant.Name = "textmontant";
            this.textmontant.Size = new System.Drawing.Size(237, 31);
            this.textmontant.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATE D\'EMPRUNT";
            // 
            // TABLE
            // 
            this.TABLE.BackgroundColor = System.Drawing.Color.White;
            this.TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE.Location = new System.Drawing.Point(3, 316);
            this.TABLE.Name = "TABLE";
            this.TABLE.Size = new System.Drawing.Size(513, 224);
            this.TABLE.TabIndex = 10;
            this.TABLE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE_CellClick);
            // 
            // TABLE2
            // 
            this.TABLE2.BackgroundColor = System.Drawing.Color.White;
            this.TABLE2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE2.Location = new System.Drawing.Point(532, 161);
            this.TABLE2.Name = "TABLE2";
            this.TABLE2.Size = new System.Drawing.Size(193, 379);
            this.TABLE2.TabIndex = 12;
            this.TABLE2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE2_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(96, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(217, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Supprimer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(363, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 45);
            this.button3.TabIndex = 15;
            this.button3.Text = "Modifier";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // REFMEMBRE
            // 
            this.REFMEMBRE.Location = new System.Drawing.Point(642, 109);
            this.REFMEMBRE.Name = "REFMEMBRE";
            this.REFMEMBRE.Size = new System.Drawing.Size(161, 20);
            this.REFMEMBRE.TabIndex = 16;
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(64, 4);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(137, 21);
            this.recherche.TabIndex = 17;
            this.recherche.Text = "";
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            this.recherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recherche_KeyPress);
            // 
            // RECHER
            // 
            this.RECHER.Location = new System.Drawing.Point(52, 1);
            this.RECHER.Name = "RECHER";
            this.RECHER.Size = new System.Drawing.Size(151, 25);
            this.RECHER.TabIndex = 15;
            this.RECHER.Text = "";
            this.RECHER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RECHER_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.RECHER);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(312, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 25);
            this.panel4.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(34, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 25);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.CHERCHE);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.recherche);
            this.panel3.Location = new System.Drawing.Point(534, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 25);
            this.panel3.TabIndex = 19;
            // 
            // CHERCHE
            // 
            this.CHERCHE.Location = new System.Drawing.Point(53, 0);
            this.CHERCHE.Name = "CHERCHE";
            this.CHERCHE.Size = new System.Drawing.Size(151, 25);
            this.CHERCHE.TabIndex = 15;
            this.CHERCHE.Text = "";
            this.CHERCHE.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.CHERCHE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(34, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 25);
            this.textBox2.TabIndex = 0;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(206, 184);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(200, 20);
            this.textDate.TabIndex = 20;
            this.textDate.Value = new System.DateTime(2022, 8, 15, 0, 0, 0, 0);
            // 
            // EMRUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.REFMEMBRE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TABLE2);
            this.Controls.Add(this.TABLE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textmontant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EMRUNT";
            this.Size = new System.Drawing.Size(813, 543);
            this.Load += new System.EventHandler(this.EMRUNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textmontant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TABLE;
        private System.Windows.Forms.DataGridView TABLE2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox REFMEMBRE;
        private System.Windows.Forms.RichTextBox recherche;
        private System.Windows.Forms.RichTextBox RECHER;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox CHERCHE;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker textDate;
    }
}
