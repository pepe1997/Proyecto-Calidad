using AccesoDatos.DaoEntidades;
using entCliente;
using entConsolidado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logConsolidado
    {
        #region singleton
        private static readonly logConsolidado UnicaInstancia = new logConsolidado();
        public static logConsolidado Instancia
        {
            get
            {
                return logConsolidado.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<Consolidado> ListarConsolidado()
        {
            return datConsolidado.Instancia.ListarConsolidado();
        }
        public void InsertarConsolidado(Consolidado Con)
        {
            datConsolidado.Instancia.InsertarConsolidado(Con);
        }

        public void EditaConsolidado(Consolidado Con)
        {
            datConsolidado.Instancia.EditarConsolidado(Con);
        }

        public List<Consolidado> BuscarConsolidado(string dato)
        {
            return datConsolidado.Instancia.BuscarConsolidado(dato);

        }
        public Boolean ActualizarDevTotal(string dato,double capDev)
        {  
           return datConsolidado.Instancia.ActualizarDevTotal(dato, capDev);  
        }
        public Boolean ActualizarIntTotal(string dato, double capDev)
        {
            return datConsolidado.Instancia.ActualizarIntTotal(dato, capDev);
        }
        public Boolean spActualizarMontTotal(string dato, double capDev)
        {
            return datConsolidado.Instancia.ActualizarMontTotal(dato, capDev);
        }
    }
    #endregion metodos
}

