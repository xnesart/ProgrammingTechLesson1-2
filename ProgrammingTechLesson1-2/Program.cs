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
            // Ввод данных
            
            Console.WriteLine("Введите длину стороны La:");
            double La = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны Lb:");
            double Lb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите угол C в градусах:");
            double angleC = Convert.ToDouble(Console.ReadLine());

            // Перевод угла из градусов в радианы
            double angleC_rad = angleC * Math.PI / 180.0;

            // Вычисление площади треугольника
            double S = (La * Lb * Math.Sin(angleC_rad)) / 2;

            // Вычисление длины третьей стороны Lc
            double Lc_squared = La * La + Lb * Lb - 2 * La * Lb * Math.Cos(angleC_rad);
            double Lc = Math.Sqrt(Lc_squared);

            // Вычисление угла A
            double angleA_rad = Math.Asin(Math.Sin(angleC_rad) * La / Lc);
            double angleA = angleA_rad * 180.0 / Math.PI;

            // Вычисление угла B
            double angleB = 180.0 - angleA - angleC;

            // Вывод результатов
            Console.WriteLine($"Площадь треугольника S: {S}");
            Console.WriteLine($"Длина третьей стороны Lc: {Lc}");
            Console.WriteLine($"Угол A: {angleA}");
            Console.WriteLine($"Угол B: {angleB}");

            // Проверка суммы углов
            double angleSum = angleA + angleB + angleC;
            Console.WriteLine($"Сумма углов треугольника: {angleSum}");

            // Проверка, что сумма углов равна 180 градусов
            if (Math.Abs(angleSum - 180.0) < 0.0001)
            {
                Console.WriteLine("Сумма углов верна. Треугольник остроугольный.");
            }
            else
            {
                Console.WriteLine("Сумма углов неверна. Проверьте введенные данные.");
            }
        }
    }
}