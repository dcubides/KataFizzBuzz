using System.Collections;
using FluentAssertions;

namespace KatasFizzBuss.Test;

public class FizzBuzzTest
{
    private readonly FizzBuzz _fizzBuzz= new();
   
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
    
    [Theory]
    [ClassData(typeof(FizzBussTestDatos))]
    public void Si_IngresaNumeros_RetornarMetodoFizzBuzz(int numero, List<string> esperado)
    {
        var resultado = _fizzBuzz.Calcular(numero);
        
        resultado.Should().Equal(esperado);
    }
}

public class FizzBussTestDatos: IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 0, new List<string> { "0" } };
        yield return new object[] { 1, new List<string> { "0","1" } };
        yield return new object[] { 2, new List<string> { "0","1","2" } };
        yield return new object[] { 3, new List<string> { "0","1","2","Fizz" } };
        yield return new object[] { 4, new List<string> { "0","1","2","Fizz","4" } };
        yield return new object[] { 5, new List<string> { "0","1","2","Fizz","4", "Buzz" } };
        yield return new object[] { 10, new List<string> { "0", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" } };
        yield return new object[] { 15, new List<string> {  "0", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz",  "13", "14", "FizzBuzz"  } };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
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