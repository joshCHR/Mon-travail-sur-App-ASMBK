using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLICATION_ASMBK
{
    class ETAT
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int id_credit;

        public int Id_credit
        {
            get { return id_credit; }
            set { id_credit = value; }
        }
        private int id_remboursement;

        public int Id_remboursement
        {
            get { return id_remboursement; }
            set { id_remboursement = value; }
        }
        private float credit_global;

        public float Credit_global
        {
            get { return credit_global; }
            set { credit_global = value; }
        }
        private float interet;

        public float Interet
        {
            get { return interet; }
            set { interet = value; }
        }
        private float epargnee;

        public float Epargnee
        {
            get { return epargnee; }
            set { epargnee = value; }
        }
        private float montant;

        public float Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        //CONSTRUICTEUR DE reinitialisationT
        public ETAT()
        {

        }
        //CONSTRUICTEUR DE MODIFICATION ET INSERTION
        public ETAT(int numero, int id_credit, int id_remboursement, float credit_global, float interet, float epargnee, float montant)
        {
            this.Numero = numero;
            this.id_credit = id_credit;
            this.Id_remboursement = id_remboursement;
            this.Credit_global = credit_global;
            this.Interet = interet;
            this.Epargnee = epargnee;
            this.Montant = montant;
            

        }
        public ETAT( int id_credit, int id_remboursement, float credit_global, float interet, float epargnee, float montant)
        {

            this.Id_credit = id_credit;
            this.Id_remboursement = id_remboursement;
            this.Credit_global = credit_global;
            this.Interet = interet;
            this.Epargnee = epargnee;
            this.Montant = montant;
          
        }
        //CONSTRUICTEUR DESUPPRESSION
        public ETAT(int numero)
        {
            this.Numero = numero;
        }

        public void inser_epargne(ETAT M)
        {
            try
            {
                connexion conn = new connexion();
                conn.seconnecter();
                conn.cmd = conn.con.CreateCommand();
                conn.cmd.CommandText = "EXEC InsertETAT '" + M.id_credit + "','" + M.id_remboursement + "','" + M.credit_global + "','" + M.interet + "','" + M.epargnee + "','" + M.montant +  "' ";
                // conn.cmd.CommandText = string.Format(@"INSERT INTO MEMBRE (MATRICULE,NOM,ADRESSE,CONTANCT,SEXE) VALUES('{0}','{1}','{2}','{3}','{4}')" , M.MATRICULE, M.nom, M.adresse, M.contact, M.sexe);
                conn.cmd.ExecuteNonQuery();
                conn.deconnection();
                MessageBox.Show("Ajout effectué avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //La methode update
        public void MODIFIER(ETAT M)
        {
            try
            {
                connexion C = new connexion();
                C.seconnecter();
                C.cmd = C.con.CreateCommand();
                //C.cmd.CommandText = "EXEC UpdateMEMBRE '" + M.MATRICULE + "','" + M.nom + "','" + M.adresse + "','" + M.contact + "','" + M.sexe + "' where id= '" + M.MATRICULE + " '";
                C.cmd.CommandText = string.Format(@"UPDATE ETAT_FINACIER SET id_credit='{0}',id_remboursement='{1}',credit_global='{2}',interet={3}',epargne='{4}',montant='{5}' WHERE NUMERO='{6}'",
                    M.id_credit,
                    M.id_remboursement,
                    M.credit_global,
                    M.interet,
                    M.epargnee,
                    M.montant,
                    M.Numero);
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
        public void SUPPRIMER(ETAT M)
        {
            try
            {
                connexion c = new connexion();
                c.seconnecter();
                c.cmd = c.con.CreateCommand();
                c.cmd.CommandText = string.Format(@"DELETE FROM ETAT_FINACIER WHERE NUMERO='{0}'", M.numero);
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