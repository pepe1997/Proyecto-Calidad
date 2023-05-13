using AccesoDatos.DataBase;
using entCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entPlan_Pago;

namespace AccesoDatos.DaoEntidades
{
    public class datPlan
    {
        #region sigleton
        private static readonly datPlan _instancia = new datPlan();
        public static datPlan Instancia
        {
            get
            {
                return datPlan._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Plan_Pago> ListarPlan()
        {
            SqlCommand cmd = null;
            List<Plan_Pago> lista = new List<Plan_Pago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Plan_Pago Plan = new Plan_Pago();
                    Plan.idPlan = Convert.ToInt32(dr["idPlan"].ToString());
                    Plan.mesPlan = Convert.ToInt32(dr["mesPlan"].ToString()) ;
                    Plan.capitalRemanente = Convert.ToDouble(dr["capitalRemanente"].ToString());
                    Plan.capitalDevolver = Convert.ToDouble(dr["capitalDevolver"].ToString());
                    Plan.interes = Convert.ToDouble(dr["interes"].ToString()) ;
                    Plan.totalPago = Convert.ToDouble(dr["totalPago"].ToString());
                    Plan.fechPago = Convert.ToDateTime(dr["fechPago"].ToString());
                    Plan.idConsolidado = dr["idConsolidado"].ToString();
                    lista.Add(Plan);
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
        public Boolean InsertarPlan(Plan_Pago Plan)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mesPlan", Plan.mesPlan);
                cmd.Parameters.AddWithValue("@capitalRemanente", Plan.capitalRemanente);
                cmd.Parameters.AddWithValue("@capitalDevolver", Plan.capitalDevolver);
                cmd.Parameters.AddWithValue("@interes", Plan.interes);
                cmd.Parameters.AddWithValue("@totalPago", Plan.totalPago);
                cmd.Parameters.AddWithValue("@fechPago", Plan.fechPago);
                cmd.Parameters.AddWithValue("@idConsolidado", Plan.idConsolidado);
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

        public Boolean EditarPlan(Plan_Pago Plan)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlan", Plan.idPlan);
                cmd.Parameters.AddWithValue("@mesPlan", Plan.mesPlan);
                cmd.Parameters.AddWithValue("@capitalRemanente", Plan.capitalRemanente);
                cmd.Parameters.AddWithValue("@capitalDevolver", Plan.capitalDevolver);
                cmd.Parameters.AddWithValue("@interes", Plan.interes);
                cmd.Parameters.AddWithValue("@totalPago", Plan.totalPago);
                cmd.Parameters.AddWithValue("@fechPago", Plan.fechPago);
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

        

        public List<Plan_Pago> BuscarPlan(string dato)
        {
            SqlCommand cmd = null;
            List<Plan_Pago> lista = new List<Plan_Pago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarPlan", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPlan", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Plan_Pago Plan = new Plan_Pago();
                    Plan.idPlan = Convert.ToInt32(dr["idPlan"].ToString());
                    Plan.mesPlan = Convert.ToInt32(dr["mesPlan"].ToString());
                    Plan.capitalRemanente = Convert.ToDouble(dr["capitalRemanente"].ToString());
                    Plan.capitalDevolver = Convert.ToDouble(dr["capitalDevolver"].ToString());
                    Plan.interes = Convert.ToDouble(dr["interes"].ToString());
                    Plan.totalPago = Convert.ToDouble(dr["totalPago"].ToString());
                    Plan.fechPago = Convert.ToDateTime(dr["fechPago"].ToString());
                    Plan.idConsolidado = dr["idConsolidado"].ToString();

                    lista.Add(Plan);
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
