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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            //MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            //MP.Show();
            //this.Hide();
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
