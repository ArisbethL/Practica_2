using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        // cometar Ctrl + k +c
        //descomenatar Ctrl + k + u
        //crear tres variables de tipo INT y asignarle valores estaticos.
        //crear una variable de tipo INT la cual guardara la SUMA de las tres variables anteriores 
        //mostrar en pantalla el valor SUM
        //con el siguiente mensaje "el valor de SUMA es:"<suma>


        static void Main(string[] args)
        {
         
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El valor de Suma es: " + suma);
            Console.WriteLine("Presiono cualquier letra para continuar");
            Console.ReadKey();
        }
    }
}
