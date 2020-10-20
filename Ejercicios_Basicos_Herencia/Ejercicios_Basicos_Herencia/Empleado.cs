using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Basicos_Herencia
{
    class Empleado : Persona
    {
        private Double sueldo;

        //Cosntructor
        public Empleado(){}

        public Empleado(String nombre, int edad, Double sueldo): base(nombre, edad) {
            this.sueldo = sueldo;
        }

        public String toString()
        {
            String msj =  base.toString();
            msj += ", sueldo " + this.sueldo;
            return msj;
        }
    }
}
