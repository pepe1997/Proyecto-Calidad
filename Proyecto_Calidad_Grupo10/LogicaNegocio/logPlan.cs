using AccesoDatos.DaoEntidades;
using entCliente;
using entPlan_Pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class logPlan
    {
        #region singleton
        private static readonly logPlan UnicaInstancia = new logPlan();
        public static logPlan Instancia
        {
            get
            {
                return logPlan.UnicaInstancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<Plan_Pago> ListarPlan()
        {
            return datPlan.Instancia.ListarPlan();
        }
        public void InsertarPlan(Plan_Pago Plan)
        {
            datPlan.Instancia.InsertarPlan(Plan);
        }

        public void EditaPlan(Plan_Pago Plan)
        {
            datPlan.Instancia.EditarPlan(Plan);
        }

        public List<Plan_Pago> BuscarPlan(string dato)
        {
            return datPlan.Instancia.BuscarPlan(dato);

        }
        
    }
    #endregion metodos
}

