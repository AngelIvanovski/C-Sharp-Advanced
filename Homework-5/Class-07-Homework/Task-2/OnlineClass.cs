using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class OnlineClass
    {
      
        public delegate void RestrictedUserAction(string name);

        public event RestrictedUserAction RestrictedUserDetected;


        private string[] restrictedUsers = { "bob", "jill", "alice" };

        public bool IsRestrictedUser(string name)
        {
            string lowerName = name.ToLower();
            foreach (string restricted in restrictedUsers)
            {
                if (lowerName == restricted)
                {
                    return true;
                }
            }
            return false;
        }

      
        public void TriggerRestrictedUserEvent(string name)
        {
            if (RestrictedUserDetected != null)
            {
                RestrictedUserDetected(name);
            }
        }
    }
}

