using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Disciplina
    {
        private int dis_ID;
        private string dis_Nombre;
        private string dis_Descripcion;

        public int Dis_ID { get => dis_ID; set => dis_ID = value; }
        public string Dis_Nombre { get => dis_Nombre; set => dis_Nombre = value; }
        public string Dis_Descripcion { get => dis_Descripcion; set => dis_Descripcion = value; }

        public Disciplina() { }

        public Disciplina(int dis_ID, string dis_Nombre, string dis_Descripcion)
        {
            Dis_ID = dis_ID;
            Dis_Nombre = dis_Nombre;
            Dis_Descripcion = dis_Descripcion;
        }
    }
}
