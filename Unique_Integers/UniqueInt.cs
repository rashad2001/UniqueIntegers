using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Integers
{
    public class UniqueInt
    {
        public UniqueInt() { }
        public List<int> GetUniqueElements(List<int> inputList)
        {
            var uniqueList = new List<int> { };
            foreach (int item in inputList)
            {
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
            }
            return uniqueList;
        }
    }
}
