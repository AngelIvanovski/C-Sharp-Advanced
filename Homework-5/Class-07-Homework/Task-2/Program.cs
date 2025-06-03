
using Task_2;

OnlineClass onlineClass = new OnlineClass();


onlineClass.RestrictedUserDetected += HandleRestrictedUser;


Console.Write("Enter your name: ");
string userName = Console.ReadLine();


if (onlineClass.IsRestrictedUser(userName))
{
    onlineClass.TriggerRestrictedUserEvent(userName);
}
else
{
    Console.WriteLine($"Welcome {userName}.");
}



     void HandleRestrictedUser(string name)
{
    Console.WriteLine($"{name} Users Found.");
    Console.WriteLine("Sending Email to Administration.");
    Console.WriteLine("Email Sent.");
    Console.WriteLine("Warning Alarm Started.");
    Console.WriteLine("Logging out.");
}
