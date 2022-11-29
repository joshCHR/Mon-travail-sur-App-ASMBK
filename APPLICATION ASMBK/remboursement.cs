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
    class remboursement
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int id_Emprunt;

        public int Id_Emprunt
        {
            get { return id_Emprunt; }
            set { id_Emprunt = value; }
        }
        private float montant;

        public float Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        SqlCommand cmd = null;
        SqlConnection con = new SqlConnection(connexion.Chemin);
        // Constructeur d'initialisation
        public remboursement()
        {
        }
        // Constructeur d'insertion ou modification
        public remboursement(int numero, int id_Emprunt, float montant, DateTime date)
        {
            this.Numero = numero;
            this.Id_Emprunt = id_Emprunt;
            this.Montant = montant;
            this.Date = date;
        }
        public remboursement(int id_Emprunt, float montant, DateTime date)
        {
            this.Id_Emprunt = id_Emprunt;
            this.Montant = montant;
            this.Date = date;
        }
        // Constructeur de suppression
        public remboursement(int numero)
        {
            this.Numero = numero;
        }
        public void inser_remboursement(remboursement M)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("EXEC InsertREMBOURSEMENT @id_Emprunt,@MONTANT,@DATE_REMBOURSEMENT", con);
                cmd.Parameters.AddWithValue("@id_Emprunt", M.Id_Emprunt);
                cmd.Parameters.AddWithValue("@MONTANT", M.Montant);
                cmd.Parameters.AddWithValue("@DATE_REMBOURSEMENT", M.Date);                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ajout effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //La methode update
        public void MODIFIER(remboursement M)
        {
            try
            {
                connexion C = new connexion();
                C.seconnecter();
                C.cmd = C.con.CreateCommand();
                //C.cmd.CommandText = "EXEC UpdateMEMBRE '" + M.MATRICULE + "','" + M.nom + "','" + M.adresse + "','" + M.contact + "','" + M.sexe + "' where id= '" + M.MATRICULE + " '";
                C.cmd.CommandText = string.Format(@"UPDATE EMPRUNT SET id_Emprunt='{0}',MONTANT='{1}',DATE_REMBOURSEMENT='{2}'WHERE NUMERO='{3}'", M.id_Emprunt , M.montant , M.date , M.numero );
                C.cmd.ExecuteNonQuery();
                C.deconnection();
                MessageBox.Show("La mise à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //La méthode de suppression
        public void SUPPRIMER(remboursement M)
        {
            try
            {
                connexion c = new connexion();
                c.seconnecter();
                c.cmd = c.con.CreateCommand();
                c.cmd.CommandText = string.Format(@"DELETE FROM REMBOURSEMENT WHERE NUMERO='{0}'", M.id_Emprunt);
                c.cmd.ExecuteNonQuery();
                c.deconnection();
                MessageBox.Show("Suppression réussi avec succès");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}

