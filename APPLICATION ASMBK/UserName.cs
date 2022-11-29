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
    public partial class UserName : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public UserName()
        { 
            InitializeComponent();
            con.ConnectionString= string.Format("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
        }
        //public UserName()
        //{
        //    InitializeComponent();
           
        //}

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            //SqlCommand cmd = new SqlCommand("select * from MOT_PASS where userName='" + textuser.Text + "' and code'" + textpass.Text + "'");
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //string cmdItemValue = comboBox1.SelectedItem.ToString();
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i]["userName"].ToString() == cmdItemValue)
            //        {
            //            MessageBox.Show("you are login as " + dt.Rows[i][2]);
            //            if (comboBox1.SelectedIndex == 0)
            //            {
            //                Form1 menu = new Form1();
            //                menu.Show();
            //                this.Hide();
            //            }
            //        }
            //        else 
            //        {
            //            Form2 ff = new Form2();
            //            ff.Show();
            //            this.Hide();
            //        }
            //    }
            //}
            //else 
            //{
            //    MessageBox.Show("error");
            //}

            //con.Open();
            cmd.Connection=con;
            cmd.CommandText="select * from MOT_PASS";
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                if (textuser.Text.Equals(dr["userName"].ToString()) && textpass.Text.Equals(dr["code"].ToString()))
                {
                    Form1 a = new Form1();
                    a.Show();
                    UserName u = new UserName();
                    this.Hide();
                }
                else { MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);}
            }
            //con.Close();

        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminUser a = new adminUser();
            a.Show();
            UserName u = new UserName();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
