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
    public partial class frmCrearAdmin : Form
    {
        public frmCrearAdmin()
        {
            InitializeComponent();
        }

        private void btnCrearAdmin_Click(object sender, EventArgs e)
        {
            CrearAdministrador crear_admin = new CrearAdministrador();
            crear_admin.crearAdmin(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificarCrearAdmin_Click(object sender, EventArgs e)
        {            

            if (BuscarData.BuscarAdministrador(this, true))
            {
                groupBoxNuevoAdmin.Enabled = true;
            }
            else
            {
                MessageBox.Show("El correo y la clave no coinciden");
            }
        }

        private void frmCrearAdmin_Load(object sender, EventArgs e)
        {
            groupBoxNuevoAdmin.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
