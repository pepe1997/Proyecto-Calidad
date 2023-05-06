using AccesoDatos.DaoEntidades;
using System;
using System.Collections.Generic;
using entTipo_Cuenta;

namespace LogicaNegocio
{
    public class logTipo_Cuenta
    {
        #region singleton
        private static readonly logTipo_Cuenta UnicaInstancia = new logTipo_Cuenta();
        public static logTipo_Cuenta Instancia
        {
            get
            {
                return logTipo_Cuenta.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<Tipo_Cuenta> ListarTipo()
        {
            return datTipo_Cuenta.Instancia.ListarTipo();

        }
        public void InsertarTipo(Tipo_Cuenta Tip)
        {
            datTipo_Cuenta.Instancia.InsertarTipo(Tip);
        }

        public void EditaTipo(Tipo_Cuenta Tip)
        {
            datTipo_Cuenta.Instancia.EditarTipo(Tip);
        }

        public List<Tipo_Cuenta> BuscarTipo(string dato)
        {
            return datTipo_Cuenta.Instancia.BuscarTipo(dato);

        }
        
    }
    #endregion metodos
}
