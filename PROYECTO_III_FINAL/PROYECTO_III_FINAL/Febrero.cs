using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CrystalDecisions.CrystalReports.Engine;

namespace PROYECTO_III_FINAL
{
    public partial class Febrero : Form
    {
        public Febrero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\baten\Desktop\Proyectos\MiniCRM\PROYECTO_III_FINAL\PROYECTO_III_FINAL\CrVentasFebrero.rpt");
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INICIO User = new INICIO();
            User.Show();
            this.Hide();
        }
    }
}
