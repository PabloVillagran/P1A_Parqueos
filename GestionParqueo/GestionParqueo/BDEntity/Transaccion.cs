using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class Transaccion
    {
        private int serie;
        public int Serie { get; set; }
        private String folio;
        public String Folio { get; set; }
        private int correlativo;
        public int Correlativo { get; set;}
        private int idTarifa;
        public int IdTarifa { get; set; }
        private double montoTotal;
        public double MontoTotal { get; set; }
        private float histTarifaVehiculo;
        public float HistTarifaVehiculo { get; set; }
        private float histTarifaTiempo;
        public float HistTarifaTiempo { get; set; }
        private int uEstacionamiento;
        public int UEstacionamiento { get; set; }
        private String uSector;
        public String USector { get; set; }
        private int uNumero;
        public int UNumero { get; set; }
        private String placaVehiculoCliente;
        public String PlacaVehiculoCliente { get; set; }
    }
}
