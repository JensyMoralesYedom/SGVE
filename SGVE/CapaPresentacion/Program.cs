using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        // Variables globales accesibles desde cualquier formulario

        // Control de operación en curso
        public static bool nuevo = false;
        public static bool modificar = false;

        // IDs de registros seleccionados en formularios de búsqueda 
        public static int vidProducto = 0;   // ID del producto seleccionado
        public static int vidsuplidor = 0;   // ID del suplidor/proveedor seleccionado
        public static int vidCliente = 0;   // ID del cliente seleccionado
        public static int vidCategoria = 0;   // ID de la categoría seleccionada
        public static int vidProveedor = 0;   // ID del proveedor seleccionado
        public static int idUsuarioActual = 0; // ID del usuario actualmente logueado en el sistema
        public static int vidfactura = 0; // ID de la factura actualmente seleccionada
        public static string nombreUsuarioActual = ""; // Nombre del usuario actualmente logueado en el sistema

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FLogin());
        }
    }
}
