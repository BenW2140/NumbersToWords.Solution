using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberTranslate
  {
    public static int number { get; set; }
    public static bool IsNumber()
    {
      if (number.GetType() == typeof(int))
      {
        return true;
      }
      return false;
    }

    public static Dictionary<int, string> TranslateOnes()
    {
      Dictionary<int, string> onesColumn = new Dictionary<int, string> {
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
      return onesColumn;
    }

    public static Dictionary<int, string> TranslateTens()
    {
      Dictionary<int, string> tensColumn = new Dictionary<int, string> {
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
      return tensColumn;
    }

    public static Dictionary<int, string> TranslateLargeNumbers()
    {
      Dictionary<int, string> bigNumbers = new Dictionary<int, string> {
        {100, "Hundred"},
        {1000, "Thousand"}, 
        {1000000, "Million"}, 
        {1000000000, "Billion"}};
      return bigNumbers;
    }
  }
}