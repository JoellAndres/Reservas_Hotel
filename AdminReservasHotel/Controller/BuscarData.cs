using AdminReservasHotel.DataBase;
using AdminReservasHotel.PLayers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    static class BuscarData
    {

        public static bool BuscarAdministrador(Form form, bool crear_o_ingreso)
        {
            bool encontrado = false;
            string correo;
            string clave;

            if (crear_o_ingreso) { //Si se llama a la funcion desde el form para crear admin
                frmCrearAdmin frm_crear_admin = (frmCrearAdmin)form;
                correo = frm_crear_admin.txtCorreoAdmin.Text;
                clave = frm_crear_admin.txtClaveAdmin.Text;
            }
            else //Si se llama a la funcion desde el form para ingresoAdmin
            {
                frmIngresoAdmin frm_ingreso_admin = (frmIngresoAdmin)form;
                correo = frm_ingreso_admin.txtCorreoAdmin.Text;
                clave = frm_ingreso_admin.txtClaveClave.Text;
            }

            MySqlDataReader reader = null;

            string sql = "SELECT correo, clave FROM administradores WHERE correo LIKE '"+correo+"' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {                    
                    while (reader.Read())
                    {
                        if (clave == reader.GetString(1))
                            encontrado = true;
                        else
                            encontrado = false;
                    }
                    
                }
                else
                {
                    encontrado = false;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                encontrado = false;
            }
            finally
            {
                conexion.Close();
            }

            return encontrado;
        }

        public static bool BuscarHuesped(string dni)
        {
            bool encontrado = false;

            MySqlDataReader reader = null;

            string sql = "SELECT dni_titular FROM reservas WHERE dni_titular LIKE '" + dni + "' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (dni == reader.GetString(0))
                            encontrado = true;
                        else
                            encontrado = false;
                    }
                }
                else
                {
                    encontrado = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                encontrado = false;
            }
            finally
            {
                conexion.Close();
            }

            return encontrado;
        }

        public static void BuscarConsultaReserva(frmConsultaReserva form) {

            string dni = form.txtDni.Text;
             
            MySqlDataReader reader = null;

            string sql = "SELECT id_reserva, fecha_ingreso, fecha_salida, numero_habitacion, cant_personas, pagado FROM reservas WHERE dni_titular LIKE '" + dni + "' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        form.lblCodigoId.Text = reader.GetString(0);
                        form.lblFechaIngreso.Text = reader.GetString(1);
                        form.lblFechaSalida.Text = reader.GetString(2);
                        form.lblNHabitacion.Text = reader.GetString(3);
                        form.lblCantidadPersonas.Text = reader.GetString(4);
                        if (reader.GetString(5).Equals("1"))
                            form.lblPago.Text = "Pagado";
                        else
                            form.lblPago.Text = "No pagado";
                    }
                }
                else
                {
                    form.lblCodigoId.Text = "-----";
                    form.lblFechaIngreso.Text = "-----";
                    form.lblFechaSalida.Text = "-----";
                    form.lblNHabitacion.Text = "-----";
                    form.lblCantidadPersonas.Text = "-----";
                    form.lblPago.Text = "-----";
                    MessageBox.Show("No existe una reserva para el dni: " + dni, "No encontrado");
                }
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

        public static void BuscarEliminarReserva(frmEliminarReserva form)
        {
            string dni = form.txtDniTitular.Text;

            MySqlDataReader reader = null;

            string sql = "SELECT id_reserva, fecha_ingreso, fecha_salida, numero_habitacion, cant_personas, pagado FROM reservas WHERE dni_titular LIKE '" + dni + "' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        form.lblCodigoId.Text = reader.GetString(0);
                        form.lblFechaIngreso.Text = reader.GetString(1);
                        form.lblFechaSalida.Text = reader.GetString(2);
                        form.lblNHabitacion.Text = reader.GetString(3);
                        form.lblCantidadPersonas.Text = reader.GetString(4);
                        if (reader.GetString(5).Equals("1"))
                            form.lblPago.Text = "Pagado";
                        else
                            form.lblPago.Text = "No pagado";

                        form.groupBox1.Enabled = true;
                    }
                }
                else
                {
                    form.lblCodigoId.Text = "-----";
                    form.lblFechaIngreso.Text = "-----";
                    form.lblFechaSalida.Text = "-----";
                    form.lblNHabitacion.Text = "-----";
                    form.lblCantidadPersonas.Text = "-----";
                    form.lblPago.Text = "-----";
                    form.groupBox1.Enabled = false;
                    MessageBox.Show("No existe una reserva para el dni: " + dni, "No encontrado");
                }
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

        public static int BuscarIdReserva(string dni)
        {
            int id = 0;

            MySqlDataReader reader = null;

            string sql = "SELECT id_reserva FROM reservas WHERE dni_titular LIKE '" + dni + "' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader.GetString(0));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                conexion.Close();
            }

            return id;
        }

    }
}
