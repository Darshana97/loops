using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your target?");
            int Target = int.Parse(Console.ReadLine());

            Console.WriteLine("______________________________________________");

            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
            Console.ReadLine();
        }
    }
}
