using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Competitive_Programming
{
    public class PerfectNumbers
    {
        public List<int> PowersOf2 (long n)
        {
            List<int> output = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                output.Add((int)Math.Pow(2, i));
            }
            return output;
        }

        public List<int> GeneratePerfectNumbersTillN (long n)
        {
            List<int> chai = PowersOf2(n);
            List<int> output = new List<int>();
            int sum = 0;
            foreach (int p2 in chai)
            {
                sum += p2;
                if (isPrime(sum)) 
                {
                    output.Add(sum * p2);
                }
            }
            return output;
        }

        public static void Main (String [] args) 
        {
            PerfectNumbers test = new PerfectNumbers();
            List<int> Test = test.GeneratePerfectNumbersTillN(1000000000000000000);
            foreach (int v in Test)
            {
                Console.WriteLine(v);
            }
        }

        public static bool isPrime (long b)
        {
            if (b == 2) 
            {
                return true;
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(b)); i++)
            {
                if(b % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

/*
    CEOnly
    Veritasium***
*/