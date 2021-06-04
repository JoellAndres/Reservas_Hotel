using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.PLayers
{
    public partial class frmHuesped : Form
    {
        public frmHuesped()
        {
            InitializeComponent();
        }

        private void btnHuespedSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultaReserva_Click(object sender, EventArgs e)
        {
            frmConsultaReserva form_consulta_reserva = new frmConsultaReserva();
            form_consulta_reserva.ShowDialog();
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            frmConsultaDisponibilidad frm_consulta_disp = new frmConsultaDisponibilidad();
            frm_consulta_disp.ShowDialog();
        }
    }
}
