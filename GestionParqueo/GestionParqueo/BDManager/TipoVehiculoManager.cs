using GestionParqueo.BDEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDManager
{
    class TipoVehiculoManager : AbstractManager<TipoVehiculo>
    {
        public override void Delete(TipoVehiculo o)
        {
            throw new NotImplementedException();
        }

        public override object Insert(TipoVehiculo o)
        {
            sql = "INSERT INTO tipo_vehiculo(formato_placa, espacio, factor_tarifa, descripcion)" +
                "VALUES(@formato, @espacio, @factor, @descripcion);" +
                "select last_insert_id();";
            Connect();
            try{
                commando = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                commando.Parameters.AddWithValue("@formato", o.FormatoPlaca);
                commando.Parameters.AddWithValue("@espacio", o.Espacio);
                commando.Parameters.AddWithValue("@factor", o.FactorTarifa);
                commando.Parameters.AddWithValue("@descripcion", o.Descripcion);
                return commando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el registro. " + ex.Message);
            }
        }

        public override List<TipoVehiculo> Select()
        {
            sql = "SELECT id, formato_placa, espacio, factor_tarifa, descripcion " +
                "FROM tipo_vehiculo ";
            Connect();
            try
            {
                List<TipoVehiculo> list = new List<TipoVehiculo>();
                commando = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                dataReader = commando.ExecuteReader();
                while (dataReader.Read())
                {
                    TipoVehiculo tmp = new TipoVehiculo();
                    tmp.Id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                    tmp.FormatoPlaca = dataReader.GetString(dataReader.GetOrdinal("formato_placa"));
                    tmp.Espacio = dataReader.GetDouble(dataReader.GetOrdinal("espacio"));
                    tmp.FactorTarifa = dataReader.GetDouble(dataReader.GetOrdinal("factor_tarifa"));
                    tmp.Descripcion = dataReader.GetString(dataReader.GetOrdinal("descripcion"));
                    list.Add(tmp);
                }
                return list;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al seleccionar tipos de vehiculo." + ex.Message);
            }
        }

        public override void Update(TipoVehiculo o)
        {
            throw new NotImplementedException();
        }
    }
}
