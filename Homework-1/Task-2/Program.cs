using Task_2.Classes;
#region Circle
Console.WriteLine("enter a radius for the circle");
double radius = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle(radius);
Console.WriteLine($"the area of the circle is {circle.GetArea()}");
#endregion
Console.WriteLine("===============================================");
#region Rectangle
Console.WriteLine("enter the length of the rectangle");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the width of the rectangle");
double width = Convert.ToDouble(Console.ReadLine());
Rectangle rectangle = new Rectangle(length, width);
Console.WriteLine($"the area of the rectangle is {rectangle.GetArea()}");
#endregion

#region Triangle

Console.WriteLine("enter the base length of the triangle");
double baseLength = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the height of the triangle");
double height = Convert.ToDouble(Console.ReadLine());

Triangle triangle = new Triangle(baseLength, height);

Console.WriteLine($"the area of the triangle is {triangle.GetArea()}");
#endregion