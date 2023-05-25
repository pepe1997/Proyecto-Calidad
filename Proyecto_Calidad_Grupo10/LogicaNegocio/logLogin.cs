using AccesoDatos.DaoEntidades;
using entCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entLogin;
using System.Runtime.ConstrainedExecution;
using entCliente;

namespace LogicaNegocio
{
    public class logLogin
    {
        #region singleton
        private static readonly logLogin UnicaInstancia = new logLogin();
        public static logLogin Instancia
        {
            get
            {
                return logLogin.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos

        public String VerificaAcceso(Login log)
        {
           
            return datLogin.Instancia.VerificaAcceso(log);

        }
        public void InsertarUsuario(Login log)
        {
            datLogin.Instancia.InsertarUsuario(log);
        }
        public Boolean VerificarCelular(string num)
        {
            return datLogin.Instancia.ValidarNumeroCelular(num);
        }
        public Boolean VerificarPassword(string pass)
        {
            return datLogin.Instancia.VerificarPassword(pass);
        }
        public Boolean ValidarNombres(string n)
        {
            return datLogin.Instancia.ValidarNombres(n);
        }
        public string GenerarLetras(int lon)
        {
            return datLogin.Instancia.GenerarLetrasAleatorias(lon);
        }

        #endregion metodos
    }
}
