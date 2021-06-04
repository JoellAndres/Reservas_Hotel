using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    class Hotel
    {

        private List<Habitacion> habitaciones = new List<Habitacion>();
        private string correo;
        private string direccion;
        private string telefono;

        public Hotel(string correo, string direccion, string telefono)
        {
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public void agregarHabitacion()
        {
            habitaciones.Add(new Habitacion("123", 0, 0.00, false));
        }

        public void mostrarDatos()
        {

        }

    }
}
