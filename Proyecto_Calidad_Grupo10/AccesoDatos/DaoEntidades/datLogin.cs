using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DataBase;
using entLogin;
using System.Text.RegularExpressions;
using entCliente;

namespace AccesoDatos.DaoEntidades
{
    public class datLogin
    {
        #region sigleton
        private static readonly datLogin _instancia = new datLogin();
        public static datLogin Instancia
        {
            get
            {
                return datLogin._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public Boolean InsertarUsuario(Login log)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", log.nombre);
                cmd.Parameters.AddWithValue("@apellido", log.apellido);
                cmd.Parameters.AddWithValue("@celular", log.celular);
                cmd.Parameters.AddWithValue("@usuario", log.usuario);
                cmd.Parameters.AddWithValue("@contra", log.contra);
                cmd.Parameters.AddWithValue("@rol", log.rol);
                
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


        public String VerificaAcceso(Login log)
        {
            SqlCommand cmd = null;
            string rol="";
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spVerificaAcceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", log.usuario);
                cmd.Parameters.AddWithValue("@contra", log.contra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    rol = dr["rol"].ToString();

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return rol;
        }
        public Boolean DeshabilitarUsuario(Login log)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", log.usuario);
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
        public Boolean HabilitarUsuario(Login log)
        {
            SqlCommand cmd = null;
            Boolean activar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", log.usuario);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    activar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return activar;
        }
        public Boolean HabilitarUsuarioCel(Login log)
        {
            SqlCommand cmd = null;
            Boolean activar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarUsuarioCel", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@celular", log.celular);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    activar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return activar;
        }
        public Boolean CambiarContra(string usu, string pass)
        {
            SqlCommand cmd = null;
            Boolean cambiar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCambiarContra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usu);
                cmd.Parameters.AddWithValue("@contra", pass);
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
        public Boolean CambiarContraCel(string cel, string pass)
        {
            SqlCommand cmd = null;
            Boolean cambiar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spCambiarContraCel", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@celular", cel);
                cmd.Parameters.AddWithValue("@contra", pass);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    cambiar = true;
                    Console.WriteLine("se CAMBIO LA CONTRA POR EL CELULAR", i);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return cambiar;
        }
        public int EncontrarUsuario(string dato)
        {
            SqlCommand cmd = null;
            int usu = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spEncontrarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    usu = Convert.ToInt32(dr["usuario"].ToString());
                    Console.WriteLine("El número de meses en el plan de pago es: " + usu);

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
            return usu;


        }
        public int EncontrarCelular(string dato)
        {
            SqlCommand cmd = null;
            int cel = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spEncontrarCelular", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@celular", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cel = Convert.ToInt32(dr["celular"].ToString());
                    Console.WriteLine("El número de meses en el plan de pago es: " + cel);

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
            return cel;


        }

        public int EncontrarUsuarioDeshabilitado(string dato)
        {
            SqlCommand cmd = null;
            int usu = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spEncontrarUsuarioDeshabilitado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    usu = Convert.ToInt32(dr["usuario"].ToString());
                    Console.WriteLine("El número de meses en el plan de pago es: " + usu);

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
            return usu;


        }
        public int EncontrarCelularDeshabilitado(string dato)
        {
            SqlCommand cmd = null;
            int cel = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spEncontrarCelularDeshabilitado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@celular", dato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cel = Convert.ToInt32(dr["celular"].ToString());
                    Console.WriteLine("El número de meses en el plan de pago es: " + cel);

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
            return cel;


        }

        public Boolean ValidarNumeroCelular(string numeroCelular)
        {
            
            string patron = @"^[9]\d{8}$";
            Regex regex = new Regex(patron);
            bool esValido = regex.IsMatch(numeroCelular);

            return esValido;
        }
        /*public Boolean VerificarUsuario1(string usu)
        {
            if ((usu.Length == 7)||(usu.Length < 8))
                return false;

            foreach (char c in usu)
            {
                if ((!usu.Any(char.IsUpper))  && (!usu.Any(char.IsNumber)))
                {
                    return false;
                }
                


            }

            return true;
        }*/
        public Boolean VerificarPassword(string pass)
        {
            if (pass.Length < 8)
            {
                return false;
            }
            if (!pass.Any(char.IsUpper))
            {
                return false;
            }
            if (!pass.Any(char.IsLower))
            {
                return false;
            }   
            if (!pass.Any(char.IsDigit))
            {
                return false;
            }
            if (!pass.Any(IsSpecialCharacter))
            {
                return false;
            }

            return true;
        }

        public Boolean IsSpecialCharacter(char c)
        {
            return !char.IsLetterOrDigit(c);
        }

        public Boolean ValidarNombres(string nombre)
        {
            if (nombre.Length < 2)
                return false;

            foreach (char c in nombre)
            {
                if ((!char.IsLetter(c)) && (c != ' '))
                { 
                    return false;
                }
                    
            }

            return true;
        }
        public Boolean VerificarUsuario(string nombre)
        {
            if ((nombre.Length == 7) || (nombre.Length < 8))
                return false;

            foreach (char c in nombre)
            {
                if ((!char.IsLetter(c)) && (!char.IsDigit(c)))
                {
                    return false;
                }

            }

            return true;
        }
        
        public string GenerarLetrasAleatorias(int longitud)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                char letra = (char)random.Next('A', 'Z' + 1); // Generar letra mayúscula aleatoria
                sb.Append(letra);
            }

            return sb.ToString();
        }

        #endregion metodos
    }
}
