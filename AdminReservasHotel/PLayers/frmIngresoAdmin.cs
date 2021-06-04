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
    public partial class frmIngresoAdmin : Form
    {
        public frmIngresoAdmin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearNuevoAdmin_Click(object sender, EventArgs e)
        {
            frmCrearAdmin formAdmin = new frmCrearAdmin();
            formAdmin.ShowDialog(this);
            
        }

        private void btnIngresarAdmin_Click(object sender, EventArgs e)
        {
            
            if (BuscarData.BuscarAdministrador(this, false))
            {
                frmAdministrador form_admin = new frmAdministrador();
                form_admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("El correo y la clave no coinciden");
            }
        }

        private void frmIngresoAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
