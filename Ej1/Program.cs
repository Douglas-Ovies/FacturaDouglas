using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Nombres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            string nom = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n {nom}! \n <3");
            Console.ResetColor();
            Console.WriteLine("presiona cualquier tecla ara salir");
            Console.ReadKey();
        }
    }
}

