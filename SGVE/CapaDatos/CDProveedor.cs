using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDProveedor
    {
        #region Variables
        private int idproveedor;
        private int idusuarioregistro;   
        private string nombreproveedor;
        private string rnc;
        private string telefono;
        private string email;
        private string direccion;
        private string personacontacto;
        private string estado;
        private DateTime fecharegistro; 
        #endregion

        #region Propiedades
        public int IdProveedor
        {
            get { return idproveedor; }
            set { idproveedor = value; }
        }

        public int IdUsuarioRegistro
        {
            get { return idusuarioregistro; }
            set { idusuarioregistro = value; }
        }

        public string NombreProveedor
        {
            get { return nombreproveedor; }
            set { nombreproveedor = value; }
        }

        public string RNC
        {
            get { return rnc; }
            set { rnc = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string PersonaContacto
        {
            get { return personacontacto; }
            set { personacontacto = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fecharegistro; }
            set { fecharegistro = value; }
        }
        #endregion

        #region Constructores
        public CDProveedor()
        {
        }

        public CDProveedor(int idproveedor, string nombreproveedor, string rnc, string telefono,
                          string email, string direccion, string personacontacto,
                          string estado, DateTime fecharegistro, int idusuarioregistro)
        {
            this.idproveedor = idproveedor;
            this.nombreproveedor = nombreproveedor;
            this.rnc = rnc;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.personacontacto = personacontacto;
            this.estado = estado;
            this.fecharegistro = fecharegistro;
            this.idusuarioregistro = idusuarioregistro;
        }
        #endregion

        #region Metodos
        public string Insertar(CDProveedor obj)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProveedorInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProveedor = new SqlParameter();
                parIdProveedor.ParameterName = "@pIdProveedor";
                parIdProveedor.SqlDbType = SqlDbType.Int;
                parIdProveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(parIdProveedor);

                SqlCmd.Parameters.AddWithValue("@pNombreProveedor", obj.NombreProveedor);
                SqlCmd.Parameters.AddWithValue("@pRNC", obj.RNC);
                SqlCmd.Parameters.AddWithValue("@pTelefono", obj.Telefono);
                SqlCmd.Parameters.AddWithValue("@pEmail", obj.Email);
                SqlCmd.Parameters.AddWithValue("@pDireccion", obj.Direccion);
                SqlCmd.Parameters.AddWithValue("@pPersonaContacto", obj.PersonaContacto);
                SqlCmd.Parameters.AddWithValue("@pEstado", obj.Estado);
                SqlCmd.Parameters.AddWithValue("@pFechaRegistro", obj.FechaRegistro);
                SqlCmd.Parameters.AddWithValue("@pIdUsuarioRegistro", obj.IdUsuarioRegistro);

                if (SqlCmd.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo ingresar el registro";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;
        }

        public string Actualizar(CDProveedor obj)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProveedorActualizar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlCmd.Parameters.AddWithValue("@pIdProveedor", obj.IdProveedor);
                SqlCmd.Parameters.AddWithValue("@pNombreProveedor", obj.NombreProveedor);
                SqlCmd.Parameters.AddWithValue("@pRNC", obj.RNC);
                SqlCmd.Parameters.AddWithValue("@pTelefono", obj.Telefono);
                SqlCmd.Parameters.AddWithValue("@pEmail", obj.Email);
                SqlCmd.Parameters.AddWithValue("@pDireccion", obj.Direccion);
                SqlCmd.Parameters.AddWithValue("@pPersonaContacto", obj.PersonaContacto);
                SqlCmd.Parameters.AddWithValue("@pEstado", obj.Estado);
                SqlCmd.Parameters.AddWithValue("@pFechaRegistro", obj.FechaRegistro);
                //SqlCmd.Parameters.AddWithValue("@pIdUsuarioRegistro", obj.IdUsuarioRegistro);

                if (SqlCmd.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo actualizar el registro";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;
        }

        public DataTable ProveedorConsultar(string pvalor)
        {
            DataTable dt = new DataTable("Proveedor");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = CDDBConexion1.miconexion;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProveedorConsultar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlCmd.Parameters.AddWithValue("@pvalor", pvalor);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return dt;
        }
        #endregion
    }
}
