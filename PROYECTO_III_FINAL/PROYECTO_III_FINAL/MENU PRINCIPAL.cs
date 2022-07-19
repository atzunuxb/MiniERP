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
    public partial class MENU_PRINCIPAL : Form
    {
        public MENU_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevasCompras MenuCompras = new NuevasCompras();
            MenuCompras.Show();
            this.Hide();
        }

        private void fINANCIEROYCONTABLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FINANCIERO_Y_CONTABLE MenuFinCon = new FINANCIERO_Y_CONTABLE();
            MenuFinCon.Show();
            this.Hide();
        }

        private void gESTIONDELACADENADESUMINISTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gESTIONDERELACIONESCONCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GESTION_DE_RELACIONES_CON__LOS_CLIENTES__CRM_ MenuGestRelaClie = new GESTION_DE_RELACIONES_CON__LOS_CLIENTES__CRM_();
            //MenuGestRelaClie.Show();
            //this.Hide();
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INVENTARIO MenuInventario = new INVENTARIO();
            MenuInventario.Show();
            this.Hide();
        }

        private void pRODUCCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRODUCCION MenuProduccion = new PRODUCCION();
            //MenuProduccion.Show();
            //this.Hide();
        }

        private void rECURSOSHUMANOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevasVentas MenuVentas = new NuevasVentas();
            MenuVentas.Show();
            this.Hide();
        }

        private void oTRASOPCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevasVentas MenuVentas = new NuevasVentas();
            MenuVentas.Show();
            this.Hide();
        }

        private void cOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevasCompras MenuCompras = new NuevasCompras();
            MenuCompras.Show();
            this.Hide();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Telefonos tel = new Telefonos();
            //tel.Show();
            //this.Hide();
        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Telefonos tel = new Telefonos();
            //tel.Show();
            //this.Hide();
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Telefonos tel = new Telefonos();
            //tel.Show();
            //this.Hide();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
            this.Hide();
        }

        private void hORASEXTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorasExtras HoEx = new HorasExtras();
            HoEx.Show();
            this.Hide();
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos Producto = new Productos();
            Producto.Show();
            this.Hide();
        }

        private void personasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Personas Person = new Personas();
            Person.Show();
            this.Hide();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados Empleado = new Empleados();
            Empleado.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();
            Cliente.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores Provee = new Proveedores();
            Provee.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Productos Producto = new Productos();
            Producto.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios User = new Usuarios();
            User.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INICIO User = new INICIO();
            User.Show();
            this.Hide();
        }
    }
}
