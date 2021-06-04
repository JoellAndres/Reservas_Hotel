using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AdminReservasHotel.DataBase
{
    class ConexionDataBase
    {
        public static MySqlConnection generarConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; uid=root; pwd=HAJL310812tb; database=dbsistema;");
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR EN LA CONEXION A LA BASE DE DATOS" + ex.Message, "ERROR!");
                return null;
            }
        }

        public bool probarConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; uid=root; pwd=HAJL310812tb; database=dbsistema;");

            try
            {
                conexion.Open();

                MessageBox.Show("Conectado");

                conexion.Close();

                return true;

            } catch (MySqlException ex)
            {
                conexion.Close();

                MessageBox.Show(ex.ToString());

                return false;
            }
            
        }


    }
}
