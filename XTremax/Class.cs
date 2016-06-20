using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01.Class
{
    class Part : Interface.IPart
    {
        public Part(string name, bool isWorking, List<Interface.IPart> connectedParts)
        {
            Name = name;
            IsWorking = isWorking;
            ConnectedParts = connectedParts;
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public bool IsWorking
        {
            set { IsWorking = value; }
        }

        public List<Interface.IPart> ConnectedParts
        {
            get
            {
                return ConnectedParts;
            }
            set
            {
                ConnectedParts = value;
            }
        }

        public string GetPartMap(string prefix)
        {
            throw new NotImplementedException();
        }

        public string GetFaultyPart(string prefix)
        {
            throw new NotImplementedException();
        }
    }
}
