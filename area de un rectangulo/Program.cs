using Geometry;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = user.GetUser("Enter the length of the rectangle:");
            double width = user.GetUser("Enter the width of the rectangle:");

            Rectangle rectangle = new Rectangle(length, width);
            double area = rectangle.CalculateArea();

            Console.WriteLine($"The area of the rectangle is: {area}");
        }
    }
}
