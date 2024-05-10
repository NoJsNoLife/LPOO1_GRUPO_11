using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Evento
    {
        public int Eve_ID { get; set; }
        public int Com_ID { get; set; }
        public int Atl_ID { get; set; }
        public string Eve_Estado { get; set; } // Considera usar un enum para los estados
        public DateTime Eve_HoraInicio { get; set; }
        public DateTime Eve_HoraFin { get; set; }

        public Evento() { }

        public Evento(int eve_ID, int com_ID, int atl_ID, string eve_Estado, DateTime eve_HoraInicio, DateTime eve_HoraFin)
        {
            Eve_ID = eve_ID;
            Com_ID = com_ID;
            Atl_ID = atl_ID;
            Eve_Estado = eve_Estado;
            Eve_HoraInicio = eve_HoraInicio;
            Eve_HoraFin = eve_HoraFin;
        }
    }


}
