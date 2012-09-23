using System;

class Hello
{
  public static int Main()
    {
      string[,] data = new string[2,2];

      data[0, 0] = "Paul";
      data[1, 0] = "Rudi";
      data[0, 1] = "Ruth";
      data[1, 1] = "Evi";

      Console.WriteLine("Value: " + data[1, 1]);

      return 1;
    }
}
