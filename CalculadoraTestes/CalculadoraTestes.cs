using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplementacao _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Fact] // Indica o metodo é cenario de teste
    public void DeveSomar5com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }
}