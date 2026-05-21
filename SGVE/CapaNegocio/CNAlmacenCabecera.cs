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
    public class CNAlmacenCabecera
    {

        public static string Insertar(int pIdAlmacenCabecera, string pTipoMovimiento,
            DateTime pFechaMovimiento, int pIdUsuario,
            string pObservacion, string pEstado, DateTime pFechaRegistro)
        {
            CDAlmacenCabecera objAlmacenCabecera = new CDAlmacenCabecera();

            objAlmacenCabecera.IdAlmacenCabecera = pIdAlmacenCabecera;
            objAlmacenCabecera.TipoMovimiento = pTipoMovimiento;
            objAlmacenCabecera.FechaMovimiento = pFechaMovimiento;
            objAlmacenCabecera.IdUsuario = pIdUsuario;
            objAlmacenCabecera.Observacion = pObservacion;
            objAlmacenCabecera.Estado = pEstado;
            objAlmacenCabecera.FechaRegistro = pFechaRegistro;

            return objAlmacenCabecera.Insertar(objAlmacenCabecera);
        }

        public static string Actualizar(int pIdAlmacenCabecera, string pTipoMovimiento,
            DateTime pFechaMovimiento, int pIdUsuario,
            string pObservacion, string pEstado)
        {
            CDAlmacenCabecera objAlmacenCabecera = new CDAlmacenCabecera();

            objAlmacenCabecera.IdAlmacenCabecera = pIdAlmacenCabecera;
            objAlmacenCabecera.TipoMovimiento = pTipoMovimiento;
            objAlmacenCabecera.FechaMovimiento = pFechaMovimiento;
            objAlmacenCabecera.IdUsuario = pIdUsuario;
            objAlmacenCabecera.Observacion = pObservacion;
            objAlmacenCabecera.Estado = pEstado;

            return objAlmacenCabecera.Actualizar(objAlmacenCabecera);
        }

        public DataTable ObtenerAlmacenCabecera(string miparametro)
        {
            CDAlmacenCabecera objAlmacenCabecera = new CDAlmacenCabecera();
            DataTable dt = new DataTable();

            dt = objAlmacenCabecera.AlmacenCabeceraConsultar(miparametro);

            return dt;
        }
    }
}
