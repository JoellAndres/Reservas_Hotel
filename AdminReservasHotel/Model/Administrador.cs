using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    class Administrador : Usuario
    {

        private string clave;

        public string Clave { get => clave;}

        public Administrador(string nombre, string apellido, string correo, string dni, DateTime fecha_nacimiento, string clave) : 
            base (nombre, apellido, correo, dni, fecha_nacimiento)
        {
            this.clave = clave;
        }

        public void crearReserva()
        {

        }

        public void eliminarReserva()
        {

        }

        public override void consultarDisonibilidad()
        {
            throw new NotImplementedException();
        }

        public override void consultarReserva(Reserva r)
        {
            throw new NotImplementedException();
        }

        public override void mostrarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
