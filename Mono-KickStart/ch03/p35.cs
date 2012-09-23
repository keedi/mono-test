using System;

class Demo
{
  public static void Main()
    {
      Human hugo = new Human();
      hugo.GrowUp();
      hugo.DrinkBeer();
    }
}

class Human
{
  public Human()
    {
      Console.WriteLine("Born to be alive ...");
    }

  public void GrowUp()
    {
      Console.WriteLine("Now I am old enough :)");
    }

  public void DrinkBeer()
    {
      Console.WriteLine("I am drinking beer");
    }
}
