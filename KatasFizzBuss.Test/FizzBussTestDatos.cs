using System.Collections;

namespace KatasFizzBuss.Test;

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