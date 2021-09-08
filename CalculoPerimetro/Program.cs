using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int h = 7;
            int c = 10;
            int perimetro  = a + h + c;
            Console.WriteLine("El  perimetro del triangulo es : " + perimetro);
            Console.WriteLine("Presiono cualquier letra para continuar");
            Console.ReadKey();
        }
    }
}
