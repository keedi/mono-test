using System;

class Demo
{
  public static void Main()
    {
      string name = "Hugo";
      double weight = 89.2;

      Human hugo = new Human(name, weight);
      Console.WriteLine("Name: " + hugo.name);
    }
}

class Human
{
  public string name;
  double weight;

  public Human(string objname, double objweight)
    {
      this.name = objname;
      this.weight = objweight;
    }
}
