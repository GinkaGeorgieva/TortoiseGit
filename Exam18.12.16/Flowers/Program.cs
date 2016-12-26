using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrysant = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var dayOff = Console.ReadLine();
            var priceChrysant = 0.00;
            var priceRoses = 0.00;
            var priceTulips = 0.00;
            var sumPrice = 0.00;
            if (season == "Spring" || season == "Summer")
            {
                priceChrysant = 2;
                priceRoses = 4.1;
                priceTulips = 2.5;
                sumPrice = chrysant * priceChrysant + roses * priceRoses + tulips * priceTulips;
                if (dayOff == "Y")
                {
                    sumPrice = 115 * sumPrice / 100;
                    if (tulips > 7 && season == "Spring")
                    {
                        sumPrice = sumPrice * 95 / 100;
                    }
                }
                else if (dayOff == "N")
                {
                    if (tulips > 7 && season == "Spring")
                    {
                        sumPrice = sumPrice * 95 / 100;
                    }
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrysant = 3.75;
                priceRoses = 4.5;
                priceTulips = 4.15;
                sumPrice = chrysant * priceChrysant + roses * priceRoses + tulips * priceTulips;
                if (dayOff == "Y")
                {
                    sumPrice = 115 * sumPrice / 100;
                    if (roses >= 10 && season == "Winter")
                    {
                        sumPrice = sumPrice * 90 / 100;
                    }
                }
                else if(dayOff=="N")
                {
                    if (roses >= 10 && season == "Winter")
                    {
                        sumPrice = sumPrice * 90 / 100;
                    }
                }
            }
            
            if (chrysant + roses + tulips > 20)
            {
                sumPrice = sumPrice * 80 / 100;
                sumPrice = sumPrice + 2;
                Console.WriteLine("{0:f2}", sumPrice);
            }
            else
            {
                sumPrice = sumPrice + 2;
                Console.WriteLine("{0:f2}",sumPrice);
            }


        }
    }
}
