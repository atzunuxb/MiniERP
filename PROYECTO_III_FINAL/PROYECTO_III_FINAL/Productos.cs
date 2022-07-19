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
    public partial class Productos : Form
    {

        CONEXION conn = new CONEXION();
        int opcion = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");
        public Productos()
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
                    OracleCommand comando = new OracleCommand("insert_Productos", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    comando.Parameters.Add("nomProd", OracleType.VarChar).Value = TxtNomProduct.Text;
                    comando.Parameters.Add("TipoP", OracleType.VarChar).Value = txtTipoProdcut.Text;
                    comando.Parameters.Add("precioComp", OracleType.Float).Value = Convert.ToDecimal(txtCostoCompra.Text);
                    comando.Parameters.Add("PrecioVen", OracleType.Float).Value = Convert.ToDecimal (txtPrecioVenta.Text);
                    comando.Parameters.Add("NumStock", OracleType.Number).Value = Convert.ToInt32(txtNumStock.Text);
                    comando.Parameters.Add("fechaRegProd", OracleType.DateTime).Value = DateTime.Today;             
                    

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");


                    txtCostoCompra.Text = " ";
                    txtIdProducto.Text = " ";
                    txtTipoProdcut.Text = " ";
                    TxtNomProduct.Text = " ";
                    txtNumStock.Text = " ";
                    txtPrecioVenta.Text = " ";
                    


                    txtPrecioVenta.Enabled = false;
                    txtNumStock.Enabled = false;
                    TxtNomProduct.Enabled = false;
                    txtTipoProdcut.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtCostoCompra.Enabled = false;
                   



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
                    OracleCommand comando = new OracleCommand("select_Productos", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvMostrar.DataSource = tabla;

                    MessageBox.Show("Listado de Datos insertados");

                    txtCostoCompra.Text = " ";
                    txtIdProducto.Text = " ";
                    txtTipoProdcut.Text = " ";
                    TxtNomProduct.Text = " ";
                    txtNumStock.Text = " ";
                    txtPrecioVenta.Text = " ";
                   


                    txtPrecioVenta.Enabled = false;
                    txtNumStock.Enabled = false;
                    TxtNomProduct.Enabled = false;
                    txtTipoProdcut.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtCostoCompra.Enabled = false;

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
                    OracleCommand comando = new OracleCommand("Update_Productos", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Product", OracleType.Number).Value = Convert.ToInt32(txtIdProducto.Text);
                    comando.Parameters.Add("NomProd", OracleType.VarChar).Value = TxtNomProduct.Text;
                    comando.Parameters.Add("TipoP", OracleType.VarChar).Value = txtTipoProdcut.Text;
                    comando.Parameters.Add("precioComp", OracleType.Float).Value = Convert.ToDecimal(txtCostoCompra.Text);
                    comando.Parameters.Add("PrecioVen", OracleType.Float).Value = Convert.ToDecimal(txtPrecioVenta.Text);
                    comando.Parameters.Add("NumStock", OracleType.Number).Value = Convert.ToInt32(txtNumStock.Text);
                    comando.Parameters.Add("fechaRegProd", OracleType.DateTime).Value = DateTime.Today;
                    

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos Actualizados");

                    txtCostoCompra.Text = " ";
                    txtIdProducto.Text = " ";
                    txtTipoProdcut.Text = " ";
                    TxtNomProduct.Text = " ";
                    txtNumStock.Text = " ";
                    txtPrecioVenta.Text = " ";


                    txtPrecioVenta.Enabled = false;
                    txtNumStock.Enabled = false;
                    TxtNomProduct.Enabled = false;
                    txtTipoProdcut.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtCostoCompra.Enabled = false;


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
                    OracleCommand comando = new OracleCommand("delete_Productos", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("Id_Prod", OracleType.Number).Value = Convert.ToInt32(txtIdProducto.Text);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Datos Eliminados");

                    txtCostoCompra.Text = " ";
                    txtIdProducto.Text = " ";
                    txtTipoProdcut.Text = " ";
                    TxtNomProduct.Text = " ";
                    txtNumStock.Text = " ";
                    txtPrecioVenta.Text = " ";


                    txtPrecioVenta.Enabled = false;
                    txtNumStock.Enabled = false;
                    TxtNomProduct.Enabled = false;
                    txtTipoProdcut.Enabled = false;
                    txtIdProducto.Enabled = false;
                    txtCostoCompra.Enabled = false;
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
            txtPrecioVenta.Enabled = true;
            txtNumStock.Enabled = true;
            TxtNomProduct.Enabled = true;
            txtTipoProdcut.Enabled = true;
            txtIdProducto.Enabled = false;
            txtCostoCompra.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 2;
            txtPrecioVenta.Enabled = false;
            txtNumStock.Enabled = false;
            TxtNomProduct.Enabled = false;
            txtTipoProdcut.Enabled = false;
            txtIdProducto.Enabled = false;
            txtCostoCompra.Enabled = false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 3;
            txtPrecioVenta.Enabled = true;
            txtNumStock.Enabled = true;
            TxtNomProduct.Enabled = true;
            txtTipoProdcut.Enabled = true;
            txtIdProducto.Enabled = true;
            txtCostoCompra.Enabled = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 4;
            txtPrecioVenta.Enabled = false;
            txtNumStock.Enabled = false;
            TxtNomProduct.Enabled = false;
            txtTipoProdcut.Enabled = false;
            txtIdProducto.Enabled = true;
            txtCostoCompra.Enabled = false;

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
