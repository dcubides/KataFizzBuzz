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
    public void Si_NumeroEsTres_Debe_RetornarFizz()
    {
        var esperado = new List<string>
        {
            "0", "1", "2", "Fizz"
        };
        
        var resultado = _fizzBuzz.Calcular(3);
        resultado.Should().Equal(esperado);
    }

    [Fact]
    public void Si_NumeroEsCinco_Debe_retornarBuzz()
    {
        var esperado = new List<string>
        {
            "0", "1", "2", "Fizz", "4", "Buzz"
        };
        
        var resultado = _fizzBuzz.Calcular(5);
        resultado.Should().Equal(esperado);
    }

    [Fact]
    public void Si_NumeroEsQuince_Debe_retornarFizzBuzz()
    {
        var esperado = new List<string>
        {
            "0", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz",  "13", "14", "FizzBuzz" 
        };
        
        var resultado = _fizzBuzz.Calcular(15);
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
            if (j == 0)
                listaDeSalida.Add("0");
            else if (j % 3 == 0 && j % 5 == 0)
                listaDeSalida.Add("FizzBuzz");
            else if (j % 3 == 0)
                listaDeSalida.Add("Fizz");
            else if (j % 5 == 0)
                listaDeSalida.Add("Buzz");
            else
                listaDeSalida.Add(j.ToString());
        }
        
        return listaDeSalida;
    }
}