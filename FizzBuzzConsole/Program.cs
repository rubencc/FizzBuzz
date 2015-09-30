using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
            string numbers = BuildNumbers();

            Console.WriteLine(numbers);
            Console.ReadKey();

            Console.WriteLine(String.Empty);

            numbers.Split(' ').ToList()
                .ForEach(item => Console.Write(FizzBuzz(item.ToString())));

            Console.ReadKey();
        }

        private static string FizzBuzz(string number)
        {
            int num = int.Parse(number);

            string output = String.Empty;

            if (num % 3 == 0)
            {
                output += "Fizz";
            }

            if (num % 5 == 0)
            {
                output += "Buzz";
            }

            return string.Format(" {0}", String.IsNullOrWhiteSpace(output) ? number : output);
        }

        private static string BuildNumbers()
        {
            StringBuilder sb = new StringBuilder(); 

            for (int i = 1; i <= 100; i++)
            {
                sb.Append(i.ToString());
                if(i != 100)
                    sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
