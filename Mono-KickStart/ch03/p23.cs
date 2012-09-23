using System;

class Hello
{
  public static int Main(String[] args)
    {
      Console.WriteLine("Input: " + args[0]);

      if (args[0] == "100")
        {
          Console.WriteLine("correct...");
          return 0;
        }
      else if (args[0] == "0")
        {
          Console.WriteLine("not correct...");
        }
      else
        {
          Console.WriteLine("error :(");
        }

      return 1;
    }
}
