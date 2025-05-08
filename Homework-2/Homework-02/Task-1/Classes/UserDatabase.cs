using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();
        static UserDatabase()
        {
            Users.Add(new User(1, "Aleksandar", 34));
            Users.Add(new User(2, "Elena", 28));
            Users.Add(new User(3, "Goran", 45));
            Users.Add(new User(4, "Kristina", 37));
            Users.Add(new User(5, "Dejan", 50));
        }


        public static List<User> Search(string word)
        {
            List<User> result = new List<User>();

            bool isNumber = int.TryParse(word, out int number);

            foreach (User user in Users)
            {
                if (user.Name.ToLower().Contains(word.ToLower()))
                {
                    result.Add(user);
                }
                else if (isNumber && user.Id == number || user.Age == number)
                {
                    result.Add(user);
                }
            }
            return result;
        }
    }
}