using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace entConsolidado
{
    public class Consolidado
    {
        public string idConsolidado { get; set; }
        public int numMes { get; set; }
        public int interes { get; set; }
        public Double devolucionTotal { get; set; }
        public Double interesesTotal { get; set; }
        public Double montoTotal { get; set; }
        public string estConsolidado { get; set; }
        public string idCuenta { get; set; }    
        public string idPrestamo { get; set; }

    }
}
