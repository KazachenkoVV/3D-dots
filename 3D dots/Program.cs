using System;

namespace _3D_dots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Курс \"Разработка интернет - приложений на платформе C# ASP.Net MVC\"");
            Console.WriteLine("Входное задание - “Класс «Точки в 3х-мерном пространстве»”");
            Console.WriteLine("Студент - Казаченко Валерий");
            Console.WriteLine("03 ноября 2020\n\n");

            Point point1 = new Point();
            Console.WriteLine($"Точка - point1 имеет координаты:");
            point1.DispleyPoint();

            Point point2 = new Point(x: 1, z: 1);
            Console.WriteLine($"Точка - point2 имеет координаты:");
            point2.DispleyPoint();

            Console.WriteLine($"Расстояние между точками point1 и point2 равно {point1.DistanceBetweenTwoPoints(point2):f4}\n");

            Console.WriteLine("Введите координаты точки point3:");
            var coordinates = inputDot();
            Point point3 = new Point(x: coordinates.Item1, y: coordinates.Item2, z: coordinates.Item3);
            Console.WriteLine($"Точка - point3 имеет координаты:");
            point3.DispleyPoint();

            Console.WriteLine($"Расстояние между точками point2 и point3 равно {point2.DistanceBetweenTwoPoints(point3):f4}\n");
            Console.WriteLine($"Расстояние между точками point1 и point3 равно {point1.DistanceBetweenTwoPoints(point3):f4}\n");

            // Ввод координат новой точки с клавиатуры
            (double x, double y, double z) inputDot()
            {
                double[] valueDim = new double[3];
                string[] dimensions = { "X", "Y", "Z" };

                bool ok;
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        Console.Write($"Координата {dimensions[i]} = ");
                        ok = Double.TryParse(Console.ReadLine(), out valueDim[i]);
                        if (ok == false)
                            Console.WriteLine("Нужно ввести число! Повторите, пожалуйста, ввод!");
                    } while (ok == false);
                }

                Console.WriteLine();
                return (valueDim[0], valueDim[1], valueDim[2]);
            }
        }
    }
}
