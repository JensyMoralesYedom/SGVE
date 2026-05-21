using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDEmpresa
    {
        private int dIdEmpresa;
        private int dIdUsuarioRegistro;   
        private string dNombre, dDireccion, dTelefono, dEmail, dRNC, dLogo, dEstado;
        private DateTime dFechaRegistro;  

        public CDEmpresa()
        {
        }

        public CDEmpresa(int pIdEmpresa, string pNombre, string pRNC, string pDireccion,
            string pTelefono, string pEmail, string pLogo, DateTime pFechaRegistro,
            int pIdUsuarioRegistro, string pEstado)
        {
            this.dIdEmpresa = pIdEmpresa;
            this.dNombre = pNombre;
            this.dRNC = pRNC;
            this.dDireccion = pDireccion;
            this.dTelefono = pTelefono;
            this.dEmail = pEmail;
            this.dLogo = pLogo;
            this.dFechaRegistro = pFechaRegistro;
            this.dIdUsuarioRegistro = pIdUsuarioRegistro;
            this.dEstado = pEstado;
        }

        #region metodos get y set
        public int IdEmpresa
        {
            get { return dIdEmpresa; }
            set { dIdEmpresa = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string RNC
        {
            get { return dRNC; }
            set { dRNC = value; }
        }
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        public string Email
        {
            get { return dEmail; }
            set { dEmail = value; }
        }
        public string Logo
        {
            get { return dLogo; }
            set { dLogo = value; }
        }
        // CORRECCIÓN 8: DateTime en lugar de string.
        public DateTime FechaRegistro
        {
            get { return dFechaRegistro; }
            set { dFechaRegistro = value; }
        }
        // CORRECCIÓN 3: Usuario que realizó el registro.
        public int IdUsuarioRegistro
        {
            get { return dIdUsuarioRegistro; }
            set { dIdUsuarioRegistro = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDEmpresa objEmpresa)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCommand micomando = new SqlCommand("EmpresaInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pNombre", objEmpresa.Nombre);
                micomando.Parameters.AddWithValue("@pRNC", objEmpresa.RNC);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpresa.Direccion);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpresa.Telefono);
                micomando.Parameters.AddWithValue("@pEmail", objEmpresa.Email);
                micomando.Parameters.AddWithValue("@pLogo", objEmpresa.Logo);
                micomando.Parameters.AddWithValue("@pFechaRegistro", objEmpresa.FechaRegistro);
                micomando.Parameters.AddWithValue("@pIdUsuarioRegistro", objEmpresa.IdUsuarioRegistro);
                micomando.Parameters.AddWithValue("@pEstado", objEmpresa.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
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

        public string Actualizar(CDEmpresa objEmpresa)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCommand micomando = new SqlCommand("EmpresaActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdEmpresa", objEmpresa.IdEmpresa);
                micomando.Parameters.AddWithValue("@pNombre", objEmpresa.Nombre);
                micomando.Parameters.AddWithValue("@pRNC", objEmpresa.RNC);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpresa.Direccion);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpresa.Telefono);
                micomando.Parameters.AddWithValue("@pEmail", objEmpresa.Email);
                micomando.Parameters.AddWithValue("@pLogo", objEmpresa.Logo);
                micomando.Parameters.AddWithValue("@pFechaRegistro", objEmpresa.FechaRegistro);
                micomando.Parameters.AddWithValue("@pIdUsuarioRegistro", objEmpresa.IdUsuarioRegistro);
                micomando.Parameters.AddWithValue("@pEstado", objEmpresa.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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

        public DataTable EmpresaConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlcomando = new SqlCommand();
                sqlcomando.Connection = new SqlConnection(CDDBConexion1.miconexion);
                sqlcomando.Connection.Open();
                sqlcomando.CommandText = "EmpresaConsultar";
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
    }
}
