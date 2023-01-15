// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, big integer");
var number = ulong.MaxValue;
BigInteger aNumber = new BigInteger(number);
Console.WriteLine($"ulong max value is {aNumber}");
Console.WriteLine("Calcul des nombres premiers à partir de ulong.MaxValue :");
for (int i = 1;i < 10; i++)
{
  BigInteger bNumber = new BigInteger(number) + new BigInteger(i);
  if (IsPrime(bNumber))
  {
    Console.WriteLine($"{bNumber} is prime");
  }
  else 
  {
    Console.WriteLine($"{bNumber} is not a prime");
  }
}

bool IsPrime(BigInteger bNumber)
{
  if (bNumber == 0 || bNumber == 1)
  {
    return false;
  }

  if (bNumber == 2)
  {
    return true;
  }

  if (bNumber == 3)
  {
    return true;
  }

  if (bNumber % 2 == 0 )
  {
    return false;
  }
  if (bNumber == 5 )
  {
    return true;
  }


}

Console.WriteLine("press any key to exit:");
Console.ReadKey();

