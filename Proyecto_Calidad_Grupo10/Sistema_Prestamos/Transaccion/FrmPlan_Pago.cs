using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entPlan_Pago;
using LogicaNegocio;
using Sistema_Prestamos.Mantendedor;
using entConsolidado;
using Sistema_Prestamos.Buscadores;

namespace Sistema_Prestamos.Transaccion
{
    public partial class FrmPlan_Pago : Form
    {
        public FrmPlan_Pago()
        {
            InitializeComponent();
            listarPlan();
        }

        private void FrmPlan_Pago_Load(object sender, EventArgs e)
        {

        }
        public void listarPlan()
        {
            dgvPlan.DataSource = logPlan.Instancia.ListarPlan();
        }
        private void LimpiarVariables()
        {
            txtIdPlan.Text = "";
            txtMesPlan.Text = "";
            txtCapRemanente.Text = "";
            txtCapDevolver.Text = "";
            txtInteresPLan.Text = "";
            txtTotalPago.Text = "";
            dtpFechaPlan.Text = "";
            txtIdPlan.Focus();
        }
        private void LimpiarVaraiblesConsolidado()
        {
            txtIdConsolidado.Text = "";
            txtMesConsolidado.Text = "";
            txtInteresConsolidado.Text = "";
            txtIdCuenta.Text = "";
            txtSaldoCuenta.Text = "";
            txtIdConsolidado.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Plan_Pago c = new Plan_Pago();
                c.idPlan = txtIdPlan.Text.Trim();
                c.mesPlan = Convert.ToInt32(txtMesPlan.Text.Trim());
                c.capitalRemanente = Convert.ToDouble(txtCapRemanente.Text.Trim());
                c.capitalDevolver = Convert.ToDouble(txtCapDevolver.Text.Trim());
                c.interes = Convert.ToDouble(txtInteresPLan.Text);
                c.totalPago = Convert.ToDouble(txtTotalPago.Text);
                c.fechPago = Convert.ToDateTime(dtpFechaPlan.Text);
                c.idConsolidado = txtIdConsolidado.Text.Trim();
                logPlan.Instancia.InsertarPlan(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Plan_Pago c = new Plan_Pago();
                c.idPlan = txtIdPlan.Text.Trim();
                c.mesPlan = Convert.ToInt32(txtMesPlan.Text.Trim());
                c.capitalRemanente = Convert.ToDouble(txtCapRemanente.Text.Trim());
                c.capitalDevolver = Convert.ToDouble(txtCapDevolver.Text.Trim());
                c.interes = Convert.ToDouble(txtInteresPLan.Text);
                c.totalPago = Convert.ToDouble(txtTotalPago.Text);
                c.fechPago = Convert.ToDateTime(dtpFechaPlan.Text);
                c.idConsolidado = txtIdConsolidado.Text.Trim();
                logPlan.Instancia.EditaPlan(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
        }

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPlan.Rows[e.RowIndex];
            txtIdPlan.Text = filaActual.Cells[0].Value.ToString();
            txtMesPlan.Text = filaActual.Cells[1].Value.ToString();
            txtCapRemanente.Text = filaActual.Cells[2].Value.ToString();
            txtCapDevolver.Text = filaActual.Cells[3].Value.ToString();
            txtInteresPLan.Text = filaActual.Cells[4].Value.ToString();
            txtTotalPago.Text = filaActual.Cells[5].Value.ToString();
            dtpFechaPlan.Text = filaActual.Cells[6].Value.ToString();
            txtIdConsolidado.Text = filaActual.Cells[7].Value.ToString();
        }

        private void btnSeleccionarConsolidado_Click(object sender, EventArgs e)
        {
            FrmBuscarConsolidado fp = new FrmBuscarConsolidado();
            AddOwnedForm(fp);
            fp.Show();
        }
    }
}
