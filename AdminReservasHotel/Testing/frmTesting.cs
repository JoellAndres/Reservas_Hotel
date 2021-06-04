using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminReservasHotel.DataBase;

namespace AdminReservasHotel.Testing
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionDataBase conexion = new ConexionDataBase();

            if (conexion.probarConexion()){
                panel1.BackColor = Color.Green;
                label1.Text = "Estado de la conexion: CONECTADO :D";
            } else
            {
                panel1.BackColor = Color.Red;
                label1.Text = "Estado de la conexion: DESCONECTADO :C";
            }

        }
    }
}
