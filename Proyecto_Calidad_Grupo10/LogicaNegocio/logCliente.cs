﻿using System;
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
            try
            {
                List<Cliente> listaCliente = datCliente.Instancia.ListarCliente();
                return listaCliente;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public Boolean InsertarCliente(Cliente Cli)
        {
            try
            {
                return datCliente.Instancia.InsertarCliente(Cli);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean EditaCliente(Cliente Clie)
        {
            try
            {
                return datCliente.Instancia.EditarCliente(Clie);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Cliente> BuscarCliente(string dato)
        {
            return datCliente.Instancia.BuscarCliente(dato);

        }
        public Boolean DeshabilitarCliente(Cliente c)
        {
            try
            {
                return datCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    #endregion metodos
}

