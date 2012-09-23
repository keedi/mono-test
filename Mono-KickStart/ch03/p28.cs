using System;

class Loop
{
  public static int Main()
    {
      bool   again = true;
      string input;

      do
        {
          Console.WriteLine("Y: yes");
          Console.WriteLine("N: no");
          Console.Write("Input: ");

          input = Console.ReadLine();
          Console.WriteLine("Output: [" + input + "]");

          if (input == "N")
            again = false;
        } while (again == true);

      return 0;
    }
}
