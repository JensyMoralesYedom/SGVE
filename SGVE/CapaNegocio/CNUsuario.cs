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
    public class CNUsuario
    {
        public static string Insertar(int pIdUsuario, string pNombre, string pApellido,
            string pUsuario, string pContraseña, string pRol, string pEmail,
            DateTime pFechaRegistro, DateTime pUltimoAcceso, string pEstado)
        {
            CDUsuario objUsuario = new CDUsuario();
            objUsuario.IdUsuario = pIdUsuario;
            objUsuario.Nombre = pNombre;
            objUsuario.Apellido = pApellido;
            objUsuario.Usuario = pUsuario;
            objUsuario.Contraseña = pContraseña;
            objUsuario.Rol = pRol;
            objUsuario.Email = pEmail;
            objUsuario.FechaRegistro = pFechaRegistro;
            objUsuario.UltimoAcceso = pUltimoAcceso;
            objUsuario.Estado = pEstado;

            return objUsuario.Insertar(objUsuario);
        }

        public static string Actualizar(int pIdUsuario, string pNombre, string pApellido,
            string pUsuario, string pContraseña, string pRol, string pEmail,
            DateTime pFechaRegistro, DateTime pUltimoAcceso, string pEstado)
        {
            CDUsuario objUsuario = new CDUsuario();
            objUsuario.IdUsuario = pIdUsuario;
            objUsuario.Nombre = pNombre;
            objUsuario.Apellido = pApellido;
            objUsuario.Usuario = pUsuario;
            objUsuario.Contraseña = pContraseña;
            objUsuario.Rol = pRol;
            objUsuario.Email = pEmail;
            objUsuario.FechaRegistro = pFechaRegistro;
            objUsuario.UltimoAcceso = pUltimoAcceso;
            objUsuario.Estado = pEstado;

            return objUsuario.Actualizar(objUsuario);
        }

        public DataTable ObtenerUsuario(string miparametro)
        {
            CDUsuario objUsuario = new CDUsuario();
            DataTable dt = new DataTable();
            dt = objUsuario.UsuarioConsultar(miparametro);
            return dt;
        }

        // --- NUEVA DEFINICIÓN PARA EL LOGIN ---
        public static DataTable Login(string usuario, string password)
        {
            CDUsuario objUsuario = new CDUsuario();
            return objUsuario.Login(usuario, password);
        }
    }
}