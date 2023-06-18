using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entCuenta;
using entLogin;
using LogicaNegocio;
using Sistema_Prestamos.Mantendedor;

namespace Sistema_Prestamos.Principal
{
    public partial class FrmLogin : Form
    {
        int i = 0;
        public FrmLogin()
        {
            InitializeComponent();
            txtCaptcha.Text = logLogin.Instancia.GenerarLetras(10);
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();
            log.usuario = txtUsuario.Text.Trim();
            log.contra = txtContra.Text.Trim();
            String v = logLogin.Instancia.VerificaAcceso(log);
            String cap = txtCaptcha.Text.Trim();
            if (lbUsuario.Text == "Incorrecto")
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("No te encuntras registrado", "Advertencia",
                    botones, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    MessageBoxButtons bot = MessageBoxButtons.OKCancel;
                    DialogResult d = MessageBox.Show("Deseas Registarte", "Sugerencia",
                        bot, MessageBoxIcon.Warning);
                    if (d == DialogResult.OK)
                    {
                        
                        FrmRegistro r = new FrmRegistro();
                        r.Show();
                        this.Hide();
                        
                    }
                }
            }

            else if((i == 3)&&(lbUsuario.Text=="Correcto"))
            {
                string u = txtUsuario.Text.Trim();
                Login l = new Login();
                l.usuario = u;
                logLogin.Instancia.DeshabilitarUsuario(l);
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("Exediste el numero de intentos y su cuenta se suspendio", "Advertencia",
                    botones, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    MessageBoxButtons bot = MessageBoxButtons.OKCancel;
                    DialogResult d = MessageBox.Show("Deseas Recuperar tu Cuenta", "Sugerencia",
                        bot, MessageBoxIcon.Warning);
                    if (d == DialogResult.OK)
                    {
            
                        FrmRecuperarCuenta r = new FrmRecuperarCuenta();
                        r.Show();
                        this.Hide();
                    }
                }
            }
            else if ((txtUsuario.Text == "") || (txtContra.Text == "")||(txtVerificarCaptcha.Text==""))
            {
                MessageBox.Show("Falta rellenar un campo");
            }
            else if (lbUsuario.Text == "Suspendido")
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("Exediste el numero de intentos y su cuenta se suspendio", "Advertencia",
                    botones, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    MessageBoxButtons bot = MessageBoxButtons.OKCancel;
                    DialogResult d = MessageBox.Show("Deseas Recuperar tu Cuenta", "Sugerencia",
                        bot, MessageBoxIcon.Warning);
                    if (d == DialogResult.OK)
                    {
                       
                        FrmRecuperarCuenta r = new FrmRecuperarCuenta();
                        r.Show();
                        this.Hide();
                    }
                }
            }
            else
            {

                if ((v == "") && (i<3))
                {
                    i++;
                    MessageBox.Show("Le quedan " + (3 - i) + " intentos restantes");
                }
                if ((v == "Administrador") && (txtVerificarCaptcha.Text == cap))
                {
                    
                    FrmPrincipal f = new FrmPrincipal();
                    f.Show();
                    this.Hide();
                }
                if ((v == "Empleado") && (txtVerificarCaptcha.Text == cap))
                {
                    
                    FrmConsolidado c = new FrmConsolidado();
                    c.Show();
                    this.Hide();

                }
               
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Estas seguro(a)", "Salir",
                botones, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
                FrmRegistro f = new FrmRegistro();
                f.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Estas seguro de salir", "Salir",
                botones, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("En la máxima medida permitida por la ley aplicable, [el propietario la página web] " +
                "no asume responsabilidad alguna por (i) errores, errores o inexactitudes de contenido; (ii) " +
                "lesiones personales o daños a la propiedad, de cualquier naturaleza que sean, como resultado de" +
                " tu acceso o uso de nuestro servicio; y (iii) cualquier acceso no autorizado o uso de nuestros" +
                " servidores seguros y / o toda la información personal almacenada en los mismos.");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FrmRecuperarCuenta f = new FrmRecuperarCuenta();
            f.Show();
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            string usu = txtUsuario.Text.ToLower().Trim();
            int v = logLogin.Instancia.EncontrarUsuario(usu);
            int v1 = logLogin.Instancia.EncontrarUsuarioDeshabilitado(usu);
            if (v > 0)
            {
                lbUsuario.ForeColor = Color.Green;
                lbUsuario.Text = "Correcto";
                lbUsuario.Visible = true;
            }else if (v1>0)
            {
                lbUsuario.ForeColor = Color.Red;
                lbUsuario.Text = "Suspendido";
                lbUsuario.Visible = true;
            }
            else
            {
                lbUsuario.ForeColor = Color.Red;
                lbUsuario.Text = "Incorrecto";
                lbUsuario.Visible = true;
            }
        }

        private void txtVerificarCaptcha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
