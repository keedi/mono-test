using System;

class Hello
{
  public static int Main()
    {
      String error = "C:\new_pics";
      Console.WriteLine("Error: " + error);

      String correct = @"C:\new_pics";
      Console.WriteLine("Correct: " + correct);

      return 1;
    }
}
