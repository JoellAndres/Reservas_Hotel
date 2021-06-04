using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    class Huesped : Usuario
    {
        private Reserva reserva;

        public void agregarReserva(Reserva r)
        {
            this.reserva = r;
        }

        public Huesped(string nombre, string apellido, string correo, string dni, DateTime fecha_nacimiento) :
            base(nombre, apellido, correo, dni, fecha_nacimiento)
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
