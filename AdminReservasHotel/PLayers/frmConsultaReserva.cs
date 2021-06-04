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
    public partial class frmConsultaReserva : Form
    {
        public frmConsultaReserva()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarRes_Click(object sender, EventArgs e)
        {
            BuscarData.BuscarConsultaReserva(this);
        }
    }
}
