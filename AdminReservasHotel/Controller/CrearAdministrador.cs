using AdminReservasHotel.Model;
using AdminReservasHotel.PLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    class CrearAdministrador
    {
        
        public CrearAdministrador()
        {

        }

        public void crearAdmin(frmCrearAdmin form)
        {
            bool validado = true;
            string nombre = "";
            string apellido = "";
            string dni = "";
            string correo = "";
            string clave = "";
            DateTime fecha_nacimiento;

            //Se valida que los txtBox no estén vacios
            #region VALIDANDO CAMPOS
            if (form.txtNombre.Text.Length == 0) {
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

            if (form.txtCorreoNuevo.Text.Length == 0)
            {
                form.txtCorreoNuevo.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                correo = form.txtCorreoNuevo.Text;
                form.txtCorreoNuevo.BackColor = System.Drawing.Color.White;
            }                

            if (form.txtClaveNueva.Text.Length == 0)
            {
                form.txtClaveNueva.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                clave = form.txtClaveNueva.Text;
                form.txtClaveNueva.BackColor = System.Drawing.Color.White;
            }
            #endregion

            fecha_nacimiento = form.dateTimeNacimiento.Value;
            
            if (validado) { 
                //Creamos el objeto administrador
                Administrador admin = new Administrador(nombre, apellido, correo, dni, fecha_nacimiento, clave);

                //Insertamos los datos del administrador en la base de datos
                InsertData.insertarAdministrador(admin.Nombre, admin.Apellido, admin.Dni, admin.Correo, admin.Fecha_nacimiento, admin.Clave);

                //Limpiando los campos
                form.txtNombre.Text = "";
                form.txtApellido.Text = "";
                form.txtDni.Text = "";
                form.txtCorreoNuevo.Text = "";
                form.dateTimeNacimiento.Value = DateTime.Parse("1/1/1900");
                form.txtClaveNueva.Text = "";
            }
        }

        
    }
}
