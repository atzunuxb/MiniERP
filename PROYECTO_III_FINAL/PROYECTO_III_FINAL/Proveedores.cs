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
    public partial class Proveedores : Form
    {

        CONEXION conn = new CONEXION();
        int opcion = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");
        public Proveedores()
        {
            InitializeComponent();
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
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
                    OracleCommand comando = new OracleCommand("insert_Proveedores", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("NomCompania", OracleType.VarChar).Value = txtNomCompa.Text;
                    comando.Parameters.Add("Direc", OracleType.VarChar).Value = txtDireccion.Text;
                    comando.Parameters.Add("Muni", OracleType.VarChar).Value = txtMunicipio.Text;
                    comando.Parameters.Add("Ciudad", OracleType.VarChar).Value = txtCiudad.Text;
                    comando.Parameters.Add("Tele", OracleType.VarChar).Value = txtTelefono.Text;
                    comando.Parameters.Add("fechaRegisProvee", OracleType.DateTime).Value = DateTime.Today;
                   
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");


                    txtIdProveedor.Text = " ";
                    txtMunicipio.Text = " ";
                    txtDireccion.Text = " ";
                    txtNomCompa.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtNomCompa.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtIdProveedor.Enabled = false;
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
                    OracleCommand comando = new OracleCommand("select_Proveedores", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMostrar.DataSource = tabla;

                    MessageBox.Show("Listado de Datos insertados");

                    txtIdProveedor.Text = " ";
                    txtMunicipio.Text = " ";
                    txtDireccion.Text = " ";
                    txtNomCompa.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtNomCompa.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtIdProveedor.Enabled = false;
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
                    OracleCommand comando = new OracleCommand("Update_Proveedores", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Provee", OracleType.Number).Value = Convert.ToInt32(txtIdProveedor.Text);
                    comando.Parameters.Add("nomcomp", OracleType.VarChar).Value = txtNomCompa.Text;
                    comando.Parameters.Add("Direc", OracleType.VarChar).Value = txtDireccion.Text;
                    comando.Parameters.Add("Muni", OracleType.VarChar).Value = txtMunicipio.Text;
                    comando.Parameters.Add("Ciudad", OracleType.VarChar).Value = txtCiudad.Text;
                    comando.Parameters.Add("Tele", OracleType.VarChar).Value = txtTelefono.Text;
                    comando.Parameters.Add("fechaRegisProvee", OracleType.DateTime).Value = DateTime.Today;
                   
                   

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos Actualizados");

                    txtIdProveedor.Text = " ";
                    txtMunicipio.Text = " ";
                    txtDireccion.Text = " ";
                    txtNomCompa.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtNomCompa.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtIdProveedor.Enabled = false;
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
                    OracleCommand comando = new OracleCommand("delete_Proveedores", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Provee ", OracleType.Number).Value = Convert.ToInt32(txtIdProveedor.Text);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Datos Eliminados");

                    txtIdProveedor.Text = " ";
                    txtMunicipio.Text = " ";
                    txtDireccion.Text = " ";
                    txtNomCompa.Text = " ";
                    txtTelefono.Text = " ";
                    txtCiudad.Text = " ";

                    txtNomCompa.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtMunicipio.Enabled = false;
                    txtIdProveedor.Enabled = false;
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

            txtNomCompa.Enabled = true;
            txtDireccion.Enabled = true;
            txtMunicipio.Enabled = true;
            txtIdProveedor.Enabled = false;
            txtCiudad.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 2;

            txtNomCompa.Enabled = false;
            txtDireccion.Enabled = false;
            txtMunicipio.Enabled = false;
            txtIdProveedor.Enabled = false;
            txtCiudad.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 3;
            txtNomCompa.Enabled = true;
            txtDireccion.Enabled = true;
            txtMunicipio.Enabled = true;
            txtIdProveedor.Enabled = true;
            txtCiudad.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 4;
            txtNomCompa.Enabled = false;
            txtDireccion.Enabled = false;
            txtMunicipio.Enabled = false;
            txtIdProveedor.Enabled = true;
            txtCiudad.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void probarConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.conectar();
        }
    }
}
