using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class CDDBConexion1
    {
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PROGRAMACIÓN 2\SGVE\CAPADATOS\DBSGVE.mdf;Integrated Security=True";
        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}
