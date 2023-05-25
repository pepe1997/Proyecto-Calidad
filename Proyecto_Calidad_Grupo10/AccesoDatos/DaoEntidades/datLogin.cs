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

        public Boolean ValidarNumeroCelular(string numeroCelular)
        {
            
            string patron = @"^[9]\d{8}$";
            Regex regex = new Regex(patron);
            bool esValido = regex.IsMatch(numeroCelular);

            return esValido;
        }

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
