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
            gbConsolidado.Enabled = false;
        }
        private void FrmPlan_Pago_Load(object sender, EventArgs e)
        {

        }
        private Double CalcularTotalCapDevolver()
        {
            string idConsolidado = txtIdConsolidado.Text.Trim();
            return logPlan.Instancia.CalcularTotalCapDevolver(idConsolidado);
        }
        private Double CalcularTotalInteres()
        {
            string idConsolidado = txtIdConsolidado.Text;
            return logPlan.Instancia.CalcularTotalInteres(idConsolidado);
        }
        private Double CalcularTotalPagoPlan()
        {
            string idConsolidado = txtIdConsolidado.Text;
            return logPlan.Instancia.CalcularTotalPago(idConsolidado);
        }
        private void ActulizarTotalCapDevolver()
        {
            string idCon = txtIdConsolidado.Text;
            Double CapDev = CalcularTotalCapDevolver();
            Boolean v = logConsolidado.Instancia.ActualizarDevTotal(idCon,CapDev);
            if (v == true)
            {
                Console.WriteLine("Se actualizo");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
        }
        private void ActulizarTotalInteres()
        {
            string idCon = txtIdConsolidado.Text;
            Double Inte = CalcularTotalInteres();
            Boolean v = logConsolidado.Instancia.ActualizarIntTotal(idCon, Inte);
            if (v == true)
            {
                Console.WriteLine("Se actualizo");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
        }
        private void ActulizarTotalPago()
        {
            string idCon = txtIdConsolidado.Text;
            Double Pago = CalcularTotalPagoPlan();
            Boolean v = logConsolidado.Instancia.spActualizarMontTotal(idCon, Pago);
            if (v == true)
            {
                Console.WriteLine("Se actualizo");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
        }
        private void Actualizarsaldo()
        {
            try
            {
                string idCuenta = txtIdCuenta.Text;
                Double saldo = Convert.ToDouble(txtTotalPago.Text.Trim());
                Boolean v = logCuenta.Instancia.spActualizarSaldo(idCuenta, saldo);
                if (v == true)
                {
                    Console.WriteLine("Se actualizo");
                }
                else
                {
                    Console.WriteLine("Ocurrio un error");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            Double saldo = Convert.ToDouble(txtSaldoCuenta.Text.Trim());    
            Double monTo = Convert.ToDouble(txtTotalPago.Text.Trim());
            string idCu = txtIdCuenta.Text.Trim();
            if (saldo < monTo)
            {
                MessageBox.Show("No tiene saldo suficiente");
            }
            else
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
                ActulizarTotalCapDevolver();
                ActulizarTotalInteres();
                ActulizarTotalPago();
                Actualizarsaldo();
                logCuenta.Instancia.spActualizarSaldo(idCu, monTo);
                LimpiarVariables();

            }
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPlan();
            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCapDevolver.Enabled = true;
            txtInteresPLan.Enabled = true;
            CalcularTotalPago();
            
            
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
            try
            {
                Double CapD = Convert.ToDouble(txtCapDevolver.Text.Trim());
                Double Inte = Convert.ToDouble(txtInteresPLan.Text.Trim());
                Double total = CapD + Inte;
                txtTotalPago.Text = total.ToString("N2");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;
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

            string dato = Convert.ToString(txtIdConsolidado.Text.Trim());
            int mes = logPlan.Instancia.CalcularMes(dato);
            
            if (mesCon==mes)
            {
                MessageBox.Show("Ya cumplio con todos los pagos");
            }
            else
            {
                if (mesPlan == 1)
                {
                    txtCapRemanente.Text = capital.ToString();
                    txtCapDevolver.Text = CapDev.ToString("N2");
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
                    txtCapRemanente.Text = CapRem.ToString("N2");
                    for (int i = 2; i <= mesPlan; i++)
                    {
                        if (i == mesPlan)
                        {
                            double capiDev = capital / mesCon;
                            double m = mesPlan - 1;
                            double cDevAnt = capiDev * m;
                            //double cDevAct = capiDev * i;
                            double sumCapDev = CalcularTotalCapDevolver();
                            if (sumCapDev == cDevAnt)
                            {
                                txtCapDevolver.Text = capiDev.ToString("N2");
                            }
                            else
                            {
                                double x = cDevAnt - sumCapDev;
                                x = capiDev + x;
                                txtCapDevolver.Text= x.ToString("N2");
                            }
                            
                        }
                            
                    }


                    Inte = CapRem * 0.1;
                    txtInteresPLan.Text = Inte.ToString("N2");
                    CalcularTotalPago();
                }
                
            }
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            



        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbPlan.Enabled = false;
            
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCapDevolver_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtInteresPLan_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
