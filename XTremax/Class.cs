using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01.Class
{
    public class Part : Interface.IPart
    {
        public Part(string name, bool isWorking, List<Interface.IPart> connectedParts)
        {
            Name = name;
            IsWorking = isWorking;
            ConnectedParts = connectedParts;
        }

        public string Name
        { get; set; }

        public bool IsWorking
        { get; set; }

        public List<Interface.IPart> ConnectedParts
        { get; set; }

        public string GetPartMap(string prefix)
        {
            string result = "";

            return result;            
        }

        public void GetFaultyPart(string prefix)
        {
            //string result = "";
            //List<Interface.IPart> allFault = ConnectedParts.Find(x=>x.Name == prefix);
            string temp;
            
            for (int i = 0; i < ConnectedParts.Count; i++)
            {
                Part test = (Part)ConnectedParts[i];
                temp = faulty3(test,Name);
                //if (temp != "")
                //{
                //    result = result + temp;
                //    Console.WriteLine(this.Name  + temp);
                //}
                //result = "";
            }


            Console.WriteLine("end of line");
        }


        private string faulty3(Part temp, string result)
        {
            if (!temp.IsWorking)
            {
                Console.WriteLine(result + " => " + temp.Name);
                return "";
            }

            for (int i = 0; i < temp.ConnectedParts.Count; i++)
            {
                result =result +" => "+ temp.Name;
                faulty3((Part)temp.ConnectedParts[i], result);
            }
            if (temp.IsWorking && temp.ConnectedParts.Count == 0) return "";
            else if (!temp.IsWorking && temp.ConnectedParts.Count == 0)
            {
                Console.WriteLine(result + " => " + temp.Name);
                return "";
            }

            return "";
        }



        public string faulty(Part temp, string result, int index)
        {
            if (!temp.IsWorking) Console.WriteLine( result + " => " + temp.Name); 

            if (temp.IsWorking && temp.ConnectedParts.Count > 0)
            {
                result = result+" => "+temp.Name;               
                return faulty((Part)temp.ConnectedParts[index], result, index+1);
                
            }

            //if (temp.IsWorking && temp.ConnectedParts.Count == 0) return "";
            //else if (!temp.IsWorking && temp.ConnectedParts.Count == 0) return result + " => " + temp.Name; 
            //else return result + " => " + temp.Name; ;   
            return "";
        }


        public string faulty2(List<Interface.IPart> connectedParts)
        {
            Part temp = (Part)connectedParts[0];
            
            if (temp.IsWorking) return temp.Name + faulty2(temp.ConnectedParts);
            return connectedParts[0].Name;          
            
        }


    }
}
