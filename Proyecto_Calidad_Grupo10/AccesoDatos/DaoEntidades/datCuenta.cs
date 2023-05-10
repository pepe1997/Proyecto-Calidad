using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCuenta;
using AccesoDatos.DataBase;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos.DaoEntidades
{
    public class datCuenta
    {
        #region sigleton
        private static readonly datCuenta _instancia = new datCuenta();
        public static datCuenta Instancia
        {
            get
            {
                return datCuenta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Cuenta> ListarCuenta()
        {
            SqlCommand cmd = null;
            List<Cuenta> lista = new List<Cuenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cuenta Cue = new Cuenta();
                    Cue.idCuenta = dr["idCuenta"].ToString();
                    Cue.nroCuenta = dr["nroCuenta"].ToString();
                    Cue.salCuenta = Convert.ToDouble(dr["salCuenta"]);
                    Cue.fechCreacion= Convert.ToDateTime(dr["fechCreacion"].ToString());
                    Cue.idCliente = dr["idCliente"].ToString() ;
                    Cue.idTipo = dr["idTipo"].ToString();

                    lista.Add(Cue);
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

        public Boolean InsertarCuenta(Cuenta Cue)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCuenta", Cue.idCuenta);
                cmd.Parameters.AddWithValue("@nroCuenta", Cue.nroCuenta);
                cmd.Parameters.AddWithValue("@salCuenta", Cue.salCuenta);
                cmd.Parameters.AddWithValue("@fechCreacion", Cue.fechCreacion);
                cmd.Parameters.AddWithValue("@idCliente", Cue.idCliente);
                cmd.Parameters.AddWithValue("@idTipo", Cue.idTipo);
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

        public Boolean EditarCuenta(Cuenta Cue)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCuenta", Cue.idCuenta);
                cmd.Parameters.AddWithValue("@nroCuenta", Cue.nroCuenta);
                cmd.Parameters.AddWithValue("@salCuenta", Cue.salCuenta);
                cmd.Parameters.AddWithValue("@fechCreacion", Cue.fechCreacion);
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

        public List<Cuenta> BuscarCuenta(string dato)
        {
            SqlCommand cmd = null;
            List<Cuenta> lista = new List<Cuenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarCuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cuenta Cue = new Cuenta();
                    Cue.idCuenta = dr["idCuenta"].ToString();
                    Cue.nroCuenta = dr["nroCuenta"].ToString();
                    Cue.salCuenta = Convert.ToDouble(dr["salCuenta"]);
                    Cue.fechCreacion = Convert.ToDateTime(dr["fechCreacion"].ToString());
                    Cue.idCliente = dr["idCliente"].ToString();
                    Cue.idTipo = dr["idTipo"].ToString();

                    lista.Add(Cue);
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
