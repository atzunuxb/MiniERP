using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_III_FINAL
{
    public partial class INICIO : Form
    {
        CONEXION con = new CONEXION();
        public INICIO()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           //this.Close();
           MENU_PRINCIPAL MenuPrincipal = new MENU_PRINCIPAL();
           MenuPrincipal.Show();
            this.Hide();

        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            con.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte MenuPrincipal = new Reporte();
            MenuPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Febrero MenuPrincipal = new Febrero();
            MenuPrincipal.Show();
            this.Hide();
        }
    }
}
