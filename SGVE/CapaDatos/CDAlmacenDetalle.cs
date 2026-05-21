using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDAlmacenDetalle
    {
        #region Variables
        private int dIdAlmacenDetalle, dIdAlmacenCabecera, dIdProducto;
        private decimal dCantidad, dCostoUnitario;
        private string dMoneda;
        #endregion

        #region Propiedades
        public int IdAlmacenDetalle
        {
            get { return dIdAlmacenDetalle; }
            set { dIdAlmacenDetalle = value; }
        }

        public int IdAlmacenCabecera
        {
            get { return dIdAlmacenCabecera; }
            set { dIdAlmacenCabecera = value; }
        }

        public int IdProducto
        {
            get { return dIdProducto; }
            set { dIdProducto = value; }
        }

        public decimal Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }

        public decimal CostoUnitario
        {
            get { return dCostoUnitario; }
            set { dCostoUnitario = value; }
        }

        public string Moneda
        {
            get { return dMoneda; }
            set { dMoneda = value; }
        }
        #endregion

        #region Constructores
        public CDAlmacenDetalle()
        {
        }

        public CDAlmacenDetalle(int pIdAlmacenDetalle, int pIdAlmacenCabecera, int pIdProducto, decimal pCantidad, decimal pCostoUnitario, string pMoneda)
        {
            dIdAlmacenDetalle = pIdAlmacenDetalle;
            dIdAlmacenCabecera = pIdAlmacenCabecera;
            dIdProducto = pIdProducto;
            dCantidad = pCantidad;
            dCostoUnitario = pCostoUnitario;
            dMoneda = pMoneda;
        }
        #endregion

        #region Metodos
        public string Insertar(CDAlmacenDetalle obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "AlmacenDetalleInsertar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdAlmacenDetalle = new SqlParameter();
                parIdAlmacenDetalle.ParameterName = "@pidalmacendetalle";
                parIdAlmacenDetalle.SqlDbType = SqlDbType.Int;
                parIdAlmacenDetalle.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdAlmacenDetalle);

                sqlCmd.Parameters.AddWithValue("@pidalmacencabecera", obj.IdAlmacenCabecera);
                sqlCmd.Parameters.AddWithValue("@pidproducto", obj.IdProducto);
                sqlCmd.Parameters.AddWithValue("@pcantidad", obj.Cantidad);
                sqlCmd.Parameters.AddWithValue("@pcostounitario", obj.CostoUnitario);
                sqlCmd.Parameters.AddWithValue("@pmoneda", obj.Moneda);

                if (sqlCmd.ExecuteNonQuery() == 1)
                {
                    mensaje = "OK";
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

        public string Actualizar(CDAlmacenDetalle obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "AlmacenDetalleActualizar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pidalmacendetalle", obj.IdAlmacenDetalle);
                sqlCmd.Parameters.AddWithValue("@pidalmacencabecera", obj.IdAlmacenCabecera);
                sqlCmd.Parameters.AddWithValue("@pidproducto", obj.IdProducto);
                sqlCmd.Parameters.AddWithValue("@pcantidad", obj.Cantidad);
                sqlCmd.Parameters.AddWithValue("@pcostounitario", obj.CostoUnitario);
                sqlCmd.Parameters.AddWithValue("@pmoneda", obj.Moneda);

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

        public DataTable AlmacenDetalleConsultar(string pvalor)
        {
            DataTable dtResultado = new DataTable("AlmacenDetalle");
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "AlmacenDetalleConsultar";
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
