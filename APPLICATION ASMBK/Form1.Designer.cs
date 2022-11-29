namespace APPLICATION_ASMBK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.REDUIRE = new System.Windows.Forms.Button();
            this.agrandire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPRUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BIENVENUS = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.REDUIRE);
            this.panel1.Controls.Add(this.agrandire);
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 24);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // REDUIRE
            // 
            this.REDUIRE.BackColor = System.Drawing.Color.White;
            this.REDUIRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REDUIRE.Dock = System.Windows.Forms.DockStyle.Right;
            this.REDUIRE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.REDUIRE.FlatAppearance.BorderSize = 0;
            this.REDUIRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REDUIRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REDUIRE.Image = ((System.Drawing.Image)(resources.GetObject("REDUIRE.Image")));
            this.REDUIRE.Location = new System.Drawing.Point(1268, 0);
            this.REDUIRE.Name = "REDUIRE";
            this.REDUIRE.Size = new System.Drawing.Size(29, 24);
            this.REDUIRE.TabIndex = 4;
            this.REDUIRE.UseVisualStyleBackColor = false;
            this.REDUIRE.Click += new System.EventHandler(this.REDUIRE_Click);
            // 
            // agrandire
            // 
            this.agrandire.BackColor = System.Drawing.Color.Snow;
            this.agrandire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agrandire.BackgroundImage")));
            this.agrandire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agrandire.Dock = System.Windows.Forms.DockStyle.Right;
            this.agrandire.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.agrandire.FlatAppearance.BorderSize = 0;
            this.agrandire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agrandire.Location = new System.Drawing.Point(1297, 0);
            this.agrandire.Name = "agrandire";
            this.agrandire.Size = new System.Drawing.Size(30, 24);
            this.agrandire.TabIndex = 4;
            this.agrandire.UseVisualStyleBackColor = false;
            this.agrandire.Click += new System.EventHandler(this.agrandire_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.White;
            this.fermer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fermer.BackgroundImage")));
            this.fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.fermer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.fermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Location = new System.Drawing.Point(1327, 0);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(39, 24);
            this.fermer.TabIndex = 4;
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 24);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 452);
            this.panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPRUNTToolStripMenuItem,
            this.mEMBREToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            this.rapportToolStripMenuItem.Click += new System.EventHandler(this.rapportToolStripMenuItem_Click);
            // 
            // eMPRUNTToolStripMenuItem
            // 
            this.eMPRUNTToolStripMenuItem.Name = "eMPRUNTToolStripMenuItem";
            this.eMPRUNTToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.eMPRUNTToolStripMenuItem.Text = "EMPRUNT";
            this.eMPRUNTToolStripMenuItem.Click += new System.EventHandler(this.eMPRUNTToolStripMenuItem_Click);
            // 
            // mEMBREToolStripMenuItem
            // 
            this.mEMBREToolStripMenuItem.Name = "mEMBREToolStripMenuItem";
            this.mEMBREToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mEMBREToolStripMenuItem.Text = "MEMBRE";
            this.mEMBREToolStripMenuItem.Click += new System.EventHandler(this.mEMBREToolStripMenuItem_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button8);
            this.panelMenu.Controls.Add(this.button7);
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 672);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(1, 720);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "deconnnecting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "OPERATION";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.Location = new System.Drawing.Point(0, 280);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 70);
            this.button8.TabIndex = 8;
            this.button8.Text = "ETAT_FIN";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(0, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 70);
            this.button7.TabIndex = 7;
            this.button7.Text = "     REMBOURSER";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(0, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 70);
            this.button6.TabIndex = 6;
            this.button6.Text = "     EMPRUNT";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(0, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 70);
            this.button5.TabIndex = 5;
            this.button5.Text = "     MEMBRES";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "     ACCEUIL ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BIENVENUS
            // 
            this.BIENVENUS.Location = new System.Drawing.Point(200, 48);
            this.BIENVENUS.Name = "BIENVENUS";
            this.BIENVENUS.Size = new System.Drawing.Size(1166, 723);
            this.BIENVENUS.TabIndex = 4;
            this.BIENVENUS.Paint += new System.Windows.Forms.PaintEventHandler(this.BIENVENUS_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BIENVENUS);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button agrandire;
        private System.Windows.Forms.Button REDUIRE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel BIENVENUS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPRUNTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBREToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

