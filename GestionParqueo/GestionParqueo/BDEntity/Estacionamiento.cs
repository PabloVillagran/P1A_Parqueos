using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class Estacionamiento
    {
        private int id;
        private String direccion;
        private double espacio;

        public int Id
        {
            get;
            set;
        }

        public String Direccion
        {
            get;
            set;
        }

        public double Espacio
        {
            get;
            set;
        }
    }
}
