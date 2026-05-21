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
    public class CNProveedor
    {

        public static string Insertar(int pIdProveedor, string pNombreProveedor, string pRNC,
            string pTelefono, string pEmail, string pDireccion, string pPersonaContacto,
            string pEstado, DateTime pFechaRegistro, int pIdUsuarioRegistro)
        {
            CDProveedor objProveedor = new CDProveedor();

            objProveedor.IdProveedor = pIdProveedor;
            objProveedor.NombreProveedor = pNombreProveedor;
            objProveedor.RNC = pRNC;
            objProveedor.Telefono = pTelefono;
            objProveedor.Email = pEmail;
            objProveedor.Direccion = pDireccion;
            objProveedor.PersonaContacto = pPersonaContacto;
            objProveedor.Estado = pEstado;
            objProveedor.FechaRegistro = pFechaRegistro;
            objProveedor.IdUsuarioRegistro = pIdUsuarioRegistro;

            return objProveedor.Insertar(objProveedor);
        }

        public static string Actualizar(int pIdProveedor, string pNombreProveedor, string pRNC,
            string pTelefono, string pEmail, string pDireccion, string pPersonaContacto,
            string pEstado, DateTime pFechaRegistro, int pIdUsuarioRegistro)
        {
            CDProveedor objProveedor = new CDProveedor();

            objProveedor.IdProveedor = pIdProveedor;
            objProveedor.NombreProveedor = pNombreProveedor;
            objProveedor.RNC = pRNC;
            objProveedor.Telefono = pTelefono;
            objProveedor.Email = pEmail;
            objProveedor.Direccion = pDireccion;
            objProveedor.PersonaContacto = pPersonaContacto;
            objProveedor.Estado = pEstado;
            objProveedor.FechaRegistro = pFechaRegistro;
            objProveedor.IdUsuarioRegistro = pIdUsuarioRegistro;

            return objProveedor.Actualizar(objProveedor);
        }

        public static DataTable ObtenerProveedor(string miparametro)
        {
            CDProveedor objProveedor = new CDProveedor();
            DataTable dt = new DataTable();
            dt = objProveedor.ProveedorConsultar(miparametro);
            return dt;
        }
    }
}
