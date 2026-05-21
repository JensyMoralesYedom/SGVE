using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static string Insertar(int pIdProducto, string pCodigo, string pNombre, string pMarca,
            string pDescripcion, decimal pCostoPorUnidad, decimal pMililitrosPorUnidad,
            decimal pPrecioVenta, int pIdCategoria, int pStockUnidades,
            string pEstado, int pIdUsuarioRegistro)
        {
            CDProducto objProducto = new CDProducto();
            objProducto.IdProducto = pIdProducto;
            objProducto.Codigo = pCodigo;
            objProducto.Nombre = pNombre;
            objProducto.Marca = pMarca;
            objProducto.Descripcion = pDescripcion;
            objProducto.CostoPorUnidad = pCostoPorUnidad;
            objProducto.MililitrosPorUnidad = pMililitrosPorUnidad;
            objProducto.PrecioVenta = pPrecioVenta;
            objProducto.IdCategoria = pIdCategoria;
            objProducto.StockUnidades = pStockUnidades;
            objProducto.Estado = pEstado;
            objProducto.IdUsuarioRegistro = pIdUsuarioRegistro;
            return objProducto.Insertar(objProducto);
        }

        public static string Actualizar(int pIdProducto, string pCodigo, string pNombre, string pMarca,
            string pDescripcion, decimal pCostoPorUnidad, decimal pMililitrosPorUnidad,
            decimal pPrecioVenta, int pIdCategoria, int pStockUnidades,
            string pEstado, int pIdUsuarioRegistro)
        {
            CDProducto objProducto = new CDProducto();
            objProducto.IdProducto = pIdProducto;
            objProducto.Codigo = pCodigo;
            objProducto.Nombre = pNombre;
            objProducto.Marca = pMarca;
            objProducto.Descripcion = pDescripcion;
            objProducto.CostoPorUnidad = pCostoPorUnidad;
            objProducto.MililitrosPorUnidad = pMililitrosPorUnidad;
            objProducto.PrecioVenta = pPrecioVenta;
            objProducto.IdCategoria = pIdCategoria;
            objProducto.StockUnidades = pStockUnidades;
            objProducto.Estado = pEstado;
            objProducto.IdUsuarioRegistro = pIdUsuarioRegistro;
            return objProducto.Actualizar(objProducto);
        }

        public DataTable ObtenerProducto(string miparametro)
        {
            CDProducto objProducto = new CDProducto();
            DataTable dt = new DataTable();
            dt = objProducto.ProductoConsultar(miparametro);
            return dt;
        }

        public static string ActualizarStock(int idProducto, int cantidad, string tipoMovimiento)
        {
            CDProducto objProducto = new CDProducto();
            return objProducto.ActualizarStock(idProducto, cantidad, tipoMovimiento);
        }
    }
}