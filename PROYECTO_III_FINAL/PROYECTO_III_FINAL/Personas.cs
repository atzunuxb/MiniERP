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
    public partial class Personas : Form
    {
        CONEXION conn = new CONEXION();
        int opcion = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");
        public Personas()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleados emplea = new Empleados();
            emplea.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (opcion == 1)
            {

                try
                {

                    //Insertar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("insert_persona", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                    comando.Parameters.Add("ape", OracleType.VarChar).Value = txtApellidos.Text;
                    comando.Parameters.Add("gen", OracleType.VarChar).Value = txtGenero.Text;
                    comando.Parameters.Add("Dire", OracleType.VarChar).Value = txtDireccion.Text;
                    comando.Parameters.Add("Muni", OracleType.VarChar).Value = txtMunicipio.Text;
                    comando.Parameters.Add("Ciudad", OracleType.VarChar).Value = txtCiudad.Text;
                    comando.Parameters.Add("Tele", OracleType.VarChar).Value = txtTelefono.Text;

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");


                    txtIdPersona.Text = " ";
                    txtNombre.Text = " ";
                    txtApellidos.Text = " ";
                    txtGenero.Text = " ";
                    txtDireccion.Text = " ";
                    txtMunicipio.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtGenero.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtCiudad.Enabled = false;
                    txtTelefono.Enabled = false;


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
                    OracleCommand comando = new OracleCommand("select_persona", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMostrar.DataSource = tabla;

                    MessageBox.Show("Listado de Datos insertados");

                    txtIdPersona.Text = " ";
                    txtNombre.Text = " ";
                    txtApellidos.Text = " ";
                    txtGenero.Text = " ";
                    txtDireccion.Text = " ";
                    txtMunicipio.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtGenero.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtCiudad.Enabled = false;
                    txtTelefono.Enabled = false;


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

                    comando.Parameters.Add("id_per", OracleType.Number).Value = Convert.ToInt32(txtIdPersona.Text);
                    comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                    comando.Parameters.Add("ape", OracleType.VarChar).Value = txtApellidos.Text;
                    comando.Parameters.Add("gen", OracleType.VarChar).Value = txtGenero.Text;
                    comando.Parameters.Add("Dire", OracleType.VarChar).Value = txtDireccion.Text;
                    comando.Parameters.Add("Muni", OracleType.VarChar).Value = txtMunicipio.Text;
                    comando.Parameters.Add("Ciudad", OracleType.VarChar).Value = txtCiudad.Text;
                    comando.Parameters.Add("Tele", OracleType.VarChar).Value = txtTelefono.Text;

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos Actualizados");

                    txtIdPersona.Text = " ";
                    txtNombre.Text = " ";
                    txtApellidos.Text = " ";
                    txtGenero.Text = " ";
                    txtDireccion.Text = " ";
                    txtMunicipio.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtGenero.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtCiudad.Enabled = false;
                    txtTelefono.Enabled = false;


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
                    OracleCommand comando = new OracleCommand("delete_Personas", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Pers", OracleType.Number).Value = Convert.ToInt32(txtIdPersona.Text);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Datos Eliminados");

                    txtIdPersona.Text = " ";
                    txtNombre.Text = " ";
                    txtApellidos.Text = " ";
                    txtGenero.Text = " ";
                    txtDireccion.Text = " ";
                    txtMunicipio.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtIdPersona.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtGenero.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtCiudad.Enabled = false;
                    txtTelefono.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }


            }



            con.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 1;
             txtIdPersona.Enabled = false;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtGenero.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtMunicipio.Enabled = true;
                    txtCiudad.Enabled = true;
                    txtTelefono.Enabled = true;
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //DatosUbicacion DU = new DatosUbicacion();
            //DU.Show();
            //this.Hide();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 2;
            txtIdPersona.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtGenero.Enabled = false;
            txtDireccion.Enabled = false;
            txtMunicipio.Enabled = false;
            txtCiudad.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 3;
            txtIdPersona.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtGenero.Enabled = true;
            txtDireccion.Enabled = true;
            txtMunicipio.Enabled = true;
            txtCiudad.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 4;
            txtIdPersona.Enabled = true;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtGenero.Enabled = false;
            txtDireccion.Enabled = false;
            txtMunicipio.Enabled = false;
            txtCiudad.Enabled = false;
            txtTelefono.Enabled = false;
        }
    }
}
