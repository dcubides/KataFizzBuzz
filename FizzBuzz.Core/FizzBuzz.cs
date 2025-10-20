using System.Collections.Immutable;

namespace FizzBuzz.Core;

public class FizzBuzz
{
    public ImmutableList<string> Calcular(int numero)
    {
        var range =  Enumerable.Range(0, numero + 1);
        return range.Aggregate(ImmutableList.Create<string>(), (acumulado, siguiente) =>
        {
            if (siguiente == 0)
                return acumulado.Add("0");
            if (siguiente % 3 == 0 && siguiente % 5 == 0)
                return acumulado.Add("FizzBuzz");
            if (siguiente % 3 == 0)
                return acumulado.Add("Fizz");
            if (siguiente % 5 == 0)
                return acumulado.Add("Buzz");
            
            return acumulado.Add(siguiente.ToString());
        });
    }
}