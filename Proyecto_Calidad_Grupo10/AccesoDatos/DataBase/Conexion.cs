using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DataBase
{
    public class Conexion
    {

        private static readonly Conexion instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion.instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-AB7LPA7;Initial Catalog = Banco;" + "Integrated Security = true";
            Console.WriteLine("Se extablecio conexion");
            Console.ReadLine();
            return cn;
        }
    }
}
