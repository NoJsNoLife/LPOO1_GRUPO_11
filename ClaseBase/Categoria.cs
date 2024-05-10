using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Categoria
    {
        private int cat_ID;
        private string cat_Nombre;
        private string cat_Descripcion;

        public int Cat_ID { get => cat_ID; set => cat_ID = value; }
        public string Cat_Nombre { get => cat_Nombre; set => cat_Nombre = value; }
        public string Cat_Descripcion { get => cat_Descripcion; set => cat_Descripcion = value; }

        public Categoria()
        {
        }

        public Categoria(int cat_ID, string cat_Nombre, string cat_Descripcion)
        {
            Cat_ID = cat_ID;
            Cat_Nombre = cat_Nombre;
            Cat_Descripcion = cat_Descripcion;
        }
    }
}
