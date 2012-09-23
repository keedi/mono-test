using System;

public class Demo
{
  public static void Main()
    {
      int x = 3;
      int y = 5;

      swap(ref x, ref y);
      Console.WriteLine("x: {0} - y: {1}", x, y);
    }

  static void swap(ref int a, ref int b)
    {
      int c = a;
      a = b;
      b = c;

      Console.WriteLine("a: {0} - b: {1}", a, b);
    }
}
