namespace TriangleTracker.Models
{
  public class Triangle
  {

    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

      public bool IsEquilateral()
      {
        if (Side1 == Side2 && Side1 == Side3)
        {
          return true;
        }
        else 
        {
          return false;
        }
      }

      public bool IsIsoceles()
      {
        if ((Side1 == Side2 && Side3 != Side1) || (Side2 == Side3 && Side1 != Side2) || (Side1 == Side3 && Side1 != Side3))
        {
          return true;
        }
        else
        {
          return false;
        }
      }

      public bool IsScalene()
      {
        if (Side1 != Side2 && Side2 != Side3 && Side3 != Side1)
        {
          return true;
        }
        else
        {
          return false;
        }
      }

      public string TypeOfTriangle()
      {
        if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
        {
          return "Not a triangle";
        }
        else 
        { 
          if (IsEquilateral())
          {
            return "This is an equilateral triangle";
          }
          else if (IsIsoceles())
          {
            return "This is an isoceles triangle";
          }
          else
          {
            return "This is a scalene triangle";
          }
        }
      }
  }
}