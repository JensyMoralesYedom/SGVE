using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
    public class CNFacturas
    {

        public static CDResultado Insertar(int pIdCliente, int pIdUsuarioVendedor,
            DateTime pFechaFactura, string pEstado, string pObservaciones, DateTime pFechaRegistro)
        {
            CDFacturas objFactura = new CDFacturas();

            objFactura.IdCliente = pIdCliente;
            objFactura.IdUsuarioVendedor = pIdUsuarioVendedor;
            objFactura.FechaFactura = pFechaFactura;
            objFactura.Estado = pEstado;
            objFactura.Observaciones = pObservaciones;
            objFactura.FechaRegistro = pFechaRegistro;

            return objFactura.Insertar(objFactura);
        }

        public static string Actualizar(int pIdFactura, int pIdCliente, 
            int pIdUsuarioVendedor,DateTime pFechaFactura, 
            string pEstado, string pObservaciones, DateTime pFechaRegistro)
        {
            CDFacturas objFactura = new CDFacturas();

            objFactura.IdFactura = pIdFactura;
            objFactura.IdCliente = pIdCliente;
            objFactura.IdUsuarioVendedor = pIdUsuarioVendedor;
            objFactura.FechaFactura = pFechaFactura;
            objFactura.Estado = pEstado;
            objFactura.Observaciones = pObservaciones;
            objFactura.FechaRegistro = pFechaRegistro;

            return objFactura.Actualizar(objFactura);
        }

        public static DataTable ObtenerFacturas(string miparametro)
        {
            CDFacturas objFactura = new CDFacturas();
            DataTable dt = new DataTable();
            dt = objFactura.Consultar(miparametro);
            return dt;
        }

        public static DataTable VentasPorDia()
        {
            CDFacturas objFactura = new CDFacturas();
            return objFactura.VentasPorDia();
        }

        public static DataTable TopProductosMasVendidos()
        {
            CDFacturas objFactura = new CDFacturas();
            return objFactura.TopProductosMasVendidos();
        }
    }
}
