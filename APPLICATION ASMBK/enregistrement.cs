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
    class enregistrement
    {
        private int ID;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }   
        private string MATRICULE;

        public string MATRICULE1
        {
            get { return MATRICULE; }
            set { MATRICULE = value; }
        }
        private string nom;

        public string Nom1
        {
            get { return nom; }
            set { nom = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string secteur;

        public string Secteur
        {
            get { return secteur; }
            set { secteur = value; }
        } 
    
        private string sexe;

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
      
        //construicteur por le modification
        public enregistrement()
        {
        }
        public enregistrement(int ID, string MATRICULE, string nom, string adresse, string contact, string secteur, string sexe)
        {
            this.ID1 = ID;
            this.MATRICULE1 = MATRICULE;
            this.Nom1 = nom;
            this.Adresse = adresse;
            this.Contact = contact;
            this.Secteur = secteur;
            this.Sexe = sexe;
        }
        public enregistrement( string MATRICULE, string nom, string adresse, string contact, string secteur,string sexe)
        {
            this.ID1 = ID;
            this.MATRICULE1 = MATRICULE;
            this.Nom1 = nom;
            this.Adresse = adresse;
            this.Contact = contact; 
            this.Secteur = secteur;
            this.Sexe = sexe;
        }
        // construicteur suppression
        public enregistrement(int ID)
        {
            this.ID1 = ID;
        }
        // METHODE D'INSERTION
        public void inser_MEMBRE(enregistrement M)
        {
            try
            {
                connexion conn = new connexion();
                conn.seconnecter();
                conn.cmd = conn.con.CreateCommand();
                conn.cmd.CommandText = "EXEC InsertMembre '" + M.MATRICULE + "','" + M.nom + "','" + M.adresse + "','" + M.contact + "','" + M.secteur +"','" + M.sexe + "' ";
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
        public void MODIFIER(enregistrement M)
        {
            try
            {
                connexion C = new connexion();
                C.seconnecter();
                C.cmd = C.con.CreateCommand();
                //C.cmd.CommandText = "EXEC UpdateMEMBRE '" + M.MATRICULE + "','" + M.nom + "','" + M.adresse + "','" + M.contact + "','" + M.sexe + "' where id= '" + M.MATRICULE + " '";
                C.cmd.CommandText = string.Format(@"UPDATE MEMBRE SET MATRICULE='{0}',NOM='{1}',ADRESSE='{2}',CONTANCT='{3}',SECTEUR_ACTIVITE='{4}',SEXE='{5}' WHERE id='{6}'", M.MATRICULE, M.nom, M.adresse, M.contact,M.secteur, M.sexe, M.ID);
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
        public void SUPPRIMER(enregistrement M)
                 {
                     try
                     {
                          connexion c = new connexion(); 
                         c.seconnecter(); 
                         c.cmd = c.con.CreateCommand();
                         c.cmd.CommandText = string.Format(@"DELETE FROM MEMBRE WHERE id='{0}'", M.ID);
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
