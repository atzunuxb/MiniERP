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
    public partial class HorasExtras : Form
    {
        public HorasExtras()
        {
            InitializeComponent();
        }

        private void volverAInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
