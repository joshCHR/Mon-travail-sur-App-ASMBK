using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLICATION_ASMBK
{
    public partial class RAPMEMRE : Form
    {
        public RAPMEMRE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{liste_membre.NOM}='" + RECHERCHE.Text + "'";
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
        }

        private void RECHERCHE_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void RECHERCHE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
