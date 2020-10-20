using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Basicos_Herencia
{
    class Persona
    {
        String nombre;
        int edad;

        //Constructores
        public Persona() { }

        public Persona(String nombre, int edad) {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Modificadores acceso
        public String NOMBRE
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int EDAD
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


        public String toString()
        {
            String msj = "";
            msj += this.nombre + ", edad " + this.edad;
            return msj; 
        }
    }
}
