using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Competencia
    {
        public int Com_ID { get; set; }
        public string Com_Nombre { get; set; }
        public string Com_Descripcion { get; set; }
        public DateTime Com_FechaInicio { get; set; }
        public DateTime Com_FechaFin { get; set; }
        public string Com_Estado { get; set; } // Considera usar un enum para los estados
        public string Com_Organizador { get; set; }
        public string Com_Ubicacion { get; set; }
        public string Com_Sponsors { get; set; }
        public int Cat_ID { get; set; }
        public int Dis_ID { get; set; }


        public Competencia()
        {
        }

        public Competencia(int com_ID, string com_Nombre, string com_Descripcion, DateTime com_FechaInicio, DateTime com_FechaFin, string com_Estado, string com_Organizador, string com_Ubicacion, string com_Sponsors, int cat_ID, int dis_ID)
        {
            Com_ID = com_ID;
            Com_Nombre = com_Nombre;
            Com_Descripcion = com_Descripcion;
            Com_FechaInicio = com_FechaInicio;
            Com_FechaFin = com_FechaFin;
            Com_Estado = com_Estado;
            Com_Organizador = com_Organizador;
            Com_Ubicacion = com_Ubicacion;
            Com_Sponsors = com_Sponsors;
            Cat_ID = cat_ID;
            Dis_ID = dis_ID;
        }
    }
}
