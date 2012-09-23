using System;

class Loop
{
  public static void Main()
    {
      string[] children = { "Peter", "Paul", "Josef" };

      foreach (string child in children)
        {
          Console.WriteLine("Child: " + child);
        }
    }
}
