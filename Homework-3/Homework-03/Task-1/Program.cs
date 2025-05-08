using Task_1;

PrintInConsole print = new PrintInConsole();

print.Print("Hello World");
print.Print(102.5);


List<string> strings = new List<string> { "Toyota", "Corolla" };
print.PrintCollection(strings);


Console.WriteLine("______________");
List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
print.PrintCollection(numbers);

