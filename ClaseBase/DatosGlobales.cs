using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public static class DatosGlobales { 
    
        public static List<Atleta> atletas = new List<Atleta>();
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Categoria> categorias = new List<Categoria>();
        public static List<Disciplina> disciplinas = new List<Disciplina>();

        public static void cargarDatos()
        {
            // cargar Usuarios
            usuarios.Add(new Usuario(1,"Administrador","admin","Admin",1));
            usuarios.Add(new Usuario(2,"Vendedor","vendedor","Vendedor",2));
            usuarios.Add(new Usuario(3, "Operador", "operador", "Operador", 3));

            //cargar Atletas
            //atletas.Add(new Atleta(1,"42227743","Meneghini","Enzo","Argentino","Zapana",'M',1.90,90,new DateTime(1999,11,21), "mi casa","mail"));

            //Cargar Categorias
            categorias.Add(new Categoria(1, "H35", "Hombres de 35 a 39 años"));
            categorias.Add(new Categoria(2, "U23", "Sub 23 Mixto"));
            categorias.Add(new Categoria(3, "M35", "Mujeres de 35 a 39 años"));

            //Cargar Disciplinas
            disciplinas.Add(new Disciplina(1,"Atletismo","Carrera de velocidad"));
            disciplinas.Add(new Disciplina(2, "Atletismo", "Carrera de mediofondo"));
            disciplinas.Add(new Disciplina(3, "Atletismo", "Carrera de fondo"));
        }
    }
}
