using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Roles
    {
        public int Rol_Codigo { get; set; }
        public string Rol_Descripcion { get; set; }
        public Roles() { }

        public Roles(int rol_Codigo, string rol_Descripcion)
        {
            Rol_Codigo = rol_Codigo;
            Rol_Descripcion = rol_Descripcion;
        }
    }
}
