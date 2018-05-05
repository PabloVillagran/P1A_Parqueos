using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class TipoVehiculo
    {
        private int id;
        private String formatoPlaca;
        private double espacio;
        private double factorTarifa;
        private String descripcion;
        public int Id { get; set; }
        public String FormatoPlaca { get; set; }
        public double Espacio { get; set; }
        public double FactorTarifa { get; set; }
        public String Descripcion { get; set; }
    }
}
