using AccesoDatos.DataBase;
using entCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entTipo_Cuenta;

namespace AccesoDatos.DaoEntidades
{
    public class datTipo_Cuenta
    {
        #region sigleton
        private static readonly datTipo_Cuenta _instancia = new datTipo_Cuenta();
        public static datTipo_Cuenta Instancia
        {
            get
            {
                return datTipo_Cuenta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Tipo_Cuenta> ListarTipo()
        {
            SqlCommand cmd = null;
            List<Tipo_Cuenta> lista = new List<Tipo_Cuenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaTipo_Cuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Tipo_Cuenta Tip = new Tipo_Cuenta();
                    Tip.idTipo = dr["idTipo"].ToString();
                    Tip.nombTipo = dr["nombTipo"].ToString();
                    lista.Add(Tip);
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
        /////////////////////////InsertaTipo
        public Boolean InsertarTipo(Tipo_Cuenta Tip)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipo_Cuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipo", Tip.idTipo);
                cmd.Parameters.AddWithValue("@nombTipo", Tip.nombTipo);
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


        //////////////////////////////////EditaCTipo
        public Boolean EditarCliente(Tipo_Cuenta Tip)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaTipo_Cuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipo", Tip.idTipo);
                cmd.Parameters.AddWithValue("@nombTipo", Tip.nombTipo);
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


        public List<Tipo_Cuenta> BuscarTipo(string dato)
        {
            SqlCommand cmd = null;
            List<Tipo_Cuenta> lista = new List<Tipo_Cuenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarTipo_Cuenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idTipo", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Tipo_Cuenta Tip = new Tipo_Cuenta();
                    Tip.idTipo = dr["idTipo"].ToString();
                    Tip.nombTipo = dr["nombTipo"].ToString();

                    lista.Add(Tip);
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
