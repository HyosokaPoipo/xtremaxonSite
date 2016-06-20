using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FriendConsole
{
    public class Program
    {
        public static List<Person> personList = null;

        static void Main(string[] args)
        {
            Person personA = GetCurrentPerson("Person A");
            Person personD = GetCurrentPerson("Person D");
            Person personF = GetCurrentPerson("Person F");

            personList = new List<Person>();
            int minimumNuberOfHops = FindMinimumNumberOfHops(personA, personD);
            Console.WriteLine("Minimum number of Hops:" + minimumNuberOfHops);

            personList = new List<Person>();
            int noFriends = FindNoFriendsCoveredInXHops(personF, 2);
            Console.WriteLine("Number of  Friends Covered in: " + noFriends);


            Console.ReadKey();
        }


        public static int FindNoFriendsCoveredInXHops(Person a, int noHops)
        {
            //Write your codes....
            return 0;
        }


        public static int FindMinimumNumberOfHops(Person a, Person b)
        {
            //Write your codes....
            return 0;
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
