using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    class Habitacion
    {
        private string numero;
        private int capacidad;
        private double precio;
        private bool estado;

        public Habitacion(string numero, int capacidad, double precio, bool estado)
        {
            this.numero = numero;
            this.capacidad = capacidad;
            this.precio = precio;
            this.estado = estado;
        }

        public void mostrarDatos()
        {

        }

    }
}
