using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionParqueo.Common
{
    class Utils
    {
        public static MySqlConnection getConnection()
        {
            String connectionString = "SERVER=127.0.0.1;DATABASE=estacionamiento;UID=root;SslMode=none";
            return new MySqlConnection(connectionString);
        }
    }
}
