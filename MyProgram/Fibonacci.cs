using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Fibonacci
    {
        public List<double> GetFibonacciLister(int n)
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
    }
}
