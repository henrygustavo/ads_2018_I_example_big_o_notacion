using System;
using System.Diagnostics;

namespace big_o_notacion
{
    //Complexity: O(2^N)
    public class Exponential
    {
        public void Function(long n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i <= n; i++)
            {
                try
                {
                    long fibonacci = this.Fibonacci(i);

                    Console.WriteLine(i + " => " + fibonacci);
                    Console.Write('\r');

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            Console.WriteLine(string.Format("Time elapsed: {0} seconds", stopwatch.Elapsed.TotalSeconds) + "\n");
        }

        private long Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
