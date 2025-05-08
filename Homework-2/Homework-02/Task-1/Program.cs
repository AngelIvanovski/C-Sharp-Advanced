using Task_1.Classes;

bool isRunning = true;
while (isRunning)
{
    Console.Clear();

    Console.WriteLine("Search Users by Id, Name, or Age: ");
    string word = Console.ReadLine();

    List<User> foundUser = UserDatabase.Search(word);
    if (foundUser.Count == 0)
    {
        Console.WriteLine("No users found.");
    }
    else
    {
        Console.WriteLine("Found users:");
        foreach (User user in foundUser)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
        }
    }

    Console.WriteLine("Do you want to search again? (y/n)");
    string answer = Console.ReadLine();

    if (answer.ToLower() != "y")
    {
        isRunning = false;
    }
}