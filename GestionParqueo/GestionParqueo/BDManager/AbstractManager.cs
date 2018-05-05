using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionParqueo.Common;
using MySql.Data.MySqlClient;

namespace GestionParqueo.BDManager
{
    abstract class AbstractManager<O>
    {
        protected MySqlConnection con;
        protected MySqlCommand commando;
        protected MySqlDataReader dataReader;
        protected String sql;

        protected void Connect()
        {
            if(con==null)
                con = Utils.getConnection();
            try{
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectarse a base de datos. " + e.ToString());
            }
        }

        protected void Disconnect()
        {
            if(con!=null)
                try
                {
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("No se puede desconectar de BD!");
                }
        }

        public abstract Object Insert(O o);
        public abstract void Update(O o);
        public abstract void Delete(O o);
        public abstract List<O> Select();
    }
}
