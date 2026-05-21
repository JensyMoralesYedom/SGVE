using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCategoria
    {
        #region Variables
        private int dIdCategoria, dIdUsuarioRegistro;
        private string dNombreCategoria, dDescripcion, dEstado;
        private DateTime dFechaRegistro;
        #endregion

        #region Constructores
        public CDCategoria() { }

        public CDCategoria(int pIdCategoria, string pNombreCategoria, string pDescripcion,
            string pEstado, DateTime pFechaRegistro, int pIdUsuarioRegistro)
        {
            dIdCategoria = pIdCategoria;
            dNombreCategoria = pNombreCategoria;
            dDescripcion = pDescripcion;
            dEstado = pEstado;
            dFechaRegistro = pFechaRegistro;
            dIdUsuarioRegistro = pIdUsuarioRegistro;
        }
        #endregion

        #region Propiedades
        public int IdCategoria
        {
            get { return dIdCategoria; }
            set { dIdCategoria = value; }
        }
        public string NombreCategoria
        {
            get { return dNombreCategoria; }
            set { dNombreCategoria = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        public DateTime FechaRegistro
        {
            get { return dFechaRegistro; }
            set { dFechaRegistro = value; }
        }
        public int IdUsuarioRegistro
        {
            get { return dIdUsuarioRegistro; }
            set { dIdUsuarioRegistro = value; }
        }
        #endregion

        #region Métodos
        public string Insertar(CDCategoria obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "CategoriaInsertar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pNombreCategoria", obj.NombreCategoria);
                sqlCmd.Parameters.AddWithValue("@pDescripcion", obj.Descripcion);
                sqlCmd.Parameters.AddWithValue("@pEstado", obj.Estado);
                sqlCmd.Parameters.AddWithValue("@pFechaRegistro", obj.FechaRegistro);
                sqlCmd.Parameters.AddWithValue("@pIdUsuarioRegistro", obj.IdUsuarioRegistro);

                mensaje = sqlCmd.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo insertar el registro";
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

        public string Actualizar(CDCategoria obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "CategoriaActualizar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pIdCategoria", obj.IdCategoria);
                sqlCmd.Parameters.AddWithValue("@pNombreCategoria", obj.NombreCategoria);
                sqlCmd.Parameters.AddWithValue("@pDescripcion", obj.Descripcion);
                sqlCmd.Parameters.AddWithValue("@pEstado", obj.Estado);
                sqlCmd.Parameters.AddWithValue("@pFechaRegistro", obj.FechaRegistro);
                sqlCmd.Parameters.AddWithValue("@pIdUsuarioRegistro", obj.IdUsuarioRegistro);

                mensaje = sqlCmd.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo actualizar el registro";
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

        public DataTable CategoriaConsultar(string pvalor)
        {
            DataTable dtResultado = new DataTable("Categoria");
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;  
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "CategoriaConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pvalor", pvalor);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return dtResultado;
        }
        #endregion
    }
}

