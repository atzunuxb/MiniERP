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
    public partial class Clientes : Form
    {
        CONEXION conn = new CONEXION();
        int menu = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {



            if (menu == 1)
            {

                try
            {

                    //Insertar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("insert_Cliente", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.Parameters.Add("Tipo_C", OracleType.VarChar).Value = txtTipoCliente.Text;
                    comando.Parameters.Add("Descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                    comando.Parameters.Add("feRegistro", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("Id_pers", OracleType.VarChar).Value = txtIdPersona.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");

                    txtIdCliente.Text = " ";
                    txtIdCliente.Text = " ";
                    txtTipoCliente.Text = " ";
                    txtDescripcion.Text = " ";

                    txtIdCliente.Enabled = false;
                    txtIdPersona.Enabled = false;
                    txtTipoCliente.Enabled = false;
                    txtDescripcion.Enabled = false;


                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }
            }



            else if (menu == 2)
            {
                try
                {

                    //Mostrar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("select_clientes", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMostrar.DataSource = tabla;

                    MessageBox.Show("Listado de Datos insertados");

                    txtIdCliente.Text = " ";
                    txtIdCliente.Text = " ";
                    txtTipoCliente.Text = " ";
                    txtDescripcion.Text = " ";

                    txtIdCliente.Enabled = false;
                    txtIdPersona.Enabled = false;
                    txtTipoCliente.Enabled = false;
                    txtDescripcion.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }
            }






            else if (menu == 3)
            {

                try
                {

                    //Actualizar Campos
                    con.Open();
                    OracleCommand comando = new OracleCommand("Update_Clientes", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_clie", OracleType.Number).Value = Convert.ToInt32(txtIdCliente.Text);
                    comando.Parameters.Add("Tipo_C", OracleType.VarChar).Value = txtTipoCliente.Text;
                    comando.Parameters.Add("Descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                    comando.Parameters.Add("feRegistro", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("Id_pers", OracleType.VarChar).Value = txtIdPersona.Text;
                    comando.ExecuteNonQuery();

                    MessageBox.Show(" Datos Actualizados");

                    txtIdCliente.Text = " ";
                    txtIdCliente.Text = " ";
                    txtTipoCliente.Text = " ";
                    txtDescripcion.Text = " ";

                    txtIdCliente.Enabled = false;
                    txtIdPersona.Enabled = false;
                    txtTipoCliente.Enabled = false;
                    txtDescripcion.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }
            }




            else if (menu == 4)
            {
                try
                {

                    //Eliminar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("delete_Clientes", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Clie", OracleType.Number).Value = Convert.ToInt32(txtIdCliente.Text);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Datos Eliminados");

                    txtIdCliente.Text = " ";
                    txtIdCliente.Text = " ";
                    txtTipoCliente.Text = " ";
                    txtDescripcion.Text = " ";

                    txtIdCliente.Enabled = false;
                    txtIdPersona.Enabled = false;
                    txtTipoCliente.Enabled = false;
                    txtDescripcion.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }
            }





            con.Close();


        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Personas P = new Personas();
            P.Show();
            this.Hide();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu = 1;
            txtIdCliente.Enabled = false;
            txtIdPersona.Enabled = true;
            txtTipoCliente.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu = 2;
            txtIdCliente.Enabled = false;
            txtIdPersona.Enabled = false;
            txtTipoCliente.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu = 3;
            txtIdCliente.Enabled = true;
            txtIdPersona.Enabled = true;
            txtTipoCliente.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu = 4;
            txtIdCliente.Enabled = true;
            txtIdPersona.Enabled = false;
            txtTipoCliente.Enabled = false;
            txtDescripcion.Enabled = false;
        }
    }
}
