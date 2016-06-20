using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Test01.Interface
{
    public interface IPart
    {
        String Name { get; set; }
        Boolean IsWorking { set; }
        List<IPart> ConnectedParts { get; set; }

        /// <summary>
        /// Will map all parts from main-parent to the last child
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        String GetPartMap(string prefix);

        /// <summary>
        /// Will map all faulty parts from main-parent to the faulty parts
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        String GetFaultyPart(string prefix);
    }
}