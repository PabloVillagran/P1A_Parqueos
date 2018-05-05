using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParqueo.BDEntity
{
    class MovimientoTransaccion
    {
        private int serie;
        private String folio;
        private int correlativo;
        private DateTime hora;
        private String tipo;

        public int Serie
        {
            get;
            set;
        }
        public String Folio
        {
            get;
            set;
        }
        public int Correlativo
        {
            get;
            set;
        }
        public DateTime Hora
        {
            get;
            set;
        }
        public String Tipo
        {
            get;
            set;
        }
    }
}
