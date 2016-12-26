using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            first =(char) Math.Min((char)first, (char)second);
            second = (char)Math.Max((char)first, (char)second);
            var count = 0;
            for (char i = (char)first; i <= (char)second; i++)
            {
                for (char k = (char)first; k <=(char) second; k++)
                {
                    for (char d = (char)first; d <= (char)second; d++)
                    {
                        if (i != third && k != third && d != third)
                        {
                            Console.Write("{0}{1}{2} ", i, k, d);
                            count++;
                        }
                       
                    }
                }
            }
            Console.Write(count);
        }
    }
}
