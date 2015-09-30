using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                integers.Add(i);
            }

            integers.ForEach(item => Console.Write(string.Format(" {0}", item)));
            Console.ReadKey();

            Console.WriteLine(String.Empty);
            Console.WriteLine(String.Empty);

            var result = integers.Select(item =>
                (item % 3 == 0) & (item % 5 == 0) ? "FizzBuzz"
                : (item % 3 == 0) ? "Fizz"
                : (item % 5 == 0) ? "Buzz" : item.ToString());

            result.ToList().ForEach(item => Console.Write(string.Format(" {0}", item)));
            

            Console.ReadKey();

        }
    }
}
