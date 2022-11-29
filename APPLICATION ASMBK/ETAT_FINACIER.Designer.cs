namespace APPLICATION_ASMBK
{
    partial class ETAT_FINACIER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETAT_FINACIER));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TABLE = new System.Windows.Forms.DataGridView();
            this.TABLE1 = new System.Windows.Forms.DataGridView();
            this.TABLE2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textnum = new System.Windows.Forms.TextBox();
            this.textcredit = new System.Windows.Forms.TextBox();
            this.textmontant = new System.Windows.Forms.TextBox();
            this.textrembourser = new System.Windows.Forms.TextBox();
            this.textinteret = new System.Windows.Forms.TextBox();
            this.textinter = new System.Windows.Forms.TextBox();
            this.textepargne = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 49);
            this.panel1.TabIndex = 0;
            // 
            // TABLE
            // 
            this.TABLE.BackgroundColor = System.Drawing.Color.White;
            this.TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE.Location = new System.Drawing.Point(16, 10);
            this.TABLE.Name = "TABLE";
            this.TABLE.Size = new System.Drawing.Size(757, 184);
            this.TABLE.TabIndex = 1;
            this.TABLE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE_CellClick);
            // 
            // TABLE1
            // 
            this.TABLE1.BackgroundColor = System.Drawing.Color.White;
            this.TABLE1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE1.Location = new System.Drawing.Point(607, 140);
            this.TABLE1.Name = "TABLE1";
            this.TABLE1.Size = new System.Drawing.Size(160, 168);
            this.TABLE1.TabIndex = 2;
            this.TABLE1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE1_CellClick);
            // 
            // TABLE2
            // 
            this.TABLE2.BackgroundColor = System.Drawing.Color.White;
            this.TABLE2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE2.Location = new System.Drawing.Point(413, 143);
            this.TABLE2.Name = "TABLE2";
            this.TABLE2.Size = new System.Drawing.Size(160, 168);
            this.TABLE2.TabIndex = 3;
            this.TABLE2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE2_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interet Global 25.92%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interet 51%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Epargne 49%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Montant a Rembourser 1.35$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero";
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(698, 58);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(100, 20);
            this.textnum.TabIndex = 12;
            // 
            // textcredit
            // 
            this.textcredit.Location = new System.Drawing.Point(414, 123);
            this.textcredit.Name = "textcredit";
            this.textcredit.Size = new System.Drawing.Size(100, 20);
            this.textcredit.TabIndex = 13;
            // 
            // textmontant
            // 
            this.textmontant.Location = new System.Drawing.Point(258, 140);
            this.textmontant.Name = "textmontant";
            this.textmontant.Size = new System.Drawing.Size(100, 20);
            this.textmontant.TabIndex = 14;
            // 
            // textrembourser
            // 
            this.textrembourser.Location = new System.Drawing.Point(607, 123);
            this.textrembourser.Name = "textrembourser";
            this.textrembourser.Size = new System.Drawing.Size(100, 20);
            this.textrembourser.TabIndex = 15;
            // 
            // textinteret
            // 
            this.textinteret.Location = new System.Drawing.Point(258, 166);
            this.textinteret.Name = "textinteret";
            this.textinteret.Size = new System.Drawing.Size(100, 20);
            this.textinteret.TabIndex = 16;
            // 
            // textinter
            // 
            this.textinter.Location = new System.Drawing.Point(258, 195);
            this.textinter.Name = "textinter";
            this.textinter.Size = new System.Drawing.Size(100, 20);
            this.textinter.TabIndex = 17;
            // 
            // textepargne
            // 
            this.textepargne.Location = new System.Drawing.Point(258, 221);
            this.textepargne.Name = "textepargne";
            this.textepargne.Size = new System.Drawing.Size(100, 20);
            this.textepargne.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.TABLE);
            this.panel2.Location = new System.Drawing.Point(25, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 201);
            this.panel2.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Supprimer";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Modifier";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ajouter ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Remboursement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Credit";
            // 
            // ETAT_FINACIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textepargne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textinter);
            this.Controls.Add(this.textinteret);
            this.Controls.Add(this.textrembourser);
            this.Controls.Add(this.textmontant);
            this.Controls.Add(this.textcredit);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TABLE2);
            this.Controls.Add(this.TABLE1);
            this.Controls.Add(this.panel1);
            this.Name = "ETAT_FINACIER";
            this.Size = new System.Drawing.Size(813, 567);
            this.Load += new System.EventHandler(this.ETAT_FINACIER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TABLE;
        private System.Windows.Forms.DataGridView TABLE1;
        private System.Windows.Forms.DataGridView TABLE2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.TextBox textcredit;
        private System.Windows.Forms.TextBox textmontant;
        private System.Windows.Forms.TextBox textrembourser;
        private System.Windows.Forms.TextBox textinteret;
        private System.Windows.Forms.TextBox textinter;
        private System.Windows.Forms.TextBox textepargne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
