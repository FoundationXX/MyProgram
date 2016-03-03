using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
	public class Prime
	{
        /*
            If a number x is not prime, then x = a * b, thus a <= sqrt(x) || b <=sqrt(x).
            Therefore, to check if x is prime, we just need to check x % n, where 1 < n <= min(a, b)
            If one n is found such that x%n == 0, then x is not prime.
        */
        ///Check is a number is prime
        private Boolean isPrime(double x)
        {
            if (x == 1)
            {
                return false;
            }
            else if (x == 2)
            {
                return true;
            }

            double mark = Math.Floor(Math.Sqrt(x));
            for (double i = 2; i <= mark; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        

        public List<double> PrimeNumberLister(double n)
        {
            List<double> result = new List<double>();
            Console.WriteLine("Running PrimeNumberLister function, where input n > 1 is an integer......");
            for (double i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    result.Add(i);
                }
                else
                {
                    continue;
                }
            }
            return result;
        }

    }
}
