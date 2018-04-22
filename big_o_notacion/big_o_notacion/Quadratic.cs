using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_o_notacion
{
    //Complexity: O(N*N)
    public class Quadratic
    {

        public void Function(long n)
        {
            Quadratic quadratic = new Quadratic();
            quadratic.createAllPairs(n);
        }

        public void createAllPairs(long N)
        {
            long x = 0;
            long y = 0;
            while (x < N)
            {
                y = 0;
                while (y < N)
                {
                    Console.WriteLine(String.Format("{0}, {1}", x, y));
                    y = y + 1;
                }
                x = x + 1;
            }
        }
    }
}
