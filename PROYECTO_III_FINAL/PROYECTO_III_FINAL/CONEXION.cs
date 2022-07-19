using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Configuration;
using System.Windows.Forms;

namespace PROYECTO_III_FINAL
{
    public class CONEXION
    {
        OracleConnection conn;
        //string conexionstring = ConfigurationManager.ConnectionStrings["DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;"].ConnectionString;
        public void conectar()
        {

            try
            {
                conn = new OracleConnection("DATA SOURCE= orcl;PASSWORD=tiger;USER ID=c##scott;");
                //OracleConnection con = new OracleConnection(conexionstring);
                conn.Open();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion rechazada" + ex.ToString());
            }
            conn.Close();
        }
    }
}
