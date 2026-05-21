using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        private int dIdCliente;
        private string dNombre, dApellido, dTelefono, dDireccion, dTipoDocumento, dDocumentoId, dSexo, dEstado;

        public CDCliente()
        {
        }

        public CDCliente(int pIdCliente, string pNombre, string pApellido, string pTelefono, string pDireccion, string pTipoDocumento, string pDocumentoId, string pSexo, string pEstado)
        {
            this.dIdCliente = pIdCliente;
            this.dNombre = pNombre;
            this.dApellido = pApellido;
            this.dTelefono = pTelefono;
            this.dDireccion = pDireccion;
            this.dTipoDocumento = pTipoDocumento;
            this.dDocumentoId = pDocumentoId;
            this.dSexo = pSexo;
            this.dEstado = pEstado;
        }

        #region metodos get y set
        public int IdCliente
        {
            get { return dIdCliente; }
            set { dIdCliente = value; }
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
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public string TipoDocumento
        {
            get { return dTipoDocumento; }
            set { dTipoDocumento = value; }
        }
        public string DocumentoId
        {
            get { return dDocumentoId; }
            set { dDocumentoId = value; }
        }
        public string Sexo
        {
            get { return dSexo; }
            set { dSexo = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDCliente objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pNombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@pTelefono", objCliente.Telefono);
                micomando.Parameters.AddWithValue("@pDireccion", objCliente.Direccion);
                micomando.Parameters.AddWithValue("@pTipoDocumento", objCliente.TipoDocumento);
                micomando.Parameters.AddWithValue("@pDocumentoId", objCliente.DocumentoId);
                micomando.Parameters.AddWithValue("@pSexo", objCliente.Sexo);
                micomando.Parameters.AddWithValue("@pEstado", objCliente.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Inserción de datos completada correctamente!"
                    : "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        public string Actualizar(CDCliente objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteActualizar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdCliente", objCliente.IdCliente);
                micomando.Parameters.AddWithValue("@pNombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@pTelefono", objCliente.Telefono);
                micomando.Parameters.AddWithValue("@pDireccion", objCliente.Direccion);
                micomando.Parameters.AddWithValue("@pTipoDocumento", objCliente.TipoDocumento);
                micomando.Parameters.AddWithValue("@pDocumentoId", objCliente.DocumentoId);
                micomando.Parameters.AddWithValue("@pSexo", objCliente.Sexo);
                micomando.Parameters.AddWithValue("@pEstado", objCliente.Estado);
                sqlCon.Open();

                mensaje = micomando.ExecuteNonQuery() == 1
                    ? "Datos actualizados correctamente!"
                    : "No se pudo actualizar correctamente los nuevos datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        public DataTable ClienteConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new CDDBConexion1().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "ClienteConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }
    }
}
