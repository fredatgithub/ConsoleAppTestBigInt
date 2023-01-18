using ClassLibraryHelper;
using System.Numerics;

namespace BigIntPrime.TestProject
{
  [TestClass]
  public class UnitTestBigIntPrime
  {
    [TestMethod]
    public void TestMethod_SquareRoot_100()
    {
      BigInteger source = new BigInteger(100);
      BigInteger expected = new BigInteger(10);
      var result = Helper.SquareRoot(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsPrime_100()
    {
      BigInteger source = new BigInteger(100);
      var expected = false;
      var result = Helper.IsPrime(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsPrime_int_Max_Value()
    {
      BigInteger source = new BigInteger(int.MaxValue);
      var expected = true;
      var result = Helper.IsPrime(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestMethod_IsPrime_int_Max_Value_moins_1()
    {
      BigInteger source = new BigInteger(int.MaxValue - 1);
      var expected = false;
      var result = Helper.IsPrime(source);
      Assert.AreEqual(expected, result);
    }
  }
}