using System;
namespace TriangleTracker{
  public class Program{
    public static void Main(){
      Console.WriteLine("What is the unit length of the first side.");
      int sideOne = int.Parse(Console.ReadLine());

      Console.WriteLine("What is the unit length of the second side.");
      int sideTwo = int.Parse(Console.ReadLine());

      Console.WriteLine("What is the unit length of the third side.");
      int sideThree = int.Parse(Console.ReadLine());

      Triangle t = new Triangle(sideOne,sideTwo, sideThree);
    }
  }
}