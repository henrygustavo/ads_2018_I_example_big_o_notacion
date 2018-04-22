using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_o_notacion
{
    // Complexity: O(log2 N)
    public class Logarithmic
    {
        public void Function(int needle)
        {
            Logarithmic logarithmic = new Logarithmic();
            List<int> valueList = new List<int> { 2, 4, 4, 5, 7, 10, 23, 25, 64 };
            try
            {
                int position = logarithmic.binarySearch(valueList, needle, 0, valueList.Count() - 1);
                Console.WriteLine(position == -1 ? "Not found" : "Found at position: " + position);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public int binarySearch(List<int> valueList, int needle, int min, int max)
        {
            {
                int midpoint = (max + min) / 2;
                if (valueList.Count() > 0 && valueList.ElementAt(midpoint) == needle)
                {
                    return midpoint;
                }
                if (min >= max)
                {
                    return -1;
                }
                if (valueList.ElementAt(midpoint) > needle)
                {
                    return binarySearch(valueList, needle, min, midpoint - 1);
                }
                return binarySearch(valueList, needle, midpoint + 1, max);
            }
        }
    }
}
