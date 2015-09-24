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
