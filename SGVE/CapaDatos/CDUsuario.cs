using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDUsuario
    {
        private int dIdUsuario;
        private string dNombre, dApellido, dUsuario, dContraseña, dRol, dEmail, dEstado;
        private DateTime dFechaRegistro;
        private DateTime dUltimoAcceso;

        public CDUsuario()
        {
        }

        public CDUsuario(int pIdUsuario, string pNombre, string pApellido, string pUsuario,
            string pContraseña, string pRol, string pEmail,
            DateTime pFechaRegistro, DateTime pUltimoAcceso, string pEstado)
        {
            this.dIdUsuario = pIdUsuario;
            this.dNombre = pNombre;
            this.dApellido = pApellido;
            this.dUsuario = pUsuario;
            this.dContraseña = pContraseña;
            this.dRol = pRol;
            this.dEmail = pEmail;
            this.dFechaRegistro = pFechaRegistro;
            this.dUltimoAcceso = pUltimoAcceso;
            this.dEstado = pEstado;
        }

        #region metodos get y set
        public int IdUsuario
        {
            get { return dIdUsuario; }
            set { dIdUsuario = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }
        public string Usuario
        {
            get { return dUsuario; }
            set { dUsuario = value; }
        }
        public string Contraseña
        {
            get { return dContraseña; }
            set { dContraseña = value; }
        }
        public string Rol
        {
            get { return dRol; }
            set { dRol = value; }
        }
        public string Email
        {
            get { return dEmail; }
            set { dEmail = value; }
        }

        public DateTime FechaRegistro
        {
            get { return dFechaRegistro; }
            set { dFechaRegistro = value; }
        }

        public DateTime UltimoAcceso
        {
            get { return dUltimoAcceso; }
            set { dUltimoAcceso = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDUsuario objUsuario)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCommand micomando = new SqlCommand("UsuarioInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pNombre", objUsuario.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objUsuario.Apellido);
                micomando.Parameters.AddWithValue("@pUsuario", objUsuario.Usuario);
                micomando.Parameters.AddWithValue("@pContraseña", objUsuario.Contraseña);
                micomando.Parameters.AddWithValue("@pRol", objUsuario.Rol);
                micomando.Parameters.AddWithValue("@pEmail", objUsuario.Email);
                micomando.Parameters.AddWithValue("@pFechaRegistro", objUsuario.FechaRegistro);
                micomando.Parameters.AddWithValue("@pUltimoAcceso", objUsuario.UltimoAcceso);
                micomando.Parameters.AddWithValue("@pEstado", objUsuario.Estado);
                micomando.ExecuteNonQuery();

                mensaje = "OK";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return mensaje;
        }

        public string Actualizar(CDUsuario objUsuario)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCommand micomando = new SqlCommand("UsuarioActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdUsuario", objUsuario.IdUsuario);
                micomando.Parameters.AddWithValue("@pNombre", objUsuario.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objUsuario.Apellido);
                micomando.Parameters.AddWithValue("@pUsuario", objUsuario.Usuario);
                micomando.Parameters.AddWithValue("@pContraseña", objUsuario.Contraseña);
                micomando.Parameters.AddWithValue("@pRol", objUsuario.Rol);
                micomando.Parameters.AddWithValue("@pEmail", objUsuario.Email);
                micomando.Parameters.AddWithValue("@pFechaRegistro", objUsuario.FechaRegistro);
                micomando.Parameters.AddWithValue("@pUltimoAcceso", objUsuario.UltimoAcceso);
                micomando.Parameters.AddWithValue("@pEstado", objUsuario.Estado);

                micomando.ExecuteNonQuery();

                mensaje = "OK";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return mensaje;
        }

        public DataTable UsuarioConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlcomando = new SqlCommand();
                sqlcomando.Connection = new SqlConnection(CDDBConexion1.miconexion);
                sqlcomando.Connection.Open();
                sqlcomando.CommandText = "UsuarioConsultar";
                sqlcomando.CommandType = CommandType.StoredProcedure;
                sqlcomando.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlcomando.ExecuteReader();
                dt.Load(leerDatos);
                sqlcomando.Connection.Close();
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }

        public DataTable Login(string usuario, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlcomando = new SqlCommand();
                sqlcomando.Connection = new SqlConnection(CDDBConexion1.miconexion);
                sqlcomando.Connection.Open();
                sqlcomando.CommandText = "UsuarioLogin";
                sqlcomando.CommandType = CommandType.StoredProcedure;
                sqlcomando.Parameters.AddWithValue("@pUsuario", usuario);
                sqlcomando.Parameters.AddWithValue("@pContraseña", password);

                SqlDataReader leerDatos = sqlcomando.ExecuteReader();
                dt.Load(leerDatos);

                sqlcomando.Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error de SQL: " + ex.Message);
            }
            return dt;
        }
    }
}