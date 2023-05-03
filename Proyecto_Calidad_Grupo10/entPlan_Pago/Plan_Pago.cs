using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entPlan_Pago
{
    public class Plan_Pago
    {
        public string idPlan { get; set; }
        public string mesPlan { get; set; }
        public Double capitalRemanente { get; set; }    
        public Double capitalDevolver { get; set; }
        public Double interes { get; set; }
        public Double totalPago { get; set; }
        public DateTime fechPago { get; set; }
        public string idConsolidado { get; set; }   


    }
}
