using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                
                    Console.WriteLine(new string('.', (2 * n - 1)) + "/|\\" + new string('.', (2 * n - 1)));
                    Console.WriteLine(new string('.', (2 * n - 1)) + "\\|/" + new string('.', (2 * n - 1)));
            }
            else
            {
               
                    Console.WriteLine(new string('.', (4 * n - 3) / 2 + 1) + "/|\\" + new string('.', (4 * n - 3) / 2 + 1));
                    Console.WriteLine(new string('.', (4 * n - 3) / 2 + 1) + "\\|/" + new string('.', (4 * n - 3) / 2 + 1));
            }
            for (int row = 1; row <= 2 * n; row++)
            {
                Console.WriteLine(new string('.', 2 * n - row) + "*" + new string('-', row - 1) + "*" + new string('-', row - 1) + "*" + new string('.', 2 * n - row));
            }
            Console.WriteLine(new string('*', 4 * n + 1));
            if (n % 2 == 0)
            {
                string s = new string('s', 2*n).Replace("s", "*.");
                Console.WriteLine(s+"*");
            }
            else
            {
                string s = new string('s', 2*n).Replace("s", "*.");
                Console.WriteLine(s+"*");
            }
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
