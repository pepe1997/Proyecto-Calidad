using AccesoDatos.DataBase;
using entCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entConsolidado;

namespace AccesoDatos.DaoEntidades
{
    public class datConsolidado
    {
        #region sigleton
        private static readonly datConsolidado _instancia = new datConsolidado();
        public static datConsolidado Instancia
        {
            get
            {
                return datConsolidado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Consolidado> ListarConsolidado()
        {
            SqlCommand cmd = null;
            List<Consolidado> lista = new List<Consolidado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaConsolidado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Consolidado Con = new Consolidado();
                    Con.idConsolidado = dr["idConsolidado"].ToString();
                    Con.numMes = Convert.ToInt32(dr["numMes"].ToString());
                    Con.detConsolidado = dr["detConsolidado"].ToString();
                    Con.interes = Convert.ToInt32(dr["interes"].ToString());
                    Con.idCuenta = dr["idCuenta"].ToString();
                    Con.idPrestamo = dr["idPrestamo"].ToString();
                    lista.Add(Con);
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
        public Boolean InsertarConsolidado(Consolidado Con)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarConsolidado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idConsolidado", Con.idConsolidado);
                cmd.Parameters.AddWithValue("@numMes", Con.numMes);
                cmd.Parameters.AddWithValue("@detConsolidado", Con.detConsolidado);
                cmd.Parameters.AddWithValue("@interes", Con.interes);
                cmd.Parameters.AddWithValue("@idCuenta", Con.idCuenta);
                cmd.Parameters.AddWithValue("@idPrestamo", Con.idPrestamo);
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
        public Boolean EditarConsolidado(Consolidado Con)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaConsolidado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idConsolidado", Con.idConsolidado);
                cmd.Parameters.AddWithValue("@numMes", Con.numMes);
                cmd.Parameters.AddWithValue("@detConsolidado", Con.detConsolidado);
                cmd.Parameters.AddWithValue("@interes", Con.interes);
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

        public List<Consolidado> BuscarConsolidado(string dato)
        {
            SqlCommand cmd = null;
            List<Consolidado> lista = new List<Consolidado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarConsolidado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idConsolidado", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Consolidado Con = new Consolidado();
                    Con.idConsolidado = dr["idConsolidado"].ToString();
                    Con.numMes = Convert.ToInt32(dr["numMes"].ToString());
                    Con.detConsolidado = dr["detConsolidado"].ToString();
                    Con.interes = Convert.ToInt32(dr["interes"].ToString());
                    Con.idCuenta = dr["idCuenta"].ToString();
                    Con.idPrestamo = dr["idPrestamo"].ToString();

                    lista.Add(Con);
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
