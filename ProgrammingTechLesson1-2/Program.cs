using System;

namespace ProgrammingTechLesson1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //вариант 4. Вычислить S – площадь остроугольного треугольника по формуле S = La * Lb * sinC / 2
            // , где La и Lb – длины сторон, а С – угол между ними. Затем вычислить
            // длину третьей стороны Lc, используя соотношение Lc2=La2+Lb2 -2·La·Lb·cosC и остальные
            // углы, используя соотношение sinA/sinC=La/Lc. Проверить результаты для различных исходных данных по сумме углов.
            double sinA = 0;

            Console.WriteLine("Введите сторону А");
            double lengthA = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            double lengthB = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите угол С");
            double angleC = double.Parse(Console.ReadLine());
            
            //расчет длины С
            double lengthC = Math.Sqrt(lengthA * lengthA + lengthB * lengthB -
                                       2 * (lengthA * lengthB * Math.Cos(Math.PI * angleC / 180)));
            //расчет площади треугольника
            double square = (lengthA * lengthB * Math.Sin(Math.PI * angleC / 180)) / 2;
            
            Console.WriteLine("Площадь = " + square);
            Console.WriteLine("Длина C = " + lengthC);
            sinA = lengthA * Math.Sin(Math.PI * angleC / 180) / lengthC;
            double sinB = lengthB * Math.Sin(Math.PI * angleC / 180) / lengthC;
            //преобразуем радианы в градусы, тем самым найдя углы
            double angleA = Math.Asin(sinA) * 180/Math.PI;
            double angleB = Math.Asin(sinB) * 180/Math.PI;
            Console.WriteLine("синус А = " + sinA);
            Console.WriteLine("синус B = " + sinB);
            Console.WriteLine("угол А = " + angleA);
            Console.WriteLine("угол B = " + angleB);
        }
    }
}