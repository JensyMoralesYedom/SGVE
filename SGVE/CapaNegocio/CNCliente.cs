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
    public class CNCliente
    {
        public static string Insertar(int pIdCliente, string pNombre, string pApellido, string pTelefono, string pDireccion, string pTipoDocumento, string pDocumentoId, string pSexo, string pEstado)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.IdCliente = pIdCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Telefono = pTelefono;
            objCliente.Direccion = pDireccion;
            objCliente.TipoDocumento = pTipoDocumento;
            objCliente.DocumentoId = pDocumentoId;
            objCliente.Sexo = pSexo;
            objCliente.Estado = pEstado;

            return objCliente.Insertar(objCliente);
        }

        public static string Actualizar(int pIdCliente, string pNombre, string pApellido, string pTelefono, string pDireccion, string pTipoDocumento, string pDocumentoId, string pSexo, string pEstado)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.IdCliente = pIdCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Telefono = pTelefono;
            objCliente.Direccion = pDireccion;
            objCliente.TipoDocumento = pTipoDocumento;
            objCliente.DocumentoId = pDocumentoId;
            objCliente.Sexo = pSexo;
            objCliente.Estado = pEstado;

            return objCliente.Actualizar(objCliente);
        }

        public static DataTable ObtenerCliente(string miparametro)
        {
            CDCliente objCliente = new CDCliente();
            DataTable dt = new DataTable();
            dt = objCliente.ClienteConsultar(miparametro);
            return dt;
        }
    }
}
