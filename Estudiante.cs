using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Clase3
{
    public class Estudiante
    {
        //atributos
        private string Nombre; 
        public int Edad;

        //constructores
        public Estudiante() 
        { 
        }

        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        //metodos
        public void Reir()
        {
            Console.WriteLine("me estoy riendo");
        }

        public String cantar(String cancion)
        {
            if (cancion.Equals("Macarena"))
            {
                return "Baila tu cuerp...";
            }
            else 
            {
                return "No me se la canción";
            }
               
        } 

        //setters y getters
        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
    }
}
