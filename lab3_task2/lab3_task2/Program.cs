using System;

public class Rectangle
{
    public double SideA { get; }
    public double SideB { get; }

    public Rectangle(double a, double b)
    {
        SideA = a;
        SideB = b;
    }

    public double Area()
    {
        return SideA * SideB;
    }

    public double Perimeter()
    {
        return 2 * (SideA + SideB);
    }

    public bool IsSquare()
    {
        return SideA == SideB;
    }
}

public class ArrayRectangles
{
    private Rectangle[] rectangleArray;

    public ArrayRectangles(int n)
    {
        rectangleArray = new Rectangle[n];
    }

    public ArrayRectangles(params Rectangle[] rectangles)
    {
        rectangleArray = rectangles;
    }

    public bool AddRectangle(Rectangle rectangle)
    {
        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] == null)
            {
                rectangleArray[i] = rectangle;
                return true;
            }
        }
        return false;
    }

    public int NumberMaxArea()
    {
        double maxArea = double.MinValue;
        int maxIndex = -1;
        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] != null && rectangleArray[i].Area() > maxArea)
            {
                maxArea = rectangleArray[i].Area();
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    public int NumberMinPerimeter()
    {
        double minPerimeter = double.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] != null && rectangleArray[i].Perimeter() < minPerimeter)
            {
                minPerimeter = rectangleArray[i].Perimeter();
                minIndex = i;
            }
        }
        return minIndex;
    }

    public int NumberSquare()
    {
        int squareCount = 0;
        foreach (var rectangle in rectangleArray)
        {
            if (rectangle != null && rectangle.IsSquare())
            {
                squareCount++;
            }
        }
        return squareCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayRectangles arrayRectangles = new ArrayRectangles(5);

        arrayRectangles.AddRectangle(new Rectangle(4, 5));
        arrayRectangles.AddRectangle(new Rectangle(3, 3));
        arrayRectangles.AddRectangle(new Rectangle(6, 7));

        Console.WriteLine("Number of squares: " + arrayRectangles.NumberSquare());
        Console.WriteLine("Index of rectangle with maximum area: " + arrayRectangles.NumberMaxArea());
        Console.WriteLine("Index of rectangle with minimum perimeter: " + arrayRectangles.NumberMinPerimeter());
    }
} 