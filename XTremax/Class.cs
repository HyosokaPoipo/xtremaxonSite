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
            nameList = new List<string>();
        }

        public string Name
        { get; set; }

        public bool IsWorking
        { get; set; }

        public List<Interface.IPart> ConnectedParts
        { get; set; }

        private List<String> nameList;
        public string GetPartMap(string prefix)
        {
            nameList.Clear();
            //string temp = "";
            string result = "";
            for (int i = 0; i < ConnectedParts.Count; i++)
            {
                //temp = Name +" => " +ConnectedParts[i].Name + "\n";
                addNametoList((Part)ConnectedParts[i], Name);
                //result += temp; 
            }

            foreach (string a in nameList)
            {
                result += a + "\n";
            }

            return result;
        }

        private void addNametoList(Part mPart, string name)
        {
            String temp = name + " => " + mPart.Name;
            if (mPart.ConnectedParts.Count == 0) nameList.Add(temp);

            for (int i = 0; i < mPart.ConnectedParts.Count; i++)
            {
                addNametoList((Part)mPart.ConnectedParts[i],temp);
            }
        }


        public string GetFaultyPart(string prefix)
        {
            string result = "";
            nameList.Clear();

            for (int i = 0; i < ConnectedParts.Count; i++)
            {                
                listFaultyPart((Part)ConnectedParts[i], Name);                
            }

            foreach (string a in nameList)
            {
                result += a + "\n";
            }

            return result;
        }

        private void listFaultyPart(Part mPart, string name)
        {            
            String temp = name + " => " + mPart.Name;
            if (!mPart.IsWorking) nameList.Add(temp);
            for (int i = 0; i < mPart.ConnectedParts.Count; i++)
            {
                listFaultyPart((Part)mPart.ConnectedParts[i], temp);
            }
        }









        private string GetPartMap_old(string prefix)
        {
            string temp;
            string result = "";
            for (int i = 0; i < ConnectedParts.Count; i++)
            {
                Part test = (Part)ConnectedParts[i];
                temp = partMap(test, Name);                
            }
            return result;            
        }

        private string partMap(Part temp, string result)
        {
            for (int i = 0; i < temp.ConnectedParts.Count; i++)
            {
                result = result + " => " + temp.Name;
                partMap((Part)temp.ConnectedParts[i], result);
            }

            if (temp.ConnectedParts.Count == 0)
            {
                Console.WriteLine(result + " => " + temp.Name);
                return "";
            }
            //else if (!temp.IsWorking && temp.ConnectedParts.Count == 0)
            //{
            //    return "";
            //}

            return "";
        }


        public string GetFaultyPart_old(string prefix)
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


            //Console.WriteLine("end of line");
            return "";
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
