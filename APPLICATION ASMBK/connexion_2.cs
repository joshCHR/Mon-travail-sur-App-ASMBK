using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APPLICATION_ASMBK
{
    class connexion

    {

        // 4 Objets principaux
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public static string Chemin = "Data Source=DESKTOP-28OQJ3K;Initial Catalog=ASMBK;Integrated Security=True";

        #region Connexion
        public int seconnecter()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {

                }
                con.ConnectionString = string.Format(Chemin);
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            return 1;

        }
        #endregion

        #region Deconnexion
        public bool deconnection()
        {
            bool b = false;
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                b = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de fermer la connection", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return b;
        }

        #endregion

        #region Remplir Dgv
        public int remplirDGV(string sqlStatement, DataGridView dgv)
        {
            seconnecter();
            cmd = con.CreateCommand();
            cmd.CommandText = sqlStatement;
            da.SelectCommand = cmd;
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            deconnection();
            return 1;
        }

        #endregion

        #region Remplir CBO
        public void remplirCBO(string sqlStatement, ComboBox cbo, string valueMember, string displayMember)
        {
            //bool b = false;
            //try
            //{
            //    SqlCommand cmd1 = new SqlCommand();
            //    SqlDataAdapter da1 = new SqlDataAdapter();
            //    DataSet ds1 = new DataSet();
            //    seconnecter();
            //    con.CreateCommand();
            //    cmd1.CommandText = sqlStatement;
            //    da1.SelectCommand = cmd1;
            //    da1.Fill(ds);
            //    cbo.ValueMember = valueMember;
            //    cbo.DisplayMember = displayMember;
            //    cbo.DataSource = ds1.Tables[0];
            //    deconnection();
            //    b = true;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //return b;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            seconnecter(); SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = sqlStatement;
            da.SelectCommand = cmd1;
            da.Fill(ds); cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.DataSource = ds.Tables[0];
            deconnection();
        }

        #endregion


    }
}

    
