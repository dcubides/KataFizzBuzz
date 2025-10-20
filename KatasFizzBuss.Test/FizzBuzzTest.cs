using FluentAssertions;

namespace KatasFizzBuss.Test;

public class FizzBuzzTest
{
    [Fact]
    public void Si_NumeroEsCero_Debe_RetornarCero()
    {
        var FizzBuzz = new FizzBuzz();
        
        var esperado = new List<string>
        {
            "0"
        };

        var resultado = FizzBuzz.Calcular(0);

        resultado.Should().Be(esperado);
    }
}

public class FizzBuzz
{
    public object Calcular(int i)
    {
        throw new NotImplementedException();
    }
}