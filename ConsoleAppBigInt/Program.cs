// See https://aka.ms/new-console-template for more information
using System.Numerics;
using ClassLibraryHelper;

Console.WriteLine("Hello, big integer");
var number = ulong.MaxValue;
BigInteger aNumber = new BigInteger(number);
Console.WriteLine($"ulong max value is {aNumber}");
Console.WriteLine("Calcul des nombres premiers à partir de ulong.MaxValue :");
for (int i = 1;i < 3; i++)
{
  BigInteger bNumber = new BigInteger(number) + new BigInteger(i);
  if (Helper.IsPrime(bNumber))
  {
    Console.WriteLine($"{bNumber} is prime");
  }
  else 
  {
    Console.WriteLine($"{bNumber} is not a prime");
  }
}

Console.WriteLine("press any key to exit:");
Console.ReadKey();
