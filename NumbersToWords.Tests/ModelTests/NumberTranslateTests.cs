using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTranslateTests
  {
    [TestMethod]
    public void IsNumber_CheckIfUserEnteredANumber_Bool()
    {
      Assert.AreEqual(true, NumberTranslate.IsNumber());
    }
  }
}