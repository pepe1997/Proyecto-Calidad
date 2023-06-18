using AccesoDatos.DaoEntidades;
using entCliente;
using entCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logCuenta
    {
        #region singleton
        private static readonly logCuenta UnicaInstancia = new logCuenta();
        public static logCuenta Instancia
        {
            get
            {
                return logCuenta.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<Cuenta> ListarCuenta()
        {
            return datCuenta.Instancia.ListarCuenta();
        }
        public void InsertarCuenta(Cuenta Cu)
        {
            datCuenta.Instancia.InsertarCuenta(Cu);
        }

        public void EditaCuenta(Cuenta Cu)
        {
            datCuenta.Instancia.EditarCuenta(Cu);
        }

        public List<Cuenta> BuscarCuenta(string dato)
        {
            return datCuenta.Instancia.BuscarCuenta(dato);

        }
        public Boolean spActualizarSaldo(string dato, double saldo)
        {
            return datCuenta.Instancia.ActualizarSaldo(dato, saldo);
        }

        public int CalcularNumCuenta()
        {
            return datCuenta.Instancia.CalcularNumCuenta();
        }

    }
    #endregion metodos
}

