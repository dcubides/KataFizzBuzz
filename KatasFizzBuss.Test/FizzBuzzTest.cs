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

        resultado.Should().Equal(esperado);
    }

    [Fact]
    public void Si_NumeroesUno_Debe_RetornarUno()
    {
        var  FizzBuzz = new FizzBuzz();
        
        var esperado = new List<string>
        {
            "0", "1"
        };
        
        var resultado = FizzBuzz.Calcular(1);
        resultado.Should().Equal(esperado);
    }
}


public class FizzBuzz
{
    public List<string> Calcular(int i)
    {
        return new List<string>
        {
            "0"
        };
    }
}