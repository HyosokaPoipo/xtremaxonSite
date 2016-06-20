using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTremax
{
    class Program
    {
        public class Point
        {
            public double X;
            public double Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        static void Main(string[] args)
        {
            //PLEASE DO NOT CHANGE THE MAIN CODE HERE

            Dictionary<String, Point> Points = new Dictionary<String, Point>();
            Points.Add("Point 1", new Point(0.0, 0.0));
            Points.Add("Point 2", new Point(10.1, -10.1));
            Points.Add("Point 3", new Point(-12.2, 12.2));
            Points.Add("Point 4", new Point(38.3, 38.3));
            Points.Add("Point 5", new Point(79.99, 179.99));

            
            PrintClosestPoints(Points);
            Console.ReadKey();


            Console.ReadLine();
        }

        /**
       * Write a method called PrintClosestPoints that takes in a list of XY coordinates(an Dictionary containing Point id and X Y values pairs). 
       * The method need to calculate the closest point of each point in input list.         
       * Point 1 closest point is - Point 2        
       * Point 2 closest point is - Point 1        
       * Point 3 closest point is - Point 1        
       * Point 4 closest point is - Point 1        
       * Point 5 closest point is - Point 4
       * 
       **/
        public static void PrintClosestPoints(Dictionary<string, Point> Points)
        {
            //***** CODES - Amend Codes below this segment ******
            //get all of keys available
            List<String> myKeys = new List<string>();
            foreach (string key in Points.Keys) myKeys.Add(key);


            double currDis = Double.MaxValue;
            Point temp = new Point(0,0);
            Point temp2 = new Point(0,0);
            temp = Points["Point 1"];
            String closestP = "";
            

            for (int i = 0; i < Points.Count; i++)
            {
                temp = Points[myKeys[i]];
                for (int j = 0; j < Points.Count; j++)
                {
                    if (i == j) continue;
                    Point test = Points[myKeys[j]];
                    double dis = Math.Sqrt(Math.Pow(Math.Abs(temp.X - test.X), 2) + Math.Pow(Math.Abs(temp.Y - test.Y), 2));
                    if (dis < currDis)
                    {
                        currDis = dis;
                        temp2 = Points[myKeys[j]];
                        closestP = myKeys[j];
                    } 
                }
                Console.WriteLine(myKeys[i]+ " closest point is - " + closestP);
                currDis = Double.MaxValue;
            }

            //***** CODES - Amend Codes above this segment ******
        }

    }
}
