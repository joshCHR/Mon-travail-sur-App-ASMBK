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
    public partial class ETAT_FINACIER : UserControl
    {
        public ETAT_FINACIER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ETAT m1 = new ETAT(int.Parse(textcredit.Text), int.Parse(textrembourser.Text), float.Parse(textinteret.Text.ToString()), float.Parse(textinter.Text.ToString()), float.Parse(textepargne.Text), float.Parse(textmontant.Text));
            m1.inser_epargne(m1);
            connexion d = new connexion();
            d.remplirDGV("SELECT * FROM ETAT_FINACIER", TABLE);
        }

        private void ETAT_FINACIER_Load(object sender, EventArgs e)
        {
            connexion con = new connexion();
            con.remplirDGV("select * from ETAT_FINACIER", TABLE);
            //AFFICHER TABLE 2
            connexion c = new connexion();
            c.remplirDGV("select * from CREDIT", TABLE2);
            c.remplirDGV("select * from REMBOURSEMENT", TABLE1);

            textnum.Enabled = false;
        }

        private void TABLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textnum.Text = TABLE.CurrentRow.Cells[0].Value.ToString();
            this.textcredit.Text = TABLE.CurrentRow.Cells[1].Value.ToString();
            this.textrembourser.Text = TABLE.CurrentRow.Cells[2].Value.ToString();
            this.textinteret.Text = TABLE.CurrentRow.Cells[3].Value.ToString();
            this.textinter.Text = TABLE.CurrentRow.Cells[4].Value.ToString();
            this.textepargne.Text = TABLE.CurrentRow.Cells[5].Value.ToString();
            this.textmontant.Text = TABLE.CurrentRow.Cells[6].Value.ToString();
        }

        private void TABLE1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textrembourser.Text = TABLE1.CurrentRow.Cells[0].Value.ToString();
        }

        private void TABLE2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textcredit.Text = TABLE2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
