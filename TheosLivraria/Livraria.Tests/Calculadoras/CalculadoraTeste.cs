using Livraria.Domain.Entidades;
using System.Collections.Generic;
using Xunit;

namespace Livraria.Tests.Calculadoras
{
    public class CalculadoraTeste
    {
        public CalculadoraTeste()
        {

        }

        [Fact]
        public void DeveSomarDoisValores()
        {
            //Arrange
            var calculator = new Calculadora();
            int valor1 = 1;
            int valor2 = 2;

            //act
            var result = calculator.Somar(valor1, valor2);

            //assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void DeveSomarDoisValoresComTheory(int valor1, int valor2, int esperado)
        {
            //arrange
            var calculator = new Calculadora();

            //act
            var resultado = calculator.Somar(valor1, valor2);

            //assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void DeveSomarDoisValoresComTheoryComPropriedadeMemberData(int valor1, int valor2, int esperado)
        {
            //arrange
            var calculator = new Calculadora();

            //act
            var resultado = calculator.Somar(valor1, valor2);

            //assert
            Assert.Equal(esperado, resultado);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
            new object[] { int.MinValue, -1, int.MaxValue },
            };
    }
}
