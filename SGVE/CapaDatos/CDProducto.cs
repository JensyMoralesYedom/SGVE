using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDProducto
    {
        #region Variables
        private int dIdProducto, dIdCategoria, dStockUnidades, dIdUsuarioRegistro;
        private string dCodigo, dNombre, dMarca, dDescripcion, dEstado;
        private decimal dCostoPorUnidad, dMililitrosPorUnidad, dPrecioVenta;
        #endregion

        #region Propiedades
        public int IdProducto
        {
            get { return dIdProducto; }
            set { dIdProducto = value; }
        }

        public string Codigo
        {
            get { return dCodigo; }
            set { dCodigo = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Marca
        {
            get { return dMarca; }
            set { dMarca = value; }
        }

        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }

        public decimal CostoPorUnidad
        {
            get { return dCostoPorUnidad; }
            set { dCostoPorUnidad = value; }
        }

        public decimal MililitrosPorUnidad
        {
            get { return dMililitrosPorUnidad; }
            set { dMililitrosPorUnidad = value; }
        }

        public decimal PrecioVenta
        {
            get { return dPrecioVenta; }
            set { dPrecioVenta = value; }
        }

        public int IdCategoria
        {
            get { return dIdCategoria; }
            set { dIdCategoria = value; }
        }

        public int StockUnidades
        {
            get { return dStockUnidades; }
            set { dStockUnidades = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        public int IdUsuarioRegistro
        {
            get { return dIdUsuarioRegistro; }
            set { dIdUsuarioRegistro = value; }
        }

        public decimal CostoPorMl
        {
            get
            {
                if (dMililitrosPorUnidad == 0) return 0;
                return Math.Round(dCostoPorUnidad / dMililitrosPorUnidad, 2);
            }
        }

        public decimal StockEnMl
        {
            get
            {
                return Math.Round(dStockUnidades * dMililitrosPorUnidad, 2);
            }
        }
        #endregion

        #region Constructores
        public CDProducto()
        {
        }

        public CDProducto(int pIdProducto, string pCodigo, string pNombre, string pMarca,
            string pDescripcion, decimal pCostoPorUnidad, decimal pMililitrosPorUnidad,
            decimal pPrecioVenta, int pIdCategoria, int pStockUnidades,
            string pEstado, int pIdUsuarioRegistro)
        {
            dIdProducto = pIdProducto;
            dCodigo = pCodigo;
            dNombre = pNombre;
            dMarca = pMarca;
            dDescripcion = pDescripcion;
            dCostoPorUnidad = pCostoPorUnidad;
            dMililitrosPorUnidad = pMililitrosPorUnidad;
            dPrecioVenta = pPrecioVenta;
            dIdCategoria = pIdCategoria;
            dStockUnidades = pStockUnidades;
            dEstado = pEstado;
            dIdUsuarioRegistro = pIdUsuarioRegistro;
        }
        #endregion

        #region Metodos
        public string Insertar(CDProducto obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "ProductoInsertar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@pidproducto";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdProducto);

                sqlCmd.Parameters.AddWithValue("@pcodigo", obj.Codigo);
                sqlCmd.Parameters.AddWithValue("@pnombre", obj.Nombre);
                sqlCmd.Parameters.AddWithValue("@pmarca", obj.Marca);
                sqlCmd.Parameters.AddWithValue("@pdescripcion", obj.Descripcion);
                sqlCmd.Parameters.AddWithValue("@pcostoporunidad", obj.CostoPorUnidad);
                sqlCmd.Parameters.AddWithValue("@pmililitrosporunidad", obj.MililitrosPorUnidad);
                sqlCmd.Parameters.AddWithValue("@pprecioventa", obj.PrecioVenta);
                sqlCmd.Parameters.AddWithValue("@pidcategoria", obj.IdCategoria);
                sqlCmd.Parameters.AddWithValue("@pstockunidades", obj.StockUnidades);
                sqlCmd.Parameters.AddWithValue("@pestado", obj.Estado);
                sqlCmd.Parameters.AddWithValue("@pidusuarioregistro", obj.IdUsuarioRegistro);

                sqlCmd.ExecuteNonQuery();

                mensaje = "OK";
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

        public string Actualizar(CDProducto obj)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "ProductoActualizar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pidproducto", obj.IdProducto);
                sqlCmd.Parameters.AddWithValue("@pcodigo", obj.Codigo);
                sqlCmd.Parameters.AddWithValue("@pnombre", obj.Nombre);
                sqlCmd.Parameters.AddWithValue("@pmarca", obj.Marca);
                sqlCmd.Parameters.AddWithValue("@pdescripcion", obj.Descripcion);
                sqlCmd.Parameters.AddWithValue("@pcostoporunidad", obj.CostoPorUnidad);
                sqlCmd.Parameters.AddWithValue("@pmililitrosporunidad", obj.MililitrosPorUnidad);
                sqlCmd.Parameters.AddWithValue("@pprecioventa", obj.PrecioVenta);
                sqlCmd.Parameters.AddWithValue("@pidcategoria", obj.IdCategoria);
                sqlCmd.Parameters.AddWithValue("@pstockunidades", obj.StockUnidades);
                sqlCmd.Parameters.AddWithValue("@pestado", obj.Estado);
                sqlCmd.Parameters.AddWithValue("@pIdusuarioregistro", obj.IdUsuarioRegistro);

                sqlCmd.ExecuteNonQuery();

                mensaje = "OK";
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

        public DataTable ProductoConsultar(string pvalor)
        {
            DataTable dtResultado = new DataTable("Producto");
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "ProductoConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@pvalor", pvalor);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);

                dtResultado.Columns.Add("CostoPorMl", typeof(decimal));
                dtResultado.Columns.Add("StockEnMl", typeof(decimal));

                foreach (DataRow fila in dtResultado.Rows)
                {
                    decimal costo = Convert.ToDecimal(fila["CostoPorUnidad"]);
                    decimal ml = Convert.ToDecimal(fila["MililitrosPorUnidad"]);
                    int stock = Convert.ToInt32(fila["StockUnidades"]);

                    fila["CostoPorMl"] = (ml == 0) ? 0 : Math.Round(costo / ml, 2);
                    fila["StockEnMl"] = Math.Round(stock * ml, 2);
                }
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

        public string ActualizarStock(int idProducto, int cantidad, string tipoMovimiento)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = CDDBConexion1.miconexion;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;

                if (tipoMovimiento == "Ajuste de Entrada")
                {
                    sqlCmd.CommandText = "UPDATE Producto SET StockUnidades = StockUnidades + @cantidad WHERE IdProducto = @id";
                }
                else if (tipoMovimiento == "Ajuste de Salida")
                {
                    sqlCmd.CommandText = "UPDATE Producto SET StockUnidades = StockUnidades - @cantidad WHERE IdProducto = @id";
                }

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@cantidad", cantidad);
                sqlCmd.Parameters.AddWithValue("@id", idProducto);

                mensaje = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se afectó el stock.";
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
        #endregion
    }
}