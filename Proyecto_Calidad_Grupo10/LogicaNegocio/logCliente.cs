using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCliente;
using AccesoDatos.DaoEntidades;

namespace LogicaNegocio
{
    public class logCliente
    {
        #region singleton
        private static readonly logCliente UnicaInstancia = new logCliente();
        public static logCliente Instancia
        {
            get
            {
                return logCliente.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<Cliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        public void InsertarCliente(Cliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }

        public void EditaCliente(Cliente Clie)
        {
            datCliente.Instancia.EditarCliente(Clie);
        }

        public List<Cliente> BuscarCliente(string dato)
        {
            return datCliente.Instancia.BuscarCliente(dato);

        }
        public void DeshabilitarCliente(Cliente c)
        {
            datCliente.Instancia.DeshabilitarCliente(c);
        }
    }
    #endregion metodos
}

