using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;

namespace PROYECTO_III_FINAL
{
    public partial class Empleados : Form
    {

        CONEXION conn = new CONEXION();
        int opcion = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");

        public Empleados()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (opcion == 1)
            {

                try
                {

                    //Insertar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("insert_Empleados", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("dpi_E", OracleType.VarChar).Value = txtDPI.Text;
                    comando.Parameters.Add("fechaNacimiento", OracleType.DateTime).Value = Convert.ToDateTime(txtFechaNacim.Text);
                    //comando.Parameters.Add("fechaNacimiento", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("FechaContrato", OracleType.VarChar).Value = txtFechaContra.Text;
                    comando.Parameters.Add("FechaRegistro", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("id_per", OracleType.Number).Value = Convert.ToInt32(txtIdPersona.Text);
                    comando.Parameters.Add("id_hora", OracleType.Number).Value = Convert.ToInt32(txtIdHorario.Text);
                    comando.Parameters.Add("id_cargo", OracleType.Number).Value = Convert.ToInt32(txtCargo.Text);
                    comando.Parameters.Add("id_depa", OracleType.Number).Value = Convert.ToInt32(txtIdDepar.Text);


                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");

                    txtDPI.Text = " ";
                    txtCargo.Text = " ";
                    txtFechaContra.Text = " ";
                    txtFechaNacim.Text = " ";
                    txtIdDepar.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdHorario.Text = " ";
                    txtIdPersona.Text = " ";

                    txtIdPersona.Enabled = false;
                   txtIdHorario .Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdDepar.Enabled = false;
                    txtFechaNacim.Enabled = false;
                    txtFechaContra.Enabled = false;
                    txtDPI.Enabled = false;
                    txtCargo.Enabled = false;
                    


                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }
            }




            else if (opcion == 2)
            {


                try
                {

                    //Mostrar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("select_Empleados", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMostrar.DataSource = tabla;

                    MessageBox.Show("Listado de Datos insertados");

                    txtDPI.Text = " ";
                    txtCargo.Text = " ";
                    txtFechaContra.Text = " ";
                    txtFechaNacim.Text = " ";
                    txtIdDepar.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdHorario.Text = " ";
                    txtIdPersona.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtIdHorario.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdDepar.Enabled = false;
                    txtFechaNacim.Enabled = false;
                    txtFechaContra.Enabled = false;
                    txtDPI.Enabled = false;
                    txtCargo.Enabled = false;


                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }

            }






            else if (opcion == 3)
            {

                try
                {

                    //Actualizar Campos
                    con.Open();
                    OracleCommand comando = new OracleCommand("Update_Persona", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("id_Emple", OracleType.Number).Value = Convert.ToInt32(txtIdEmpleado.Text);
                    comando.Parameters.Add("dpi_E", OracleType.VarChar).Value = txtDPI.Text;
                    comando.Parameters.Add("fechaNacimiento", OracleType.DateTime).Value = Convert.ToDateTime(txtFechaNacim.Text);
                    comando.Parameters.Add("FechaContrato", OracleType.VarChar).Value = txtFechaContra.Text;
                    comando.Parameters.Add("FechaRegistro", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("id_per", OracleType.Number).Value = Convert.ToInt32(txtIdPersona.Text);
                    comando.Parameters.Add("id_hora", OracleType.Number).Value = Convert.ToInt32(txtIdHorario.Text);
                    comando.Parameters.Add("id_cargo", OracleType.Number).Value = Convert.ToInt32(txtCargo.Text);
                    comando.Parameters.Add("id_depa", OracleType.Number).Value = Convert.ToInt32(txtIdDepar.Text);

                    comando.ExecuteNonQuery();

                    MessageBox.Show(" Datos Actualizados");

                    txtDPI.Text = " ";
                    txtCargo.Text = " ";
                    txtFechaContra.Text = " ";
                    txtFechaNacim.Text = " ";
                    txtIdDepar.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdHorario.Text = " ";
                    txtIdPersona.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtIdHorario.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdDepar.Enabled = false;
                    txtFechaNacim.Enabled = false;
                    txtFechaContra.Enabled = false;
                    txtDPI.Enabled = false;
                    txtCargo.Enabled = false;


                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }


            }



            else if (opcion == 4)
            {


                try
                {

                    //Eliminar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("delete_Empleados", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Emple", OracleType.Number).Value = Convert.ToInt32(txtIdEmpleado.Text);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Datos Eliminados");

                    txtDPI.Text = " ";
                    txtCargo.Text = " ";
                    txtFechaContra.Text = " ";
                    txtFechaNacim.Text = " ";
                    txtIdDepar.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdHorario.Text = " ";
                    txtIdPersona.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtIdHorario.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdDepar.Enabled = false;
                    txtFechaNacim.Enabled = false;
                    txtFechaContra.Enabled = false;
                    txtDPI.Enabled = false;
                    txtCargo.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }


            }



            con.Close();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Personas P = new Personas();
            P.Show();
            this.Hide();
        }

        private void regresarAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            opcion = 1;

            txtIdEmpleado.Enabled = false;
            txtIdPersona.Enabled = true;
            txtIdHorario.Enabled = true;
            txtIdDepar.Enabled = true;
            txtFechaNacim.Enabled = true;
            txtFechaContra.Enabled = true;
            txtDPI.Enabled = true;
            txtCargo.Enabled = true;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 3;

            txtIdEmpleado.Enabled = true;
            txtIdPersona.Enabled = true;
            txtIdHorario.Enabled = true;
            txtIdDepar.Enabled = true;
            txtFechaNacim.Enabled = true;
            txtFechaContra.Enabled = true;
            txtDPI.Enabled = true;
            txtCargo.Enabled = true;


        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 2;
            txtIdPersona.Enabled = false;
            txtIdHorario.Enabled = false;
            txtIdEmpleado.Enabled = false;
            txtIdDepar.Enabled = false;
            txtFechaNacim.Enabled = false;
            txtFechaContra.Enabled = false;
            txtDPI.Enabled = false;
            txtCargo.Enabled = false;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIdPersona.Enabled = false;
            txtIdHorario.Enabled = false;
            txtIdEmpleado.Enabled = true;
            txtIdDepar.Enabled = false;
            txtFechaNacim.Enabled = false;
            txtFechaContra.Enabled = false;
            txtDPI.Enabled = false;
            txtCargo.Enabled = false;
        }
    }
}
