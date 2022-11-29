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

namespace APPLICATION_ASMBK
{
    public partial class REMBOURSER : UserControl
    {
        public REMBOURSER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //remboursement m1 = new remboursement(int.Parse(refemprunt.Text), float.Parse(textmontant.Text), DateTime.Parse(date.Value.ToString()));
            remboursement m1 = new remboursement();
            m1.Id_Emprunt = int.Parse(refemprunt.Text);
            m1.Montant = float.Parse(textmontant.Text);
            m1.Date = DateTime.Parse(txtDate.Value.ToString());
            m1.inser_remboursement(m1);
            connexion d = new connexion();
            d.remplirDGV("SELECT * FROM REMBOURSEMENT", TABLE);
        }

        private void REMBOURSER_Load(object sender, EventArgs e)
        {
          
            //AFFICHER TABLE 1
            connexion con = new connexion();
            con.remplirDGV("select * from REMBOURSEMENT", TABLE);
            //AFFICHER TABLE 2
            connexion c = new connexion();
            c.remplirDGV("select * from CREDIT", TABLE2);

            textnum.Enabled = false;
            //connexion d = new connexion();
            //d.remplirDGV(" SELECT * FROM REMBOURSEMENT ", TABLE);
            //this.textnum.Text = TABLE.CurrentRow.Cells[0].Value.ToString();
            //this.refemprunt.Text = TABLE.CurrentRow.Cells[1].Value.ToString();
            //this.textmontant.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
            //this.date.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
        }

        private void TABLE2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             this.refemprunt.Text = TABLE2.CurrentRow.Cells[0].Value.ToString();
        }

        private void TABLE2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void TABLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void richTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandText = "select *from MEMBRE_REMBOURSEMENT where NOM like '%" + RECHER_MEBRE.Text + "%'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds, "MEMBRE_REMBOURSEMENT");
            TABLE.DataSource = ds.Tables["MEMBRE_REMBOURSEMENT"];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void RECHE_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandText = "select *from AFFICHER_NOM where NOM like '%" + RECHE_ID.Text + "%'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds, "AFFICHER_NOM");
            TABLE2.DataSource = ds.Tables["AFFICHER_NOM"];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void TABLE_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.textnum.Text = TABLE.CurrentRow.Cells[0].Value.ToString();
            this.refemprunt.Text = TABLE.CurrentRow.Cells[1].Value.ToString();
            this.textmontant.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
            this.txtDate.Text = TABLE.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RAPORT_REMBOURSER menu = new RAPORT_REMBOURSER();
            menu.Show();
        }

        private void rapport_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
        }
    }
}
