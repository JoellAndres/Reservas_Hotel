using AdminReservasHotel.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    static class DeleteData
    {
        public static void EliminarReserva(string dni)
        {
            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            string sql = "DELETE FROM reservas WHERE dni_titular='" + dni + "'; DELETE FROM huespedes WHERE dni='" + dni + "'";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reserva eliminada con éxito", "Realizado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
