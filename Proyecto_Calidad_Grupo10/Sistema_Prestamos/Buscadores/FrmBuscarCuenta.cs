using LogicaNegocio;
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

namespace Sistema_Prestamos.Buscadores
{
    public partial class FrmBuscarCuenta : Form
    {
        public FrmBuscarCuenta()
        {
            InitializeComponent();
            listarCuenta();
        }

        private void FrmBuscarCuenta_Load(object sender, EventArgs e)
        {

        }
        public void listarCuenta()
        {
            dgvCuenta.DataSource = logCuenta.Instancia.ListarCuenta();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarCuenta();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvCuenta.DataSource = logCuenta.Instancia.BuscarCuenta(dato);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCuenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmConsolidado fr = Owner as FrmConsolidado;
            fr.txtIdCuenta.Text = dgvCuenta.CurrentRow.Cells[0].Value.ToString();
            fr.txtNroCuenta.Text = dgvCuenta.CurrentRow.Cells[1].Value.ToString();
            fr.txtSaldo.Text = dgvCuenta.CurrentRow.Cells[2].Value.ToString();
            
            Close();
        }
    }
}
