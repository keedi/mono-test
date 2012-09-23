using System;

public class Demo
{
  public static void Main()
    {
      int a = 42;
      object b = a;
      int c = (int) b;

      Console.WriteLine("c: " + c);
    }
}
