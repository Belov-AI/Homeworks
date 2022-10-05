using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            double r = double.Parse(Console.ReadLine());

            double s = Math.PI * r * r;

            Console.WriteLine("Площадь круга: " + s);

            Console.ReadKey();
        }
    }
}
