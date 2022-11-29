using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace APPLICATION_ASMBK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BIENVENUS.Controls.Clear();
            MEMBRE  app = new MEMBRE ();
            this.BIENVENUS.Controls.Add(app);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BIENVENUS.Controls.Clear();
            EMRUNT app = new EMRUNT();
            this.BIENVENUS.Controls.Add(app);
        }

        private void BIENVENUS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agrandire_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void REDUIRE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BIENVENUS.Controls.Clear();
            REMBOURSER  app = new REMBOURSER();
            this.BIENVENUS.Controls.Add(app);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BIENVENUS.Controls.Clear();
            ETAT_FINACIER app = new ETAT_FINACIER();
            this.BIENVENUS.Controls.Add(app);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eMPRUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BIENVENUS.Controls.Clear();
            RAPPORT1 app = new RAPPORT1();
            this.BIENVENUS.Controls.Add(app);
        }

        private void mEMBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPPORT_MEMBRE menu = new RAPPORT_MEMBRE();
            menu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user23.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParan, int iParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserName un = new UserName();
            un.Show();
            this.Hide();
        }
    }
}
