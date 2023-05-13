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
    public partial class FrmBuscarPrestamo : Form
    {
        public FrmBuscarPrestamo()
        {
            InitializeComponent();
            listarPrestamo();
        }

        private void FrmBuscarPrestamo_Load(object sender, EventArgs e)
        {

        }
        public void listarPrestamo()
        {
            dgvPrestamo.DataSource = logPrestamo.Instancia.ListarPrestamoPendientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarPrestamo();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvPrestamo.DataSource = logPrestamo.Instancia.BuscarPrestamoPendiente(dato);

            }
        }

        private void dgvPrestamo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmConsolidado fr = Owner as FrmConsolidado;
            fr.txtIdPrestamo.Text = dgvPrestamo.CurrentRow.Cells[0].Value.ToString();
            fr.txtMontoPrestamo.Text = dgvPrestamo.CurrentRow.Cells[1].Value.ToString();
            fr.cmbEstadoPrestamo.SelectedItem = dgvPrestamo.CurrentRow.Cells[2].Value.ToString();
            fr.txtIdCliente.Text = dgvPrestamo.CurrentRow.Cells[3].Value.ToString();
            Close();
        }

        private void dgvPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
