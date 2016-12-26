using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            var minutes1 = double.Parse(Console.ReadLine());
            var minutes2 = double.Parse(Console.ReadLine());
            var minutes3 = double.Parse(Console.ReadLine());
            double distance1 = speed * minutes1 / 60;
            double morespeed = speed + 10 * speed / 100;
            double distance2 = morespeed * minutes2 / 60;
            double lessSpeed = morespeed - 5 * morespeed / 100;
            double distance3 = lessSpeed * minutes3 / 60;
            Console.WriteLine("{0:f2}", distance1 + distance2 + distance3);
        }
    }
}
