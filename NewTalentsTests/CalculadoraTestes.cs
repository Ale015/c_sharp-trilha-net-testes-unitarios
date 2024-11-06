using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewTalents;

namespace NewTalentsTests
{
    public class CalculadoraTestes
    {
        private Calculadora _calc;

        public CalculadoraTestes(){
            _calc = new Calculadora();
        }

    
        [Theory]
        [InlineData(1,2,3)]
        public void TestSomar(int num1, int num2, int resultado)
        {

            int resultadoCalculado = _calc.Somar(num1,num2);

            Assert.Equal(resultadoCalculado, resultado);
        }


        [Theory]
        [InlineData(3,2,1)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {

            int resultadoCalculado = _calc.Subtrair(num1,num2);

            Assert.Equal(resultadoCalculado, resultado);
        }


        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4,5,20)]
        public void Testmultiplicar(int num1, int num2, int resultado)
        {

            int resultadoCalculado = _calc.Multiplicar(num1,num2);

            Assert.Equal(resultadoCalculado, resultado);
        }
        [Theory]
        [InlineData(6,2,3)]
        public void TesteDividir(int num1, int num2, int resultado)
        {

            int resultadoCalculado = _calc.Dividir(num1,num2);

            Assert.Equal(resultadoCalculado, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero(){
            Assert.Throws<DivideByZeroException>( () => _calc.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico(){

            _calc.Somar(2,1);
            _calc.Somar(3,4);
            _calc.Somar(2,6);
            _calc.Somar(1,3);
            _calc.Somar(4,5);
             
            List<string> lista = _calc.Historico();
            
            Assert.NotEmpty(_calc.Historico());
            Assert.Equal(3, lista.Count());
        }
         
    }
}