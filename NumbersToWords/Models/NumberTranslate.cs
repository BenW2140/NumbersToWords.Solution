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
  }
}