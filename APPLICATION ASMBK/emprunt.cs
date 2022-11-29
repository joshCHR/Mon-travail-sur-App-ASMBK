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
    class emprunt
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int id_membre;

        public int Id_membre
        {
            get { return id_membre; }
            set { id_membre = value; }
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
        // constructeur 
        SqlConnection con = new SqlConnection(connexion.Chemin);
        SqlCommand cmd = null;
        public emprunt()
        {
        }
        public emprunt(int numero, int id_membre, float montant, DateTime date) 
        {
            this.Numero = numero;
            this.Id_membre = id_membre;
            this.Montant = montant;
            this.Date = date;
        }
        public emprunt(int numero, float montant, DateTime date)
        {
            this.Numero = numero;
            this.Montant = montant;
            this.Date = date;
        }
        public emprunt(int id_membre)
        {
            this.Id_membre = id_membre;
        }
        // METHODE D'INSERTION 
        public void inser_imprunt(emprunt M)
        {
            try
            {
                //connexion conn = new connexion();
                //conn.seconnecter();
                //conn.cmd = conn.con.CreateCommand();
                ////conn.cmd.CommandText = "EXEC InsertEMPRUNT '" + M.id_membre  + "','" + M.montant  + "','" + M.Date + "' ";
                //conn.cmd.CommandText = string.Format(@"INSERT INTO EMPRUNT (id_MEMBRE,MONTANT,DATE_EMPRUNT,) VALUES('{0}','{1}','{2}", M.id_membre,M.montant,M.Date );
                //conn.cmd.ExecuteNonQuery();
                //conn.deconnection();

                con.Open();
                cmd = new SqlCommand("EXEC InsertEMPRUNT @id_MEMBRE,@MONTANT,@DATE_CREDIT", con);
                cmd.Parameters.AddWithValue("@id_MEMBRE", M.Id_membre);
                cmd.Parameters.AddWithValue("@MONTANT", M.Montant);
                cmd.Parameters.AddWithValue("@DATE_CREDIT", M.Date);
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
        public void MODIFIER(emprunt M)
        {
            try
            {
                //connexion C = new connexion();
                //C.seconnecter();
                //C.cmd = C.con.CreateCommand();
                ////C.cmd.CommandText = "EXEC UpdateMEMBRE '" + M.MATRICULE + "','" + M.nom + "','" + M.adresse + "','" + M.contact + "','" + M.sexe + "' where id= '" + M.MATRICULE + " '";
                //C.cmd.CommandText = string.Format(@"UPDATE CREDIT SET id_MEMBRE='{0}',MONTANT='{1}',DATE_CREDIT='{2}'WHERE NUMERO='{3}'", M.id_membre, M.montant, M.date, M.numero);
                //C.cmd.ExecuteNonQuery();
                //C.deconnection();
                //MessageBox.Show("La mise à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connexion C = new connexion();
                C.seconnecter();
                C.cmd = C.con.CreateCommand();
                //C.cmd.CommandText = "EXEC UpdateMEMBRE '" + M.MATRICULE + "','" + M.nom + "','" + M.adresse + "','" + M.contact + "','" + M.sexe + "' where id= '" + M.MATRICULE + " '";
                C.cmd.CommandText = string.Format(@"UPDATE CREDIT SET id_MEMBRE='{0}',MONTANT='{1}',DATE_CREDIT='{2}' WHERE NUMERO='{3}'", M.id_membre, M.montant, M.Date, M.Numero);
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
        public void SUPPRIMER(emprunt M)
        {
            try
            {
                connexion c = new connexion();
                c.seconnecter();
                c.cmd = c.con.CreateCommand();
                c.cmd.CommandText = string.Format(@"DELETE FROM CREDIT WHERE NUMERO='{0}'", M.numero);
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


