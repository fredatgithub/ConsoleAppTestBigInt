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

bool IsPrime(BigInteger number)
{
  if (number == 0 || number == 1)
  {
    return false;
  }

  if (number == 2)
  {
    return true;
  }

  if (number == 3)
  {
    return true;
  }

  if (number % 2 == 0 )
  {
    return false;
  }
  if (number == 5 )
  {
    return true;
  }

  for (int i = 5; i <= Math.Sqrt(number); i++)
  {
    if (number/i == 0)
    {
      return false;
    }
  }

  return true;
}

Console.WriteLine("press any key to exit:");
Console.ReadKey();

