using System;

class Demo
{
  public static void Main()
    {
      int a = 42;
      object b = a;
      Console.WriteLine("before: " + a);

      Increment(b);
      int c = (int) b;
      Console.WriteLine("after: " + c);
    }

  static void Increment(Object x)
    {
      int y = (int) x;
      y++;
      x = y;
    }
}
