using System;

class Hello
{
  public static int Main()
    {
      string[,] a = new string[2,2];
      string[,,,] b = new string[2,2,2,2];
      string[,,,,,] c = new string[2,2,2,2,2,2];

      Console.WriteLine("a: " + a.Rank);
      Console.WriteLine("b: " + b.Rank);
      Console.WriteLine("c: " + c.Rank);

      return 1;
    }
}
