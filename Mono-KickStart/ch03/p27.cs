using System;

class Loop
{
  public static int Main()
    {
      bool   keepdoing = true;
      string input;

      while (keepdoing == true)
        {
          Console.Write("Input: ");
          input = Console.ReadLine();
          Console.WriteLine("Output: [" + input + "]");

          if (input.Length < 3)
            keepdoing = false;
        }

      return 0;
    }
}
