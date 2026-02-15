using System;
namespace COP2360{
  class Octopus{

    // Instance variables for the octupus class
    public string name;
    private string color;

    // Constructor for the octopus class
    public Octopus(string name, string color){
      this.name = name;
      this.color = color;
    }
    // Method allowing access the the private variable
    public string GetColor(){
      return color;
  }
}
  class Program{
    static void Main(){
      Octopus test = new Octopus("Mike","Blue");
      Console.WriteLine(test.name);
      Console.WriteLine(test.GetColor());
      //note doing test.color will result in an error due to the color variable being private
    }
  }
}
