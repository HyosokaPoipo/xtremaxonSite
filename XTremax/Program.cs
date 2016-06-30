using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FriendConsole
{
    public class Program
    {
        public static List<Person> personList = null;
        private static List<Person> personHopsTable = new List<Person>();

        static void Main(string[] args)
        {
            Person personA = GetCurrentPerson("Person A");
            Person personD = GetCurrentPerson("Person D");
            Person personF = GetCurrentPerson("Person F");
            Person personC = GetCurrentPerson("Person C");


            personList = new List<Person>();
            int minimumNuberOfHops = FindMinimumNumberOfHops(personF, personD);
            Console.WriteLine("Minimum number of Hops:" + minimumNuberOfHops);

            personList = new List<Person>();
            int noFriends = FindNoFriendsCoveredInXHops(personA, 2);
            Console.WriteLine("Number of  Friends Covered in: " + noFriends);

            //viewFriends(personA);
            Console.WriteLine("Isi personHopsTable :");
            foreach (Person test in personHopsTable) Console.WriteLine(test.ToString());
            Console.ReadKey();
        }


        public static int FindNoFriendsCoveredInXHops(Person a, int noHops)
        {
            personHopsTable.Clear();
            for (int i = 0; i < a.Friends.Count; i++)
              {
                  if (!personHopsTable.Contains(a.Friends[i])) personHopsTable.Add(a.Friends[i]);
                   countFriendsNum(a.Friends[i], noHops-1);                    
             }

            return personHopsTable.Count-1;
        }

        public static void countFriendsNum(Person a, int hops)
        {
            if (hops > 0)
            {
                for (int i = 0; i < a.Friends.Count; i++)
                {
                    if (!personHopsTable.Contains(a.Friends[i])) personHopsTable.Add(a.Friends[i]);
                    countFriendsNum(a.Friends[i], hops-1);
                }
            }
            
        }


        public static int FindMinimumNumberOfHops(Person a, Person b)
        {
            int result = int.MaxValue;
            
            for (int i=0; i < a.Friends.Count; i++)            {
                
                if (a.Friends[i].ToString().Equals(b.ToString())) return 1;
                else
                {
                    Trace.WriteLine("nilai i dihops " + i);
                    int temp = getMin(a.Friends[i], b, 1, a);
                    if (temp < result) result = temp;
                    
                }
                
            }
            return result;
        }

        private static int getMin(Person a, Person b, int sum, Person prev)
        {
            Trace.WriteLine("**************getMin Started**************");
            Trace.WriteLine("Person a : "+a.ToString());
            Trace.WriteLine("Person b : " + b.ToString());
            Trace.WriteLine("Sum: " + sum);
            Trace.WriteLine("Person prev : " + prev.ToString());
            int result = int.MaxValue;
            for (int i = 0; i < a.Friends.Count; i++)
            {
                Trace.WriteLine("i getMin "+i);
                if (a.Friends[i] == prev) continue;
                else if (a.Friends[i].ToString().Equals(b.ToString())) return sum+1;
                sum += 1;
                int temp = getMin(a.Friends[i], b, sum, a);
                if (temp < result) result = temp;
            }

            return result;
        }


        public static void viewFriends(Person a)
        {
            for (int i = 0; i < a.Friends.Count; i++)
            {
                Console.WriteLine(a.Friends[i].ToString());
            }

        }

        public static Person GetCurrentPerson(String name)
        {
            List<Person> personList = new List<Person>();

            Person personA = new Person() { Name = "Person A" };
            Person personB = new Person() { Name = "Person B" };
            Person personC = new Person() { Name = "Person C" };
            Person personD = new Person() { Name = "Person D" };
            Person personE = new Person() { Name = "Person E" };
            Person personF = new Person() { Name = "Person F" };

            personList.Add(personA);
            personList.Add(personB);
            personList.Add(personC);
            personList.Add(personD);
            personList.Add(personE);
            personList.Add(personF);

            personA.MakeFriend(personB);
            personA.MakeFriend(personE);
            personB.MakeFriend(personC);
            personC.MakeFriend(personF);
            personC.MakeFriend(personD);
            personD.MakeFriend(personE);

            return personList.Where(p => p.Name == name).FirstOrDefault();

        }
    }
}
