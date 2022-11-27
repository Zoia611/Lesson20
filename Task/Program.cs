using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            delegate double MyDelegate(double r);
            static void Main(string[] args)
            {
                Console.WriteLine("Введите радиус");
                double r = Convert.ToDouble(Console.ReadLine());

                MyDelegate a = Length;
                Console.WriteLine("Длина окружности: {0:f2}", a(r));

                a = Square;
                Console.WriteLine("Площадь круга: {0:f2}", a(r));

                a = Volume;
                Console.WriteLine("Объем шара: {0:f2}", a(r));

                Console.ReadKey();


            }
            static double Length(double r) => Math.PI * 2 * r;
            static double Square(double r) => Math.PI * r * r;
            static double Volume(double r) => (Math.PI * r * r * 3 * 4) / 3;
        }
    }
}
