using System;

class Hello
{
  public static int Main()
    {
      Console.WriteLine("Paul is married");
      goto nobodyknows;
      Console.WriteLine("Paul plays around with other women");

nobodyknows:
      Console.WriteLine("Paul is in love");

      return 0;
    }
}
