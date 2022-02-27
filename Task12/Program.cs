using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task12
{
    public class RadiusException : Exception
    {
               public override string Message
        {
            get
            {
                return "Радиус не может быть меньше или равен 0";
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите радиус окружности");
                double r = Convert.ToDouble(Console.ReadLine());
                if (r<=0)
                {
                    throw new RadiusException();
                }
                double S;
                double L;
                Round.Area(r, out S);
                Console.WriteLine("Площадь окружности  = {0}", S);
                Round.Length(r, out L);
                Console.WriteLine("Длина окружности  = {0}", L);
                Console.WriteLine("Введите координату X центра окружности");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Y центра окружности");
                double y0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату X точки");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Y точки");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Round.Point(r, x0, y0, x1, y1);
            }
           catch (RadiusException)
            {
                Console.WriteLine("Ошибка! Неверное значение радиуса.");
            }
            Console.ReadKey();
        }
    }
    public static class Round
    {        
        public static double Area(double r, out double S)
        {
            S = Math.PI * r * r;
            return S;

        }

        public static double Length(double r, out double L)
        {
            L = 2 * Math.PI * r;
            return L;
        }

        public static double Point(double r, double x0, double y0, double x1, double y1)
        {
            if ((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0) <= r * r)
            {
                Console.WriteLine("Указанная точка принадлежит заданному кругу");
            }
            else
            {
                Console.WriteLine("Указанная точка не принадлежит заданному кругу");
            }
            return 0;
            
        }
    }
}
