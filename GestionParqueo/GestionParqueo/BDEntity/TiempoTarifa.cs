using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class TiempoTarifa
    {
        private int id;
        private float factorTarifa;
        private String descripcion;

        public int Id
        {
            get;
            set;
        }
        public float FactorTarifa
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
