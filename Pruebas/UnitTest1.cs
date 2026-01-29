using ConsoleApp1;
using System.Diagnostics.CodeAnalysis;

namespace Pruebas
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculadora nokia = new Calculadora();
            var suma = nokia.Sumar(5, 7);
            Assert.Equal(12, suma);

        }
    }
}