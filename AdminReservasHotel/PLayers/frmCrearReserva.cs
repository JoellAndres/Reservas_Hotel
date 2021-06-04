using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminReservasHotel.Controller;

namespace AdminReservasHotel.PLayers
{
    public partial class frmCrearReserva : Form
    {
        public frmCrearReserva()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            CrearReserva crearRes = new CrearReserva();
            crearRes.creadorReserva(this);
        }

        private void frmCrearReserva_Load(object sender, EventArgs e)
        {
            rbPagAhora.Checked = true;
            
        }

        private void pickerCantPersonas_ValueChanged(object sender, EventArgs e)
        {
            MostrarData.MostrarNumHabitacion(this, Convert.ToInt32(pickerCantPersonas.Value));
        }
    }
}
