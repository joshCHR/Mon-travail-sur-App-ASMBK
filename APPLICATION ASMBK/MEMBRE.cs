using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;





namespace APPLICATION_ASMBK
{
    public partial class MEMBRE : UserControl
    {
        public MEMBRE()
        {
            InitializeComponent();
        }

        private void MEMBRE_Load(object sender, EventArgs e)
        {
            connexion con = new connexion();
            con.remplirDGV("select * from MEMBRE", table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Tid.Text = table.CurrentRow.Cells[0].Value.ToString();
            //this.matricule.Text = table.CurrentRow.Cells[1].Value.ToString();
            //this.Tnom.Text = table.CurrentRow.Cells[2].Value.ToString();
            //this.Tadresse.Text = table.CurrentRow.Cells[3].Value.ToString();
            //this.Tcontact.Text = table.CurrentRow.Cells[4].Value.ToString();
            //this.Tsexe.Text = table.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var resultat = MessageBox.Show("Voulez vous vraimemnt Supprimer cette information?", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultat == DialogResult.OK)
            {
               
            }
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void REC_MEMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandText = "select *from MEMBRE where NOM like '%" + REC_MEMBRE.Text + "%'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds, "MEMBRE");
            table.DataSource = ds.Tables["MEMBRE"];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
      
     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter="JPEG|*.jpg";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    var fileinfo = new FileInfo(dialog.FileName);
            //    Image image = new Image.FromFile(dialog.FileName);
            //    pictureBox1.Image = image;
            //    url = fileinfo.Name;
            //    labelphoto.Text = url;
            //    file.Copy(fileinfo.FullName,Application.StartupPath+"//"+labelphoto.Text);
            //    labelphoto.Visible = false;
            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ajouterMEMBRE a = new ajouterMEMBRE();
            a.Show();
           
        }
    }
}
