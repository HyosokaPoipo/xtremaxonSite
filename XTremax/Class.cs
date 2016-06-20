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

        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsWorking
        {
            set { throw new NotImplementedException(); }
        }

        public List<Interface.IPart> ConnectedParts
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
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
