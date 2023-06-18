using Sistema_Prestamos.Mantendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Prestamos.Principal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCuenta cuenta = new FrmCuenta();
            cuenta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPrestamo prestamo = new FrmPrestamo();
            prestamo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmConsolidado c = new FrmConsolidado();
            c.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
