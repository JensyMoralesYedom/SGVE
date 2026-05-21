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
    public class CNDetalleFactura
    {
        public static string Insertar(int pIdDetalle, int pIdFactura, int pIdProducto, int pCantidad, decimal pPrecio)
        {
            CDFacturaDetalle objDetalleFactura = new CDFacturaDetalle();
            objDetalleFactura.IdFacturaDetalle = pIdDetalle;
            objDetalleFactura.IdFactura = pIdFactura;
            objDetalleFactura.IdProducto = pIdProducto;
            objDetalleFactura.Cantidad = pCantidad;
            objDetalleFactura.PrecioVenta = pPrecio;

            return objDetalleFactura.Insertar(objDetalleFactura);
        }

        public static string Actualizar(int pIdDetalle, int pIdFactura, int pIdProducto, int pCantidad, decimal pPrecio)
        {
            CDFacturaDetalle objDetalleFactura = new CDFacturaDetalle();
            objDetalleFactura.IdFacturaDetalle = pIdDetalle;
            objDetalleFactura.IdFactura = pIdFactura;
            objDetalleFactura.IdProducto = pIdProducto;
            objDetalleFactura.Cantidad = pCantidad;
            objDetalleFactura.PrecioVenta = pPrecio;

            return objDetalleFactura.Actualizar(objDetalleFactura);
        }

        public DataTable ObtenerDetalleFactura(string miparametro)
        {
            CDFacturaDetalle objDetalleFactura = new CDFacturaDetalle();
            DataTable dt = new DataTable();
            dt = objDetalleFactura.DetalleFacturaConsultar(miparametro);
            return dt;
        }
    }
}
