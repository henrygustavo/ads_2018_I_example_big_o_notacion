using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace big_o_notacion
{
    //Complexity: O(N)
    public class Lineal
    {
        private static int N = 90;
        private long[] fibonacciCache = new long[N + 1];

        public void Function()
        {
            int NEEDLE = 64;
            LinealExampleType linealExampleType = LinealExampleType.FibonacciCache;
            switch (linealExampleType)
            {
                case LinealExampleType.Loop: this.Loop(N); break;
                case LinealExampleType.Search: this.Search(NEEDLE); break;
                case LinealExampleType.Factorial: this.PrintFactorial(N); break;
                case LinealExampleType.Fibonacci: this.PrintFibonacci(N, LinealExampleType.Fibonacci); break;
                case LinealExampleType.FibonacciCache: this.PrintFibonacci(N, LinealExampleType.FibonacciCache); break;
            }
        }

        public void Loop(int N)
        {
            int counter = 0;
            Console.WriteLine("**********************loop**********************");
            while (counter < N)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
        }

        public void Search(int needle)
        {
            List<int> valueList = new List<int> { 2, 4, 4, 5, 7, 10, 23, 25, 64};
            bool found = this.ContainsNeedle(needle, valueList);
            Console.WriteLine("**********************search**********************");
            Console.WriteLine(found);
        }

        public bool ContainsNeedle(int needle, List<int> valueList)
        {
            foreach (long value in valueList)
            {
                if (value == needle)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintFactorial(int N)
        {
            long factorial = this.GetFactorial(N);
            Console.WriteLine("**********************factorial**********************");
            Console.WriteLine(factorial);
        }

        public long GetFactorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            if (N > 20) { throw new Exception(N + " is out of range"); }
            return (N * GetFactorial(N - 1));
        }

        public void PrintFibonacci(int N, LinealExampleType linealExampleType)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i <= N; i++)
            {
                try
                {
                    long fibonacci = 0;
                    switch (linealExampleType)
                    {
                        case LinealExampleType.Fibonacci: fibonacci = this.Fibonacci(i); break;
                        case LinealExampleType.FibonacciCache: fibonacci = this.FibonacciCache(i); break;
                        default: fibonacci = this.Fibonacci(i); break;
                    }
                    Console.WriteLine(i + " => " + fibonacci);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            Console.WriteLine(string.Format("Time elapsed: {0} seconds", stopwatch.Elapsed.TotalSeconds) + "\n");
        }

        public long Fibonacci(int N)
        {
            if (N < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (N <= 2) {
                return 1;
            }
            long fibonacci = 0;
            long previous = 1;
            long penultimate = 0;
            for (int i = 1; i <= N; i++) {
                penultimate = fibonacci;
                fibonacci = previous + fibonacci;
                previous = penultimate;
            }
            return fibonacci;
        }

        public long FibonacciCache(int N)
        {
            if (N < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (N <= 2) {
                fibonacciCache[N] = 1;
            }
            if (fibonacciCache[N] == 0) {
                fibonacciCache[N] = FibonacciCache(N - 1) + FibonacciCache(N - 2);
            }
            return fibonacciCache[N];
        }
    }
}