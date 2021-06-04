using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    abstract class Usuario
    {
        protected string nombre;
        protected string apellido;
        protected string correo;
        protected string dni;
        protected DateTime fecha_nacimiento;

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public string Correo { get => correo;}
        public string Dni { get => dni;}
        public DateTime Fecha_nacimiento { get => fecha_nacimiento;}

        public Usuario(string nombre, string apellido, string correo, string dni, DateTime fecha_nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.dni = dni;
            this.fecha_nacimiento = fecha_nacimiento;
        }

        public Usuario()
        {
        }

        public abstract void mostrarDatos();
        public abstract void consultarReserva(Reserva r);
        public abstract void consultarDisonibilidad();

    }
}
