using System;

class Hello
{
  public static int Main()
    {
      String[] daughter = new string[3] { "Paula", "Petra", "Clara" };
      daughter[2] = "Eva-Maria";
      Console.WriteLine("daughter: " + daughter[2]);

      return 1;
    }
}
