using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class Ubicacion
    {
        private int idEstacionamiento;
        public int IdEstacionamiento { get; set; }
        private String sector;
        public String Sector { get; set; }
        private int numero;
        public String Numero { get; set; }
        private int idTipoVehiculo;
        public int IdTipoVehiculo { get; set; }
    }
}
