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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_Prestamos.Transaccion
{
    public partial class FrmPlan_Pago : Form
    {
        public FrmPlan_Pago()
        {
            InitializeComponent();
        }
        private void FrmPlan_Pago_Load(object sender, EventArgs e)
        {

        }
        public void listarPlan()
        {
            string dato= txtIdConsolidado.Text.ToString();
            dgvPlan.DataSource = logPlan.Instancia.BuscarPlan(dato);
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
            txtIdCuenta.Text = "";
            txtSaldoCuenta.Text = "";
            txtIdConsolidado.Focus();
        }
        private void AgregarPlan()
        {
            try
            {
                Plan_Pago c = new Plan_Pago();
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
            listarPlan();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPlan();    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCapDevolver.Enabled = true;
            txtInteresPLan.Enabled = true;
            
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

        private void txtMesPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdConsolidado_TextChanged(object sender, EventArgs e)
        {
            
                string dato = txtIdConsolidado.Text.Trim(); // se obtiene el valor de una celda 
                dgvPlan.DataSource = logPlan.Instancia.BuscarPlan(dato);
   
        }
        private void CalcularMes()
        {
            string dato = Convert.ToString(txtIdConsolidado.Text.Trim());
            int mes = logPlan.Instancia.CalcularMes(dato);
            mes = mes + 1;
            txtMesPlan.Text = Convert.ToString(mes);
        }
       
        
       
        private void CalcularTotalPago()
        {
            Double CapD = Convert.ToDouble(txtCapDevolver.Text.Trim());
            Double Inte = Convert.ToDouble(txtInteresPLan.Text.Trim());
            Double total = CapD + Inte;
            txtTotalPago.Text = total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CalcularMes();
            int mesPlan = Convert.ToInt32(txtMesPlan.Text);
            int mesAnt = mesPlan - 1;

            // Creamos unas variables que nos ayudaran a hacer operacion es mas facil
            Double capital = 0;
            Double CapRem = 0;
            Double CapDev = 0;
            Double Inte = 0;

            int mesCon = Convert.ToInt32(txtMesConsolidado.Text.Trim());

            capital = Convert.ToDouble(txtMontoPrestamo.Text.Trim());
            CapDev = capital / mesCon;

            if (mesPlan == 1)
            {
                txtCapRemanente.Text = capital.ToString();
                txtCapDevolver.Text = CapDev.ToString();
                CapRem = Convert.ToDouble(txtCapRemanente.Text.Trim());
                Inte = CapRem * 0.1;
                txtInteresPLan.Text = Inte.ToString("N2");
                CalcularTotalPago();
            }
            else
            {
                string idCon = txtIdConsolidado.Text.Trim();
                Double OCapRem = logPlan.Instancia.ObtenerCapRemanente(idCon, mesAnt);
                Double ResCapDev = logPlan.Instancia.ObtenerCapDevolver(idCon, mesAnt);
                Double ResInt = logPlan.Instancia.ObtenerInteres(idCon, mesAnt);

                ResInt = (OCapRem * 0.1) - ResInt;
                CapRem = OCapRem - ResCapDev + ResInt;
                ResCapDev = ResCapDev - (capital/mesCon);
                txtCapRemanente.Text = CapRem.ToString();
                if ((ResCapDev == 0) || ((capital/mesCon)==ResCapDev))
                {
                    txtCapDevolver.Text = (capital/mesCon).ToString(); 
                }
                else
                {
                    CapDev = (capital / mesCon) + ResCapDev;
                    txtCapDevolver.Text = CapDev.ToString();
                }

                Inte = CapRem * 0.1;
                txtInteresPLan.Text = Inte.ToString();
                CalcularTotalPago();
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbPlan.Enabled = false;
            
        }
    }
}
