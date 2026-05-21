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
    public class CNEmpresa
    {

        public static string Insertar(int pIdEmpresa, string pNombre, string pRNC, string pDireccion,
            string pTelefono, string pEmail, string pLogo, DateTime pFechaRegistro,
            int pIdUsuarioRegistro, string pEstado)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IdEmpresa = pIdEmpresa;
            objEmpresa.Nombre = pNombre;
            objEmpresa.RNC = pRNC;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.Telefono = pTelefono;
            objEmpresa.Email = pEmail;
            objEmpresa.Logo = pLogo;
            objEmpresa.FechaRegistro = pFechaRegistro;
            objEmpresa.IdUsuarioRegistro = pIdUsuarioRegistro;
            objEmpresa.Estado = pEstado;

            return objEmpresa.Insertar(objEmpresa);
        }

        public static string Actualizar(int pIdEmpresa, string pNombre, string pRNC, string pDireccion,
            string pTelefono, string pEmail, string pLogo, DateTime pFechaRegistro,
            int pIdUsuarioRegistro, string pEstado)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IdEmpresa = pIdEmpresa;
            objEmpresa.Nombre = pNombre;
            objEmpresa.RNC = pRNC;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.Telefono = pTelefono;
            objEmpresa.Email = pEmail;
            objEmpresa.Logo = pLogo;
            objEmpresa.FechaRegistro = pFechaRegistro;
            objEmpresa.IdUsuarioRegistro = pIdUsuarioRegistro;
            objEmpresa.Estado = pEstado;

            return objEmpresa.Actualizar(objEmpresa);
        }

        public DataTable ObtenerEmpresa(string miparametro)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            DataTable dt = new DataTable();
            dt = objEmpresa.EmpresaConsultar(miparametro);
            return dt;
        }
    }
}
