using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PimenovaTS.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Введите X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Z:");
            z = Convert.ToInt32(Console.ReadLine());

            int c = DataService.Calc(x, y, z);

            Console.WriteLine("Значение выражения (x+y+z)*5 = " + c);
            Console.ReadLine();
        }
    }
}
