using System;
namespace triangleTracker
{
  public class Triangle
  {
    static void Main()
    {
      Console.WriteLine("Enter number for Side A");
      string stringA = Console.ReadLine();
      int sideA = int.Parse(stringA);
      Console.WriteLine("Enter number for Side B");
      string stringB = Console.ReadLine();
      int sideB = int.Parse(stringB);
      Console.WriteLine("Enter number for Side C");
      string stringC = Console.ReadLine();
      int sideC = int.Parse(stringC);

      if (sideA == sideB && sideB == sideC) {
        Console.WriteLine("The triangle is equilateral!");
      } else if ( sideA == sideB || sideB == sideC || sideC == sideA ) 
      {
        Console.WriteLine("The triangle is isosceles!");  
      } else
      {
        Console.WriteLine("The triangle is scalene!"); 
      }
    }
  }
}




    // if (sideA === sideB && sideB === sideC) {
    //   $("#equal").show();
    //   $("#isos").hide();
    //   $("#scal").hide();
    // } else if ( sideA === sideB || sideB === sideC || sideC === sideA ) {
    //   $("#equal").hide();
    //   $("#isos").show();
    //   $("#scal").hide();
    // } else {
    //   $("#equal").hide();
    //   $("#isos").hide();
    //   $("#scal").show();
    // }