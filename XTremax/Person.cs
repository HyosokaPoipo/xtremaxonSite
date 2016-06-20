using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendConsole
{
    public class Person
    {
        public String Name { get; set; }
        public List<Person> Friends { get; set; }

        public Person()
        {
            Friends = new List<Person>();
        }


        public void MakeFriend(Person newFriend)
        {
            if (Friends.Where(f => f.Name == newFriend.Name).FirstOrDefault() != null)
            {
                return;
            }

            Friends.Add(newFriend);
            newFriend.Friends.Add(this);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
