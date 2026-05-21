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
    public class CNAlmacenDetalle
    {
        public static string Insertar(int pidAlmacenDetalle, int pIdAlmacenCabecera, int pIdProducto, decimal pCantidad, decimal pCostoUnitario, string pMoneda)
        {
            CDAlmacenDetalle objAlmacenDetalle = new CDAlmacenDetalle();
            objAlmacenDetalle.IdAlmacenDetalle = pidAlmacenDetalle;
            objAlmacenDetalle.IdAlmacenCabecera = pIdAlmacenCabecera;
            objAlmacenDetalle.IdProducto = pIdProducto;
            objAlmacenDetalle.Cantidad = pCantidad;
            objAlmacenDetalle.CostoUnitario = pCostoUnitario;
            objAlmacenDetalle.Moneda = pMoneda;

            return objAlmacenDetalle.Insertar(objAlmacenDetalle);
        }

        public static string Actualizar(int pidAlmacenDetalle, int pIdAlmacenCabecera, int pIdProducto, decimal pCantidad, decimal pCostoUnitario, string pMoneda)
        {
            CDAlmacenDetalle objAlmacenDetalle = new CDAlmacenDetalle();
            objAlmacenDetalle.IdAlmacenDetalle = pidAlmacenDetalle;
            objAlmacenDetalle.IdAlmacenCabecera = pIdAlmacenCabecera;
            objAlmacenDetalle.IdProducto = pIdProducto;
            objAlmacenDetalle.Cantidad = pCantidad;
            objAlmacenDetalle.CostoUnitario = pCostoUnitario;
            objAlmacenDetalle.Moneda = pMoneda;

            return objAlmacenDetalle.Actualizar(objAlmacenDetalle);
        }

        public DataTable ObtenerAlmacenDetalle(string miparametro)
        {
            CDAlmacenDetalle objAlmacenDetalle = new CDAlmacenDetalle();
            DataTable dt = new DataTable();
            dt = objAlmacenDetalle.AlmacenDetalleConsultar(miparametro);
            return dt;
        }
    }
}
