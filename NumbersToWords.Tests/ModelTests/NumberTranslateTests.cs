using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;

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

    [TestMethod]
    public void TranslateOnes_ConvertOnesToEnglish_Dictionary()
    {
      Dictionary<int, string> ones = new Dictionary<int, string> {
        {0, "Zero"},
        {1, "One"}, 
        {2, "Two"}, 
        {3, "Three"}, 
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"}};
      CollectionAssert.AreEqual(ones, NumberTranslate.TranslateOnes());
    }

    [TestMethod]
    public void TranslateTens_ConvertTensToEnglish_Dictionary()
    {
      Dictionary<int, string> tens = new Dictionary<int, string> {
        {10, "Ten"},
        {11, "Eleven"}, 
        {12, "Twelve"}, 
        {13, "Thirteen"}, 
        {14, "Fourteen"},
        {15, "Fifteen"},
        {16, "Sixteen"},
        {17, "Seventeen"},
        {18, "Eighteen"},
        {19, "Nineteen"},
        {20, "Twenty"},
        {30, "Thirty"},
        {40, "Forty"},
        {50, "Fifty"},
        {60, "Sixty"},
        {70, "Seventy"},
        {80, "Eighty"},
        {90, "Ninety"}};
      CollectionAssert.AreEqual(tens, NumberTranslate.TranslateTens());
    }

    public void TranslateLargeNumbers_ConvertLargeNumbersToEnglish()
    {
      Dictionary<int, string> largeNumbers = new Dictionary<int, string> {
        {100, "Hundred"},
        {1000, "Thousand"}, 
        {1000000, "Million"}, 
        {1000000000, "Billion"}};
      CollectionAssert.AreEqual(largeNumbers, NumberTranslate.TranslateLargeNumbers());
    }
  }
}