using System;

class Hello
{
  public static int Main()
    {
      String input;
      String res = "unknown";

      // Reading from the keyboard
      Console.Write("Enter a value: ");
      input = Console.ReadLine();

      Console.WriteLine("Input: [" + input + "]");

      // Read the translation
      switch (input)
        {
        case "Fernseher":
          res = "TV";
          break;
        case "Honig":
          res = "honey";
          break;
        case "Geschlecht":
        case "Sex":
          res = "sex";
          break;
        default:
          res = "what the";
          break;
        }

      Console.WriteLine("Result: " + res);

      return 0;
    }
}
