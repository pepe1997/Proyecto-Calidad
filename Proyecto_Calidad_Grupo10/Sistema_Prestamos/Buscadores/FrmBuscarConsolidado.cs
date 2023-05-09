using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using entConsolidado;
using Sistema_Prestamos.Mantendedor;
using Sistema_Prestamos.Transaccion;

namespace Sistema_Prestamos.Buscadores
{
    public partial class FrmBuscarConsolidado : Form
    {
        public FrmBuscarConsolidado()
        {
            InitializeComponent();
        }

        private void FrmBuscarConsolidado_Load(object sender, EventArgs e)
        {

        }
        public void listarConsolidado()
        {
            dgvConsolidado.DataSource = logConsolidado.Instancia.ListarConsolidado();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                listarConsolidado();
            }
            else
            {
                string dato = txtBuscar.Text.Trim(); // se obtiene el valor de una celda 
                dgvConsolidado.DataSource = logConsolidado.Instancia.BuscarConsolidado(dato);

            }
        }

        private void dgvConsolidado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPlan_Pago fr = Owner as FrmPlan_Pago;
            fr.txtIdConsolidado.Text = dgvConsolidado.CurrentRow.Cells[0].Value.ToString();
            fr.txtMesConsolidado.Text = dgvConsolidado.CurrentRow.Cells[1].Value.ToString();
            fr.txtInteresConsolidado.Text = dgvConsolidado.CurrentRow.Cells[2].Value.ToString();
            fr.txtIdCuenta.Text = dgvConsolidado.CurrentRow.Cells[8].Value.ToString();
            Close();
        }
    }
}
