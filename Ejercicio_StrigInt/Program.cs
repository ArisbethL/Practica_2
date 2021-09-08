using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StrigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, edad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            edad = Console.ReadLine();
            Console.WriteLine("Te llamas \n " + nombre + " y tienes " + edad + "Años ");
            Console.WriteLine("Presione cualquier tecla  para continuar");
            Console.ReadKey();
        }
    }
}
