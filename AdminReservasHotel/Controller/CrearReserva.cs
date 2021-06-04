using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminReservasHotel.PLayers;
using AdminReservasHotel.Model;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    class CrearReserva
    {
        public void creadorReserva(frmCrearReserva form)
        {
            bool validado = true;
            bool validar_fecha = true;

            //Datos de la reserva
            DateTime f_ingreso = form.dtpFechaIngreso.Value;
            DateTime f_salida = form.dtpFechaSalida.Value;
            int cant_personas = Convert.ToInt32(form.pickerCantPersonas.Value);
            bool pagado = form.rbPagAhora.Checked;
            string num_habitacion = form.cbHabitaciones.Text;

            //Datos del huesped
            string nombre = "";
            string apellido = "";
            string dni = "";
            string correo = "";
            DateTime fecha_nacimiento = form.dtpFechaNacim.Value;

            #region VALIDANDO CAMPOS
            if (form.txtNombre.Text.Length == 0)
            {
                form.txtNombre.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                nombre = form.txtNombre.Text;
                form.txtNombre.BackColor = System.Drawing.Color.White;
            }

            if (form.txtApellido.Text.Length == 0)
            {
                form.txtApellido.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                apellido = form.txtApellido.Text;
                form.txtApellido.BackColor = System.Drawing.Color.White;
            }

            if (form.txtDni.Text.Length == 0)
            {
                form.txtDni.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                dni = form.txtDni.Text;
                form.txtDni.BackColor = System.Drawing.Color.White;
            }

            if (form.txtCorreo.Text.Length == 0)
            {
                form.txtCorreo.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                correo = form.txtCorreo.Text;
                form.txtCorreo.BackColor = System.Drawing.Color.White;
            }

            if(f_ingreso > f_salida)
            {
                validar_fecha = false;                
            }

            
            #endregion

            //Creamos los objetos
            if (validado && validar_fecha) {

                if (!BuscarData.BuscarHuesped(dni)) //Si no existe un huesped con el dni ingresado
                {
                    Huesped huesp = new Huesped(nombre, apellido, correo, dni, fecha_nacimiento);

                    Reserva res = new Reserva(f_ingreso, f_salida, cant_personas, pagado);                    
                    res.asociarHuesped(huesp);

                    //Convertimos el booleano en entero para pasarlo como parametro e insertarlo en la base de datos
                    int conversion_pagado;
                    if (pagado)
                        conversion_pagado = 1;
                    else
                        conversion_pagado = 0;

                    //Insertamos los datos de la reserva en la base de datos
                    InsertData.insertarReserva(res.Fecha_ingreso, res.Fecha_salida, num_habitacion, huesp.Dni, res.Cant_personas, conversion_pagado);                    
                    InsertData.insertarHuesped(huesp.Nombre, huesp.Apellido, huesp.Dni, huesp.Correo, huesp.Fecha_nacimiento, BuscarData.BuscarIdReserva(dni));
                }
                else
                {
                    MessageBox.Show("Ya existe un huésped con el dni: " + dni + ".\nSolo se puede crear una reserva por huesped!!!", "Control de reservas");
                }
            }
            else
            {
                if (!validado && !validar_fecha)
                    MessageBox.Show("Debe llenar todos los campos para crear la reserva. \nLa fecha de ingreso no puede ser luego de la fecha de salida", "Datos Incompletos");
                else { 
                    if(!validado)
                        MessageBox.Show("Debe llenar todos los campos para crear la reserva", "Datos Incompletos");
                
                    if(!validar_fecha)
                        MessageBox.Show("La fecha de ingreso no puede ser luego de la fecha de salida", "Error de fechas");
                }
            }
        }
    }
}
