using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberStudents = int.Parse(Console.ReadLine());
            var countTop = 0;
            var count4 = 0;
            var count3 = 0;
            var countFail = 0;
            double averageSum = 0.00;
            for (int i = 0; i < numberStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5)
                {
                    countTop++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    count4++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    count3++;
                }
                else if (grade < 3)
                {
                    countFail++;
                }
                averageSum += grade;

            }
            double top = (double)countTop * 100 / numberStudents;
            double fourth = (double)count4 * 100 / numberStudents;
            double thirth = (double)count3 * 100 / numberStudents;
            double failed = (double)countFail * 100 / numberStudents;
            Console.WriteLine("Top students: {0:f2}%", top);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fourth);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", thirth);
            Console.WriteLine("Fail: {0:f2}%", failed);
            Console.WriteLine("Average: {0:f2}", averageSum / numberStudents);

        }
    }
}
