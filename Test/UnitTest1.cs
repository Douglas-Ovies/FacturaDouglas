
using ConsoleApp2;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculadora nokia = new Calculadora();
            var re = nokia.Sumar(5, 5);
            Xunit.Assert.Equal(10, re);
        }
        [Fact]
        public void Test2()
        {
            Calculadora nokia = new Calculadora();
            var re = nokia.Restar(5, 5);
            Xunit.Assert.Equal(0, re);
        }

    }
}