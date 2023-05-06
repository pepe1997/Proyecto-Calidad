using AccesoDatos.DaoEntidades;
using entCliente;
using entPrestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logPrestamo
    {
        #region singleton
        private static readonly logPrestamo UnicaInstancia = new logPrestamo();
        public static logPrestamo Instancia
        {
            get
            {
                return logPrestamo.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<Prestamo> ListarPrestamo()
        {
            return datPrestamo.Instancia.ListarPrestamo();

        }
        public List<Prestamo> ListarPrestamoPendientes()
        {
            return datPrestamo.Instancia.ListarPrestamoPendiente();

        }
        public void InsertarPrestamo(Prestamo Pres)
        {
            datPrestamo.Instancia.InsertarPrestamo(Pres);
        }

        public void EditaPrestamo(Prestamo Pres)
        {
            datPrestamo.Instancia.EditarPrestamo(Pres);
        }

        public List<Prestamo> BuscarPrestamo(string dato)
        {
            return datPrestamo.Instancia.BuscarPrestamo(dato);

        }
        public void CambiarAprobado(Prestamo Pres)
        {
            datPrestamo.Instancia.CambiarEsatdoAprobado(Pres);
        }
        public void CambiarDenegado(Prestamo Pres)
        {
            datPrestamo.Instancia.CambiarEsatdoDenegado(Pres);
        }

    }
    #endregion metodos
}

