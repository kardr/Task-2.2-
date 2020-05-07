using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фигуру (к – круг, п – прямоугольник, т - треугольник): ");
            char f = Convert.ToChar(Console.ReadLine());
            switch (f)
            {
                case 'к':
                    {
                        Console.WriteLine("Ваш выбор - круг: ");
                        Console.WriteLine("Введите радиус: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        double S;
                        S = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine("Площадь круга: " + S);
                        double P;
                        P = 2 * Math.PI * r;
                        Console.WriteLine("Периметр круга: "+P);
                        break;
                    }
                case 'п':
                    {
                        Console.WriteLine("Ваш выбор - прямоугольник: ");
                        Console.WriteLine("Введите длину: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите ширину: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        double S;
                        S = a * b;
                        Console.WriteLine("Площадь прямоугольника: " + S);
                        double P;
                        P = (a + b) * 2;
                        Console.WriteLine("Периметр прямоугольника: " + P);
                        break;
                    }
                case 'т':
                    {
                        Console.WriteLine("Ваш выбор - треугольник: ");
                        Console.WriteLine("Введите сторону а: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите сторону b: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите сторону c: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double S, p, P;
                        P = a + b + c;
                        p = P / 2;
                        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("Площадь треугольника: " + S);
                        Console.WriteLine("Периметр треугольника: " + P);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неверный ввод");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
