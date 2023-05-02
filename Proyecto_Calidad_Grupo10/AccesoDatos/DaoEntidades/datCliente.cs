using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCliente;

namespace AccesoDatos.DaoEntidades
{
    public class datCliente
    {

        #region sigleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Cliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente Cli = new Cliente();
                    Cli.idCliente = dr["idCliente"].ToString();
                    Cli.dniCliente = dr["dniCliente"].ToString();
                    Cli.apellCliente = dr["apellCliente"].ToString();
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.direCliente = dr["direCliente"].ToString();
                    Cli.celCliente = dr["celCliente"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        /////////////////////////InsertaCliente
        public Boolean InsertarCliente(Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@dniCliente", Cli.dniCliente);
                cmd.Parameters.AddWithValue("@apellCliente", Cli.apellCliente);
                cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                cmd.Parameters.AddWithValue("@direCliente", Cli.direCliente);
                cmd.Parameters.AddWithValue("@celCliente", Cli.celCliente);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        //////////////////////////////////EditaCliente
        public Boolean EditarCliente(Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@dniCliente", Cli.dniCliente);
                cmd.Parameters.AddWithValue("@apellCliente", Cli.apellCliente);
                cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                cmd.Parameters.AddWithValue("@direCliente", Cli.direCliente);
                cmd.Parameters.AddWithValue("@celCliente", Cli.celCliente);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCliente

        public Boolean DeshabilitarCliente(Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public List<Cliente> BuscarCliente(string dato)
        {
            SqlCommand cmd = null;
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dniCliente", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente Cli = new Cliente();
                    Cli.idCliente = dr["idCliente"].ToString();
                    Cli.dniCliente = dr["dniCliente"].ToString();
                    Cli.apellCliente = dr["apellCliente"].ToString();
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.direCliente = dr["direCliente"].ToString();
                    Cli.celCliente = dr["celCliente"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);

                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
       

        #endregion metodos
    }
}
