using FluentAssertions;

namespace KatasFizzBuss.Test;

public class FizzBuzzTest
{
    private readonly FizzBuzz.Core.FizzBuzz _fizzBuzz= new();
    
    [Theory]
    [ClassData(typeof(FizzBussTestDatos))]
    public void Si_IngresaNumeros_RetornarMetodoFizzBuzz(int numero, List<string> esperado)
    {
        var resultado = _fizzBuzz.Calcular(numero);
        
        resultado.Should().Equal(esperado);
    }
}