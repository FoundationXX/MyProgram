using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        public List<double> NthFibonacci(int n)
        {
            List<double> result = new List<double> { 0, 1 }; //use double to avoid overflow problem
            Console.WriteLine("Running NthFibonacci function, assuming the first two in the list would be 0, 1......");
            double recent0 = 0;
            double recent1 = 1;
            for (int i = 0; i < n - 2; i++)
            {
                double newFibonacci = recent0 + recent1;
                recent0 = recent1;
                recent1 = newFibonacci;
                result.Add(newFibonacci);
            }
            //Console.WriteLine(result.ToString());
            return result;
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


        /*
        If a number x is not prime, then x = a * b, thus a <= sqrt(x) || b <=sqrt(x).
        Therefore, to check if x is prime, we just need to check x % n, where 1 < n <= min(a, b)
        If one n is found such that x%n == 0, then x is not prime.
        */
        public Boolean isPrime(double x)
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

        public List<String> StringSorter(List<String> L)
        {
            Console.WriteLine("Running StringSorter function......");
            L.Sort();//......need recheck
            return L;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                Console.WriteLine("USAGE: please tell the program what you want it to do for you(n is a positive integer):");
                Console.WriteLine("Input 'F' to list the first n numbers in the Fibonacci sequence");
                Console.WriteLine("Input 'P' to list all the prime numbers between 0 and an  n");
                Console.WriteLine("Input 'S' to sort a comma separated list of strings in alpha-numeric order");
                Console.WriteLine("Input any other key to quit the program...");
                String userCommand = Console.ReadLine();
                if (userCommand.Equals("F") || userCommand.Equals("f"))
                {
                    while (true)
                    {
                        Console.WriteLine("\nType an integer n that is greater than 2 to obtain list of first n fibonacci numbers, or press any other key to quit current function");
                        String input = Console.ReadLine();
                        int value;
                        /*
                        Check whether input type is an integer 
                        */

                        if (int.TryParse(input, out value)) // if input can be parsed into an integer, do so...
                        {
                            if (value <= 2)
                            {
                                Console.WriteLine("Warning! Please make sure your input is a positive integer and n >= 2");

                            }
                            else
                            {
                                (p.NthFibonacci(value)).ForEach(i => Console.Write("{0} ", i));

                            }

                        }
                        else // if input cannot be parsed into an integer, do so...
                        {
                            Console.WriteLine("Input is not an integer, terminating NthFibonacci function...\n");
                            break;
                        }


                    }
                }
                //***********************************************************************************************************************//
                else if (userCommand.Equals("P") || userCommand.Equals("p"))
                {
                    while (true)
                    {
                        Console.WriteLine("\nType an integer n to list all prime numbers between 0 and n, or press any other key to quit current function");
                        String input = Console.ReadLine();
                        double value;
                        /*
                        Check whether input type is an integer 
                        */

                        if (double.TryParse(input, out value)) // if input can be parsed into an integer, do so...
                        {
                            if (value < 2)
                            {
                                Console.WriteLine("Warning! Please make sure your input is a positive integer and n >= 2");

                            }
                            else
                            {
                                (p.PrimeNumberLister(value)).ForEach(i => Console.Write("{0} ", i));

                            }

                        }
                        else // if input cannot be parsed into an integer, do so...
                        {
                            Console.WriteLine("Input is not an integer, terminating PrimeNumberLister function...\n");
                            break;
                        }


                    }
                }

                //***********************************************************************************************************************//
                else if (userCommand.Equals("S") || userCommand.Equals("s"))
                {
                    while (true)
                    {

                        Console.WriteLine("\nType a list of strings seperated by commas, or type q and press Enter to quit current function");
                        String input = Console.ReadLine();
                        //Console.WriteLine(input.ToString());
                        if (input.Equals("q") || input.Equals("Q"))
                        {
                            Console.WriteLine("Terminating StringSorter function......");
                            break;
                        }
                        else {
      
                            List<String> L = new List<String>(input.Split(','));
                            p.StringSorter(L).ForEach(i => Console.Write("{0} ", i));
                        }



                    }
                }

                //***********************************************************************************************************************//
                else
                {
                    Console.WriteLine("Exiting program......");
                    Environment.Exit(0);//????????? when is this necessary, what does it really do
                }

            }
        }
    }
}
