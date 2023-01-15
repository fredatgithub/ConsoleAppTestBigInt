using System;
//using System.Numerics; // .NET7

namespace ConsoleAppTestBigInt
{
  internal class Program
  {
    static void Main(string[] arguments)
    {
      var number = ulong.MaxValue;
      Console.WriteLine(number);
      Console.WriteLine(string.Format("###,###", number));
      string numberInString = number.ToString();
      Console.WriteLine(numberInString);

      Console.WriteLine("press any key to exit:");
      Console.ReadKey();
    }

    private bool IsEven(ulong number)
    {
      return number % 2 == 0;
    }
  }
}
