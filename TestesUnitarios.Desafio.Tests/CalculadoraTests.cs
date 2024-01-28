using TestesUnitarios.Desafio.Console.Services;

namespace CalculadoraTests;


public class CalculadoraTests
{
    [Theory]
    [InlineData(2, 3, 5)] // a + b = 5
    [InlineData(-1, 1, 0)] // a + b = 0
    [InlineData(0, 0, 0)]  // a + b = 0
    [InlineData(-5, -2, -7)] // a + b = -7
    public void TesteSomar(int a, int b, int resultadoEsperado)
    {
        // Arrange (Preparação)
        var calculadora = new Calculadora();

        // Act (Ação)
        int resultado = calculadora.Somar(a, b);

        // Assert (Assertiva de Verificação)
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(5, 3, 2)] // a - b = 2
    [InlineData(1, 1, 0)] // a - b = 0
    [InlineData(0, 0, 0)]  // a - b = 0
    [InlineData(-5, -2, -3)] // a - b = -3
    public void TesteSubtrair(int a, int b, int resultadoEsperado)
    {
        // Arrange (Preparação)
        var calculadora = new Calculadora();

        // Act (Ação)
        int resultado = calculadora.Subtrair(a, b);

        // Assert (Assertiva de Verificação)
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Theory]
    [InlineData(2, 3, 6)] // a * b = 6
    [InlineData(-1, 1, -1)] // a * b = -1
    [InlineData(0, 5, 0)]  // a * b = 0
    [InlineData(-5, -2, 10)] // a * b = 10
    public void TesteMultiplicar(int a, int b, int resultadoEsperado)
    {
        // Arrange (Preparação)
        var calculadora = new Calculadora();

        // Act (Ação)
        int resultado = calculadora.Multiplicar(a, b);

        // Assert (Assertiva de Verificação)
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Theory]
    [InlineData(6, 3, 2)] // a / b = 2
    [InlineData(0, 5, 0)] // a / b = 0
    [InlineData(-10, -2, 5)]  // a / b = 5
    public void TesteDividir(int a, int b, int resultadoEsperado)
    {
        // Arrange (Preparação)
        var calculadora = new Calculadora();

        // Act (Ação)
        int resultado = calculadora.Dividir(a, b);

        // Assert (Assertiva de Verificação)
        Assert.Equal(resultadoEsperado, resultado);
    }

    // Teste para verificar se a divisão por zero gera uma exceção
    [Fact]
    public void TesteDividirPorZero()
    {
        // Arrange (Preparação)
        var calculadora = new Calculadora();

        // Act (Ação)
        Assert.Throws<ArgumentException>(() =>

        // Assert (Assertiva de Verificação)
        calculadora.Dividir(10, 0));
    }
}
