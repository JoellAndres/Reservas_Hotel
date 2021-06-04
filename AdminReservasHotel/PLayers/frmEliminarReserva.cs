using AdminReservasHotel.Controller;
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
    public partial class frmEliminarReserva : Form
    {
        public frmEliminarReserva()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEliminarReserva_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            BuscarData.BuscarEliminarReserva(this);
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar la reserva?", "Eliminar reserva", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {            
                DeleteData.EliminarReserva(this.txtDniTitular.Text);
                lblCodigoId.Text = "-----";
                lblFechaIngreso.Text = "-----";
                lblFechaSalida.Text = "-----";
                lblNHabitacion.Text = "-----";
                lblCantidadPersonas.Text = "-----";
                lblPago.Text = "-----";
                txtDniTitular.Text = "";
                groupBox1.Enabled = false;
            }
        }
    }
}
