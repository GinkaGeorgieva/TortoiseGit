using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacementTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorLength = double.Parse(Console.ReadLine());
            var tileSide = double.Parse(Console.ReadLine());
            var tileHight = double.Parse(Console.ReadLine());
            var tilePrice = double.Parse(Console.ReadLine());
            var sumMaster=double.Parse(Console.ReadLine());
            double floorArea = floorWidth * floorLength;
            double tileArea = tileSide * tileHight / 2;
            double numberTiles = Math.Ceiling(floorArea / tileArea)+5;
            double sumNeeded = numberTiles * tilePrice + sumMaster;
            if (money>=sumNeeded)
            {
                Console.WriteLine("{0:f2} lv left.",money-sumNeeded);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",sumNeeded-money);
            }


        }
    }
}
