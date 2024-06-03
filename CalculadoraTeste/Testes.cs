namespace CalculadoraTeste;
using Calculadora.Models;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TesteSomar(int a, int b, int resultadoEsperado)
    {
       //Arrange
       Calculadora calc = new Calculadora();
       
       //Act 
       var resultado = calc.Somar(a,b);

       //Assert
       Assert.Equal(resultadoEsperado, resultado);
    }

     [Theory]
    [InlineData(2,1,1)]
    [InlineData(9,5,4)]
    public void TesteSubtrair(int a, int b, int resultadoEsperado)
    {
       //Arrange
       Calculadora calc = new Calculadora();
       
       //Act 
       var resultado = calc.Subtrair(a,b);

       //Assert
       Assert.Equal(resultadoEsperado, resultado);
    }

     [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TesteMultiplicar(int a, int b, int resultadoEsperado)
    {
       //Arrange
       Calculadora calc = new Calculadora();
       
       //Act 
       var resultado = calc.Multiplicar(a,b);

       //Assert
       Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(10,2,5)]
    [InlineData(20,5,4)]
    public void TesteDividir(int a, int b, int resultadoEsperado)
    {
       //Arrange
       Calculadora calc = new Calculadora();
       
       //Act 
       var resultado = calc.Dividir(a,b);

       //Assert
       Assert.Equal(resultadoEsperado, resultado);
 }
    [Fact]

    public void TestarDivisaoPorZero(){
        Calculadora calc = new Calculadora();

        Assert.Throws <DivideByZeroException>(()=> calc.Dividir(3,0));
    }
[Fact]
    public void TestarHistorico(){
        Calculadora calc = new Calculadora();

        calc.Somar(1,2);
        calc.Subtrair(2,1);
        calc.Multiplicar(1,2);
        calc.Dividir(2,1);

        var lista = calc.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}