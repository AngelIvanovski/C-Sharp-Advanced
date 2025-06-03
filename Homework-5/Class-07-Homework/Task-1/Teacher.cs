using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;
namespace Task_1
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public delegate void NotificationHandler(string message);
        public event NotificationHandler NotificationEvent;

        public void Subscribe(Students student)
        {
            NotificationEvent += student.GetNotification;
            Console.WriteLine($"{student.Name} subscribed to Professor {Name}'s notifications.");
        }

        public void Unsubscribe(Students student)
        {
            NotificationEvent -= student.GetNotification;
            Console.WriteLine($"{student.Name} unsubscribed from Professor {Name}'s notifications.");
        }

        public void SendNotification(string message = "You have a new notification.")
        {
            Console.WriteLine("Sending Notifications to all students...");
            if (NotificationEvent != null)
            {
                NotificationEvent(message);
            }
        }
    }
}