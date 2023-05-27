using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entLogin
{
    public class Login
    {
        public int idLogin {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string celular { get; set; }
        public string usuario { get; set; }
        public string contra { get; set; }
        public string rol { get; set;}
        public string estado { get; set; }

        public Login()
        {
            usuario = string.Empty;
            contra = string.Empty;
        }
    }
}
