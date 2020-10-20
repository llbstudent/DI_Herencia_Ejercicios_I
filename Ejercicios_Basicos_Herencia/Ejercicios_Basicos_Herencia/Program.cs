using System;

namespace Ejercicios_Basicos_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Eva", 34);
            Empleado e1 = new Empleado("Antonio", 25, 15200.58);

            Console.WriteLine(p1.toString());
            Console.WriteLine(e1.toString());
        }
    }
}
