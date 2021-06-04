using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    class Reserva
    {
        private DateTime fecha_ingreso;
        private DateTime fecha_salida;
        private Habitacion habitacion;
        private Huesped titular_reserva;
        private int cant_personas;
        private bool pagado;

        public Reserva(DateTime fecha_ingreso, DateTime fecha_salida, int cant_personas, bool pagado)
        {
            this.fecha_ingreso = fecha_ingreso;
            this.fecha_salida = fecha_salida;
            this.cant_personas = cant_personas;
            this.pagado = pagado;
        }

        public DateTime Fecha_ingreso { get => fecha_ingreso;}
        public DateTime Fecha_salida { get => fecha_salida;}
        public int Cant_personas { get => cant_personas;}
        public bool Pagado { get => pagado;}
        internal Habitacion Habitacion { get => habitacion;}
        internal Huesped Titular_reserva { get => titular_reserva;}

        public void agregarHabitacion(Habitacion hab)
        {
            this.habitacion = hab;
        }
        public void asociarHuesped(Huesped hu)
        {
            this.titular_reserva = hu;
        }

        public void mostrarDatos()
        {

        }


    }
}
