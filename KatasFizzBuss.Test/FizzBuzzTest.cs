using FluentAssertions;

namespace KatasFizzBuss.Test;

public class FizzBuzzTest
{
    private readonly FizzBuzz _fizzBuzz= new();
    [Fact]
    public void Si_NumeroEsCero_Debe_RetornarCero()
    {
        var esperado = new List<string>
        {
            "0"
        };

        var resultado = _fizzBuzz.Calcular(0);

        resultado.Should().Equal(esperado);
    }

    [Fact]
    public void Si_NumeroesUno_Debe_RetornarUno()
    {
        var esperado = new List<string>
        {
            "0", "1"
        };
        
        var resultado = _fizzBuzz.Calcular(1);
        resultado.Should().Equal(esperado);
    }

    [Fact]
    public void Si_NumeroEsTres_Debe_RetornarTres()
    {
        var esperado = new List<string>
        {
            "0", "1", "2", "Fizz"
        };
        
        var resultado = _fizzBuzz.Calcular(3);
        resultado.Should().Equal(esperado);
    }
}


public class FizzBuzz
{
    public List<string> Calcular(int numero)
    {
        var listaDeSalida = new List<string>();
        
        for (int j = 0; j <= numero; j++)
        {
            listaDeSalida.Add(j.ToString());
        }
        
        return listaDeSalida;
    }
}