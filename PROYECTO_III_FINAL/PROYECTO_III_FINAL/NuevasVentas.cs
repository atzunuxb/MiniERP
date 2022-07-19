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
    public partial class NuevasVentas : Form
    {
        CONEXION conn = new CONEXION();
        int opcion = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");
        public NuevasVentas()
        {
            InitializeComponent();
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MENU_PRINCIPAL MP = new MENU_PRINCIPAL();
            MP.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {

                try
                {

                    //Insertar Datos
                    con.Open();
                    OracleCommand comando = new OracleCommand("insert_Ventas", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.Parameters.Add("cantProd", OracleType.Number).Value = Convert.ToInt32(txtcantidadProduct.Text);
                    comando.Parameters.Add("costou", OracleType.Float).Value = Convert.ToDecimal(txtCostoUnitario.Text);
                    comando.Parameters.Add("Precioto", OracleType.Float).Value = Convert.ToDecimal(txtPrecioTotal.Text);
                    comando.Parameters.Add("fechaRegven", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("IdProdu", OracleType.Number).Value = Convert.ToInt32(txtIdProducto.Text);
                    comando.Parameters.Add("IdEmple", OracleType.Number).Value = Convert.ToInt32(txtIdEmpleado.Text);
                    comando.Parameters.Add("IdCliente", OracleType.Number).Value = Convert.ToInt32(txtIdCliente.Text);
                    comando.Parameters.Add("IdTipPag", OracleType.Number).Value = Convert.ToInt32(txtIdTipoPago.Text);


                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");

                    txtcantidadProduct.Text = " ";
                    txtCostoUnitario.Text = " ";
                    txtIdCliente.Text = " ";
                    txtIdVentas.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdProducto.Text = " ";
                    txtIdTipoPago.Text = " ";
                    txtPrecioTotal.Text = " ";

               
                    txtPrecioTotal.Enabled = false;
                    txtIdTipoPago.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdVentas.Enabled = false;
                    txtIdCliente.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtcantidadProduct.Enabled = false;
                    



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
                    OracleCommand comando = new OracleCommand("select_Ventas", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMostrar.DataSource = tabla;

                    MessageBox.Show("Listado de Datos insertados");

                    txtcantidadProduct.Text = " ";
                    txtCostoUnitario.Text = " ";
                    txtIdCliente.Text = " ";
                    txtIdVentas.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdProducto.Text = " ";
                    txtIdTipoPago.Text = " ";
                    txtPrecioTotal.Text = " ";


                    txtPrecioTotal.Enabled = false;
                    txtIdTipoPago.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdVentas.Enabled = false;
                    txtIdCliente.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtcantidadProduct.Enabled = false;


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
                    OracleCommand comando = new OracleCommand("Update_Ventas", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_ven", OracleType.Number).Value = Convert.ToInt32(txtIdVentas.Text);
                    comando.Parameters.Add("cantProd", OracleType.Number).Value = Convert.ToInt32(txtcantidadProduct.Text);
                    comando.Parameters.Add("costou", OracleType.Float).Value = Convert.ToDecimal(txtCostoUnitario.Text);
                    comando.Parameters.Add("Precioto", OracleType.Float).Value = Convert.ToDecimal(txtPrecioTotal.Text);
                    comando.Parameters.Add("fechaRegven", OracleType.DateTime).Value = DateTime.Today;
                    comando.Parameters.Add("IdProdu", OracleType.Number).Value = Convert.ToInt32(txtIdProducto.Text);
                    comando.Parameters.Add("IdEmple", OracleType.Number).Value = Convert.ToInt32(txtIdEmpleado.Text);
                    comando.Parameters.Add("Idclien", OracleType.Number).Value = Convert.ToInt32(txtIdCliente.Text);
                    comando.Parameters.Add("IdTipPag", OracleType.Number).Value = Convert.ToInt32(txtIdTipoPago.Text);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos Actualizados");

                    txtcantidadProduct.Text = " ";
                    txtCostoUnitario.Text = " ";
                    txtIdCliente.Text = " ";
                    txtIdVentas.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdProducto.Text = " ";
                    txtIdTipoPago.Text = " ";
                    txtPrecioTotal.Text = " ";


                    txtPrecioTotal.Enabled = false;
                    txtIdTipoPago.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdVentas.Enabled = false;
                    txtIdCliente.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtcantidadProduct.Enabled = false;



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
                    OracleCommand comando = new OracleCommand("delete_Ventas", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_ven", OracleType.Number).Value = Convert.ToInt32(txtIdVentas.Text);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Datos Eliminados");

                    txtcantidadProduct.Text = " ";
                    txtCostoUnitario.Text = " ";
                    txtIdCliente.Text = " ";
                    txtIdVentas.Text = " ";
                    txtIdEmpleado.Text = " ";
                    txtIdProducto.Text = " ";
                    txtIdTipoPago.Text = " ";
                    txtPrecioTotal.Text = " ";


                    txtPrecioTotal.Enabled = false;
                    txtIdTipoPago.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtIdEmpleado.Enabled = false;
                    txtIdVentas.Enabled = false;
                    txtIdCliente.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtcantidadProduct.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accion");
                }


            }



            con.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 1;
            txtPrecioTotal.Enabled = true;
            txtIdTipoPago.Enabled = true;
            txtIdProducto.Enabled = true;
            txtIdEmpleado.Enabled = true;
            txtIdVentas.Enabled = false;
            txtIdCliente.Enabled = true;
            txtCostoUnitario.Enabled = true;
            txtcantidadProduct.Enabled = true;

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 2;
            txtPrecioTotal.Enabled = false;
            txtIdTipoPago.Enabled = false;
            txtIdProducto.Enabled = false;
            txtIdEmpleado.Enabled = false;
            txtIdVentas.Enabled = false;
            txtIdCliente.Enabled = false;
            txtCostoUnitario.Enabled = false;
            txtcantidadProduct.Enabled = false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 3;

            txtPrecioTotal.Enabled = true;
            txtIdTipoPago.Enabled = true;
            txtIdProducto.Enabled = true;
            txtIdEmpleado.Enabled = true;
            txtIdVentas.Enabled = true;
            txtIdCliente.Enabled = true;
            txtCostoUnitario.Enabled = true;
            txtcantidadProduct.Enabled = true;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 4;
            txtPrecioTotal.Enabled = false;
            txtIdTipoPago.Enabled = false;
            txtIdProducto.Enabled = false;
            txtIdEmpleado.Enabled = false;
            txtIdVentas.Enabled = true;
            txtIdCliente.Enabled = false;
            txtCostoUnitario.Enabled = false;
            txtcantidadProduct.Enabled = false;
        }
    }
}
