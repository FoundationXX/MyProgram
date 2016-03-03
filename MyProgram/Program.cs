using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
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
                                Fibonacci f = new Fibonacci();
                                (f.GetFibonacciLister(value)).ForEach(i => Console.Write("{0} ", i));

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
                                Prime p = new Prime();
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

                        Console.WriteLine("\nType a list of strings seperated by commas(no special characters in each string), or type q and press Enter to quit current function");
                        String input = Console.ReadLine();
                        //Console.WriteLine(input.ToString());
                        if (input.Equals("q") || input.Equals("Q"))
                        {
                            Console.WriteLine("Terminating StringSorter function......");
                            break;
                        }
                        else {

                            string[] L = input.Split(',');
                            StringSorter sorter = new StringSorter();
                            sorter.SortCommaSeparatedStrings(L).ForEach(i => Console.Write("{0} ", i));
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
    
    
   
