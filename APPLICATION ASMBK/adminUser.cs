using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APPLICATION_ASMBK
{
    public partial class adminUser : Form
    { 
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public adminUser()
        {

        { 
            InitializeComponent();
            con.ConnectionString= string.Format("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UTILISATEUR a = new UTILISATEUR();
            a.Show();
            
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UserName un = new UserName();
            un.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from MOT_PASS";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (textuser.Text.Equals(dr["userName"].ToString()) && textpass.Text.Equals(dr["code"].ToString()))
                {
                    UTILISATEUR a = new UTILISATEUR();
                    a.Show();
                    UserName u = new UserName();
                    this.Hide();
                }
                else { MessageBox.Show("Pas d'acces contacter l'Administrateur ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            con.Close();
            //UTILISATEUR a = new UTILISATEUR();
            //a.Show();
            //this.Hide();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
