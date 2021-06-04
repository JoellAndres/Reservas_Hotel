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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnAdminSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearNuevaReserva_Click(object sender, EventArgs e)
        {
            frmCrearReserva frm = new frmCrearReserva();
            frm.ShowDialog();
        }

        private void btnConsultarReserva_Click(object sender, EventArgs e)
        {
            frmConsultaReserva frm = new frmConsultaReserva();
            frm.ShowDialog();
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            frmConsultaDisponibilidad frm = new frmConsultaDisponibilidad();
            frm.ShowDialog();
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            frmEliminarReserva frm = new frmEliminarReserva();
            frm.ShowDialog();
        }
    }
}
