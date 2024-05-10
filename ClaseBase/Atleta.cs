using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Atleta
    {
        private int atl_ID;
        private string atl_DNI;
        private string atl_Apellido;
        private string atl_Nombre;
        private string atl_Nacionalidad;
        private string atl_Entrenador;
        private char atl_Genero;
        private double atl_Altura;
        private double atl_Peso;
        private DateTime atl_FechaNac;
        private string atl_Dirección;
        private string atl_email;

        public int Atl_ID { get => atl_ID; set => atl_ID = value; }
        public string Atl_DNI { get => atl_DNI; set => atl_DNI = value; }
        public string Atl_Apellido { get => atl_Apellido; set => atl_Apellido = value; }
        public string Atl_Nombre { get => atl_Nombre; set => atl_Nombre = value; }
        public string Atl_Nacionalidad { get => atl_Nacionalidad; set => atl_Nacionalidad = value; }
        public string Atl_Entrenador { get => atl_Entrenador; set => atl_Entrenador = value; }
        public char Atl_Genero { get => atl_Genero; set => atl_Genero = value; }
        public double Atl_Altura { get => atl_Altura; set => atl_Altura = value; }
        public double Atl_Peso { get => atl_Peso; set => atl_Peso = value; }
        public DateTime Atl_FechaNac { get => atl_FechaNac; set => atl_FechaNac = value; }
        public string Atl_Dirección { get => atl_Dirección; set => atl_Dirección = value; }
        public string Atl_email { get => atl_email; set => atl_email = value; }

        public Atleta()
        {
        }

        public Atleta(int atl_ID, string atl_DNI, string atl_Apellido, string atl_Nombre, string atl_Nacionalidad, string atl_Entrenador, char atl_Genero, double atl_Altura, double atl_Peso, DateTime atl_FechaNac, string atl_Dirección, string atl_email)
        {
            Atl_ID = atl_ID;
            Atl_DNI = atl_DNI;
            Atl_Apellido = atl_Apellido;
            Atl_Nombre = atl_Nombre;
            Atl_Nacionalidad = atl_Nacionalidad;
            Atl_Entrenador = atl_Entrenador;
            Atl_Genero = atl_Genero;
            Atl_Altura = atl_Altura;
            Atl_Peso = atl_Peso;
            Atl_FechaNac = atl_FechaNac;
            Atl_Dirección = atl_Dirección;
            Atl_email = atl_email;
        }


    }
}
