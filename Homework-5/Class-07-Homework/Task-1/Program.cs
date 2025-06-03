using Task_1;

Teacher professorJohn = new Teacher
{
    Name = "John",
    Age = 50,
    Email = "john@example.com",
    Subject = "Math"
};

Students alice = new Students { Name = "Alice", Age = 20, Email = "alice@example.com", Subject = "Math" };
Students bob = new Students { Name = "Bob", Age = 21, Email = "bob@example.com", Subject = "Math" };
Students charlie = new Students { Name = "Charlie", Age = 22, Email = "charlie@example.com", Subject = "Math" };


professorJohn.Subscribe(alice);
professorJohn.Subscribe(bob);
professorJohn.Subscribe(charlie);

Console.WriteLine();
Console.WriteLine("Sending notifications....");
professorJohn.SendNotification("Notification from Professor John: Class for Math will start at 10 AM.");


professorJohn.Unsubscribe(alice);
professorJohn.Unsubscribe(charlie);

Console.WriteLine();
Console.WriteLine("Sending notifications....");

professorJohn.SendNotification("Notification from Professor John: Class for Math will start at 10 AM.");