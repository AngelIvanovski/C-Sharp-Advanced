//Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter(). Create subclasses Circle and Triangle that extend the Shape class
// and implement the respective methods to calculate the area and perimeter of each shape.


using Task_3;

Console.WriteLine("Enter the radius to calculate the area and the perimeter of a circle:");
double radius = Convert.ToDouble(Console.ReadLine());

Circle circle = new Circle(radius);

Console.WriteLine($"the area of the circle is {circle.CalculateArea()} ");

Console.WriteLine($"the perimeter of the circle is {circle.CalculatePerimeter()}");


