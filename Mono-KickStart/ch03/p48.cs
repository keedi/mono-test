using System;

class Demo
{
  public enum Days: byte
    {
      monday,
      tuesday,
      wednesday,
      thursday,
      friday,
      saturday,
      sunday
    }

  public static void Main()
    {
      Array days = Enum.GetValues(typeof(Demo.Days));
      foreach (Days day in days)
        {
          Console.WriteLine(
            day + " = " + day.ToString("d")
          );
        }
    }
}
