using System.Numerics;

namespace ClassLibraryHelper
{
  public static class Helper
  {
    public static bool IsPrime(BigInteger number)
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

      if (number % 2 == 0)
      {
        return false;
      }
      if (number == 5)
      {
        return true;
      }

      BigInteger squareRoot = SquareRoot(number);
      var sqrt = Math.Pow(Math.E, BigInteger.Log(number) / 2);

      for (int i = 5; i <= sqrt; i += 2)
      {
        if (number % i == 0)
        {
          return false;
        }
      }

      return true;
    }

    public static BigInteger SquareRoot(BigInteger number)
    {
      BigInteger result = new BigInteger(1);
      while (result * result < number)
      {
        result++;
      }

      return result;
    }
  }
}