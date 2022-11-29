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
    public partial class EMRUNT : UserControl
    {
        public EMRUNT()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EMRUNT_Load(object sender, EventArgs e)
        {
            // afficher table 1
            connexion con = new connexion();
            con.remplirDGV("select * from CREDIT", TABLE);
            //afficher table 2
            connexion c = new connexion();
            c.remplirDGV("select * from MEMBRE", TABLE2);

            //textnum.Enabled = false;
            //connexion d = new connexion();
            //d.remplirDGV(" SELECT * FROM EMPRUNT ", TABLE);
            //this. .Text = TABLE.CurrentRow.Cells[0].Value.ToString();
            //this.REFMEMBRE.Text = TABLE.CurrentRow.Cells[1].Value.ToString();
            //this.textmontant.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
            //this.date.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             emprunt m1 = new emprunt();
            m1.Id_membre = int.Parse(REFMEMBRE.Text);
            m1.Montant = float.Parse(textmontant.Text);
            m1.Date = DateTime.Parse(textDate.Value.ToString());
            m1.inser_imprunt(m1);
            connexion d = new connexion();
            d.remplirDGV("SELECT * FROM CREDIT", TABLE);
        }

        private void TABLE2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.REFMEMBRE.Text = TABLE2.CurrentRow.Cells[0].Value.ToString();
        }

        private void TABLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textnum.Text = TABLE.CurrentRow.Cells[0].Value.ToString();
            this.REFMEMBRE.Text = TABLE.CurrentRow.Cells[1].Value.ToString();
            this.textmontant.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
            this.textDate.Text = TABLE.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emprunt m1 = new emprunt(int.Parse(textnum.Text));
            m1.SUPPRIMER(m1);
            connexion d = new connexion();
            d.remplirDGV("select * from CREDIT", TABLE);
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //emprunt m1 = new emprunt(int.Parse(REFMEMBRE.Text), float.Parse(textmontant.Text),DateTime.Parse(textDate.Value.ToString()));
            //m1.MODIFIER(m1);
            //connexion d = new connexion();
            //d.remplirDGV("SELECT * FROM EMPRUNT", TABLE);
            emprunt m1 = new emprunt();
            m1.Numero = int.Parse(textnum.Text);
            m1.Id_membre = int.Parse(REFMEMBRE.Text);
            m1.Montant = float.Parse(textmontant.Text);
            m1.Date = DateTime.Parse(textDate.Text);
            m1.MODIFIER(m1);
            connexion d = new connexion();
            d.remplirDGV("SELECT * FROM CREDIT", TABLE);
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void recherche_Click(object sender, EventArgs e)
        {
          //SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
          //SqlCommand cmd = new SqlCommand(); 
          //SqlDataAdapter da = new SqlDataAdapter();                 
          //DataSet ds = new DataSet();
          //cmd.CommandText = "select *from AFFICHER_MEMBRE where NOM like '%" + recherche.Text + "%'";
          //cmd.Connection =con ;
          //da.SelectCommand = cmd;
          //da.Fill(ds, "AFFICHER_MEMBRE");
          //TABLE2.DataSource = ds.Tables["AFFICHER_MEMBRE"];
          //con.Open();
          //cmd.ExecuteNonQuery();
          //con.Close();


        }

        private void recherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataSet ds = new DataSet();
            //cmd.CommandText = "select *from AFFICHER_MEMBRE where NOM like '%" + CHERCHE.Text + "%'";
            //cmd.Connection = con;
            //da.SelectCommand = cmd;
            //da.Fill(ds, "AFFICHER_MEMBRE");
            //TABLE2.DataSource = ds.Tables["AFFICHER_MEMBRE"];
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandText = "select *from AFFICHER_MEMBRE where NOM like '%" + CHERCHE.Text + "%'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds, "AFFICHER_MEMBRE");
            TABLE2.DataSource = ds.Tables["AFFICHER_MEMBRE"];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void RECHER_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.CommandText = "select *from MEMBRE_EMPRUNT where NOM like '%" + RECHER.Text + "%'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds, "MEMBRE_EMPRUNT");
            TABLE.DataSource = ds.Tables["MEMBRE_EMPRUNT"];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
