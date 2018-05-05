using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class Tarifa
    {
        private int id;
        private int idTipoVehiculo;
        private int idTipoTarifa;
        private int idEstacionamiento;
        private String descripcion;

        public int Id
        {
            get;
            set;
        }

        public int IdTipoVehiculo
        {
            get;
            set;
        }

        public int IdTipoTarifa
        {
            get;
            set;
        }

        public int IdEstacionamiento
        {
            get;
            set;
        }
        
        public String Descripcion
        {
            get;
            set;
        }
    }
}
