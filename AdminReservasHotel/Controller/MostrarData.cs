using AdminReservasHotel.DataBase;
using AdminReservasHotel.PLayers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    static class MostrarData
    {
        public static void MostrarNumHabitacion(frmCrearReserva frm, int cap)
        {

            string sql = "SELECT * FROM habitaciones WHERE capacidad='" + cap + "'";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();

                da.Fill(dt);
                frm.cbHabitaciones.ValueMember = "numero";
                frm.cbHabitaciones.DisplayMember = "numero";
                frm.cbHabitaciones.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
