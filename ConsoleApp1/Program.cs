
using ConsoleApp1;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        var r = calculadora.Sumar(6, 6);
        Console.WriteLine(r);
    }

}


