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
    public class CNCategoria
    {

        public static string Insertar(int pIdCategoria, string pNombreCategoria, string pDescripcion,
            string pEstado, DateTime pFechaRegistro, int pIdUsuarioRegistro)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IdCategoria = pIdCategoria;
            objCategoria.NombreCategoria = pNombreCategoria;
            objCategoria.Descripcion = pDescripcion;
            objCategoria.Estado = pEstado;
            objCategoria.FechaRegistro = pFechaRegistro;
            objCategoria.IdUsuarioRegistro = pIdUsuarioRegistro;

            return objCategoria.Insertar(objCategoria);
        }

        public static string Actualizar(int pIdCategoria, string pNombreCategoria, string pDescripcion,
            string pEstado, DateTime pFechaRegistro, int pIdUsuarioRegistro)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IdCategoria = pIdCategoria;
            objCategoria.NombreCategoria = pNombreCategoria;
            objCategoria.Descripcion = pDescripcion;
            objCategoria.Estado = pEstado;
            objCategoria.FechaRegistro = pFechaRegistro;
            objCategoria.IdUsuarioRegistro = pIdUsuarioRegistro;

            return objCategoria.Actualizar(objCategoria);
        }

        public DataTable ObtenerCategoria(string miparametro)
        {
            CDCategoria objCategoria = new CDCategoria();
            DataTable dt = new DataTable();
            dt = objCategoria.CategoriaConsultar(miparametro);
            return dt;
        }
    }
}
