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
    public partial class RAPPORT_MEMBRE : Form
    {
        public RAPPORT_MEMBRE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{rapport_MEMBRE.NOM}='" + RECHERCHE.Text + "'";
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
        }

        private void RECHERCHE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
