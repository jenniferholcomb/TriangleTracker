using System;
using TriangleTracker.Models;

namespace ShapeTracker 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a number: ");
      int input1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a second number: ");
      int input2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a third number: ");
      int input3 = int.Parse(Console.ReadLine());

      Triangle inputTriangle = new Triangle(input1, input2, input3);
      inputTriangle.Side1 = input1;
      inputTriangle.Side2 = input2;
      inputTriangle.Side3 = input3;

      string output = inputTriangle.TypeOfTriangle();
      Console.WriteLine(output);
    }
  }
}