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
        public Boolean VerificarUsuario(string usu)
        {
            return datLogin.Instancia.VerificarUsuario(usu);
        }
        public Boolean ValidarNombres(string n)
        {
            return datLogin.Instancia.ValidarNombres(n);
        }
        public string GenerarLetras(int lon)
        {
            return datLogin.Instancia.GenerarLetrasAleatorias(lon);
        }

        public void DeshabilitarUsuario(Login log)
        {
            datLogin.Instancia.DeshabilitarUsuario(log);
        }
        public void HabilitarUsuario(Login log)
        {
            datLogin.Instancia.HabilitarUsuario(log);
        }
        public void HabilitarUsuarioCel(Login log)
        {
            datLogin.Instancia.HabilitarUsuarioCel(log);
        }
        public void CambiarContra(string usu,string pass)
        {
            datLogin.Instancia.CambiarContra(usu,pass);
        }
        public void CambiarContraCel(string cel, string pass)
        {
            datLogin.Instancia.CambiarContraCel(cel, pass);
        }
        public int EncontrarUsuario(string dato)
        {
            return datLogin.Instancia.EncontrarUsuario(dato);
        }
        public int EncontrarCelular(string dato)
        {
            return datLogin.Instancia.EncontrarCelular(dato);
        }

        public int EncontrarUsuarioDeshabilitado(string dato)
        {
            return datLogin.Instancia.EncontrarUsuarioDeshabilitado(dato);
        }
        public int EncontrarCelularDeshabilitado(string dato)
        {
            return datLogin.Instancia.EncontrarCelularDeshabilitado(dato);
        }


        #endregion metodos
    }
}
