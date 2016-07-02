using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        /// <summary>
        /// 
        /// Implement Class Part from Interface IPart
        /// 
        /// Class Part has field:
        /// String                  Name
        /// Bool                    IsWorking
        /// List<Interface.IPart>   ConnectedPart
        /// 
        /// These fields is specified in the constructor
        /// 
        /// You may change:
        /// 1. Class Part
        /// 2. Interface IPart (if you have to, not recommended)
        /// 3. Main method in this class, but only the parameters of IPart's method (GetPartMap and GetFaultyPart) if you changed it in point 2
        /// 
        /// Open the Output folder files for expected output in the console
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Interface.IPart bigMachine = _GenerateBigMachine();
            Console.WriteLine(bigMachine.GetPartMap("M-01"));
            Console.WriteLine(string.Empty);
            Console.WriteLine(bigMachine.GetFaultyPart("M-01"));
            //bigMachine.GetFaultyPart("M-01");
            Console.Read();
        }

        private static Class.Part _GenerateBigMachine()
        {
            return new Class.Part("M-01", true, new List<Interface.IPart> { 
                new Class.Part("B-01", true, new List<Interface.IPart>{
                    new Class.Part("B-01-A", true, new List<Interface.IPart>{})
                }),
                new Class.Part("B-02", true, new List<Interface.IPart>{
                    new Class.Part("S-01", true, new List<Interface.IPart>{
                        new Class.Part("S-30", false, new List<Interface.IPart>{}),
                        new Class.Part("S-31", true, new List<Interface.IPart>{})
                    }),
                    new Class.Part("S-02", true, new List<Interface.IPart>{}),
                    new Class.Part("S-03", true, new List<Interface.IPart>{
                        new Class.Part("S-30", true, new List<Interface.IPart>{}),
                        new Class.Part("S-31", true, new List<Interface.IPart>{})
                    })
                }),
                new Class.Part("B-03", true, new List<Interface.IPart>{
                    new Class.Part("S-01", true, new List<Interface.IPart>{}),
                    new Class.Part("S-02", false, new List<Interface.IPart>{
                        new Class.Part("S-30", true, new List<Interface.IPart>{}),
                        new Class.Part("S-31", true, new List<Interface.IPart>{})
                    }),
                    new Class.Part("S-03", true, new List<Interface.IPart>{})
                }),
                new Class.Part("B-04", true, new List<Interface.IPart>{
                    new Class.Part("S-01", true, new List<Interface.IPart>{}),
                    new Class.Part("S-02", true, new List<Interface.IPart>{
                        new Class.Part("S-30", true, new List<Interface.IPart>{}),
                        new Class.Part("S-31", true, new List<Interface.IPart>{})
                    }),
                }),
                new Class.Part("B-05", true, new List<Interface.IPart>{
                    new Class.Part("S-01", true, new List<Interface.IPart>{
                        new Class.Part("S-30", true, new List<Interface.IPart>{}),
                        new Class.Part("S-31", true, new List<Interface.IPart>{})
                    }),
                    new Class.Part("S-02", true, new List<Interface.IPart>{
                        new Class.Part("S-30", true, new List<Interface.IPart>{}),
                        new Class.Part("S-31", true, new List<Interface.IPart>{})
                    }),
                    new Class.Part("S-03", false, new List<Interface.IPart>{})
                }),
            });
        }
    }
}
