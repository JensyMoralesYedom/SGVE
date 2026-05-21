using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDAlmacenCabecera
    {
        #region Variables
        private int dIdAlmacenCabecera, dIdUsuario;     
        private string dTipoMovimiento, dObservacion, dEstado;
        private DateTime dFechaMovimiento;  
        private DateTime dFechaRegistro;    
        #endregion

        #region Propiedades
        public int IdAlmacenCabecera
        {
            get { return dIdAlmacenCabecera; }
            set { dIdAlmacenCabecera = value; }
        }

        public string TipoMovimiento
        {
            get { return dTipoMovimiento; }
            set { dTipoMovimiento = value; }
        }

        public DateTime FechaMovimiento
        {
            get { return dFechaMovimiento; }
            set { dFechaMovimiento = value; }
        }

        public int IdUsuario
        {
            get { return dIdUsuario; }
            set { dIdUsuario = value; }
        }


        public string Observacion
        {
            get { return dObservacion; }
            set { dObservacion = value; }
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
        #endregion

        #region Constructores
        public CDAlmacenCabecera()
        {
        }

        public CDAlmacenCabecera(int pIdAlmacenCabecera, string pTipoMovimiento,
            DateTime pFechaMovimiento, int pIdUsuario,
            string pObservacion, string pEstado, DateTime pFechaRegistro)
        {
            dIdAlmacenCabecera = pIdAlmacenCabecera;
            dTipoMovimiento = pTipoMovimiento;
            dFechaMovimiento = pFechaMovimiento;
            dIdUsuario = pIdUsuario;
            dObservacion = pObservacion;
            dEstado = pEstado;
            dFechaRegistro = pFechaRegistro;
        }
        #endregion

        #region Metodos
        public string Insertar(CDAlmacenCabecera obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "AlmacenCabeceraInsertar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdAlmacenCabecera = new SqlParameter();
                parIdAlmacenCabecera.ParameterName = "@pidalmacencabecera";
                parIdAlmacenCabecera.SqlDbType = SqlDbType.Int;
                parIdAlmacenCabecera.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdAlmacenCabecera);

                sqlCmd.Parameters.AddWithValue("@ptipomovimiento", obj.TipoMovimiento);
                sqlCmd.Parameters.AddWithValue("@pfechamovimiento", obj.FechaMovimiento);
                sqlCmd.Parameters.AddWithValue("@pidusuario", obj.IdUsuario);
                sqlCmd.Parameters.AddWithValue("@pobservacion", obj.Observacion);
                sqlCmd.Parameters.AddWithValue("@pestado", obj.Estado);
                sqlCmd.Parameters.AddWithValue("@pfecharegistro", obj.FechaRegistro);

                if (sqlCmd.ExecuteNonQuery() == 1)
                {
                    mensaje = sqlCmd.Parameters["@pidalmacencabecera"].Value.ToString();
                }
                else
                {
                    mensaje = "No se pudo ingresar el registro";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return mensaje;
        }

        public string Actualizar(CDAlmacenCabecera obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "AlmacenCabeceraActualizar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pidalmacencabecera", obj.IdAlmacenCabecera);
                sqlCmd.Parameters.AddWithValue("@ptipomovimiento", obj.TipoMovimiento);
                sqlCmd.Parameters.AddWithValue("@pfechamovimiento", obj.FechaMovimiento);
                sqlCmd.Parameters.AddWithValue("@pidusuario", obj.IdUsuario);
                sqlCmd.Parameters.AddWithValue("@pobservacion", obj.Observacion);
                sqlCmd.Parameters.AddWithValue("@pestado", obj.Estado);

                if (sqlCmd.ExecuteNonQuery() == 1)
                {
                    mensaje = "OK";
                }
                else
                {
                    mensaje = "No se pudo actualizar el registro";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return mensaje;
        }

        public DataTable AlmacenCabeceraConsultar(string pvalor)
        {
            DataTable dtResultado = new DataTable("AlmacenCabecera");
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "AlmacenCabeceraConsultar";
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
                {
                    sqlCon.Close();
                }
            }

            return dtResultado;
        }
        #endregion
    }
}
