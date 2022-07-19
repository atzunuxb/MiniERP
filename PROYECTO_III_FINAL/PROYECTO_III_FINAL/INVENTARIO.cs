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
    public partial class INVENTARIO : Form
    {
        CONEXION conn = new CONEXION();
        int opcion = 0;
        OracleConnection con = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");
        public INVENTARIO()
        {
            InitializeComponent();
        }

        private void INVENTARIO_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
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
                dgvVentas.DataSource = tabla;

                MessageBox.Show("Listado de Datos insertados");

                

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la accion");
            }
            con.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

            try
            {

                //Mostrar Datos
                con.Open();
                OracleCommand comando = new OracleCommand("select_Compras", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvCompras.DataSource = tabla;

                MessageBox.Show("Listado de Datos insertados");

              



            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la accion");
            }
            con.Close();
        }
    }
}
