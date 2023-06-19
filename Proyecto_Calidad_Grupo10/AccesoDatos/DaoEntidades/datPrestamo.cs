using AccesoDatos.DataBase;
using entCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entPrestamo;

namespace AccesoDatos.DaoEntidades
{
    public class datPrestamo
    {
        #region sigleton
        private static readonly datPrestamo _instancia = new datPrestamo();
        public static datPrestamo Instancia
        {
            get
            {
                return datPrestamo._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<Prestamo> ListarPrestamo()
        {
            SqlCommand cmd = null;
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPrestamo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prestamo Pres = new Prestamo();
                    Pres.idPrestamo = dr["idPrestamo"].ToString();
                    Pres.montPrestamo = Convert.ToDouble(dr["montPrestamo"].ToString());
                    Pres.estPrestamo = dr["estPrestamo"].ToString();
                    Pres.idCliente = dr["idCliente"].ToString();
                    lista.Add(Pres);
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
        public List<Prestamo> ListarPrestamoPendiente()
        {
            SqlCommand cmd = null;
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPrestamoPendientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prestamo Pres = new Prestamo();
                    Pres.idPrestamo = dr["idPrestamo"].ToString();
                    Pres.montPrestamo = Convert.ToDouble(dr["montPrestamo"].ToString());
                    Pres.estPrestamo = dr["estPrestamo"].ToString();
                    Pres.idCliente = dr["idCliente"].ToString();
                    lista.Add(Pres);
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
        public Boolean InsertarPrestamo(Prestamo Pres)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPrestamo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPrestamo", Pres.idPrestamo);
                cmd.Parameters.AddWithValue("@montPrestamo", Pres.montPrestamo);
                cmd.Parameters.AddWithValue("@estPrestamo", Pres.estPrestamo);
                cmd.Parameters.AddWithValue("@idCliente", Pres.idCliente);
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
        public Boolean EditarPrestamo(Prestamo Pres)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPrestamo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPrestamo", Pres.idPrestamo);
                cmd.Parameters.AddWithValue("@montPrestamo", Pres.montPrestamo);
                cmd.Parameters.AddWithValue("@estPrestamo", Pres.estPrestamo);
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

        public List<Prestamo> BuscarPrestamo(string dato)
        {
            SqlCommand cmd = null;
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarPrestamo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPrestamo", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prestamo Pres = new Prestamo();
                    Pres.idPrestamo = dr["idPrestamo"].ToString();
                    Pres.montPrestamo = Convert.ToDouble(dr["montPrestamo"].ToString());
                    Pres.estPrestamo = dr["estPrestamo"].ToString();
                    Pres.idCliente = dr["idCliente"].ToString();
                    lista.Add(Pres);
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
        public List<Prestamo> BuscarPrestamoPendiente(string dato)
        {
            SqlCommand cmd = null;
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarPrestamoPendientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPrestamo", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prestamo Pres = new Prestamo();
                    Pres.idPrestamo = dr["idPrestamo"].ToString();
                    Pres.montPrestamo = Convert.ToDouble(dr["montPrestamo"].ToString());
                    Pres.estPrestamo = dr["estPrestamo"].ToString();
                    Pres.idCliente = dr["idCliente"].ToString();
                    lista.Add(Pres);
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

        public Boolean CambiarEsatdoAprobado(Prestamo Pres)
        {
            SqlCommand cmd = null;
            Boolean cambiar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCambiarPrestamoAprobado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPrestamo", Pres.idPrestamo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    cambiar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return cambiar;
        }

        public Boolean CambiarEsatdoDenegado(Prestamo Pres)
        {
            SqlCommand cmd = null;
            Boolean cambiar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCambiarPrestamoDenegado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPrestamo", Pres.idPrestamo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    cambiar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return cambiar;
        }

        public int CalcularNumPrestamo()
        {
            SqlCommand cmd = null;
            int numPres = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spCalcularNumPrestamo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    numPres = Convert.ToInt32(dr["numPrestamo"].ToString());
                    Console.WriteLine("El número de meses en el plan de pago es: " + numPres);

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
            return numPres;


        }


        #endregion metodos
    }
}
