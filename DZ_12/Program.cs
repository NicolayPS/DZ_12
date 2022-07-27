using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задача \nРазработать статический класс для работы с окружностью. Класс должен содержать 3 метода\n\n\nВведите количество попыток для этой программы:");
            int t = 0;
            try
            {
                t = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }
            int o = 1;
            while (o <= t)
            {
                Console.WriteLine("\nПопытка №{0} из {1}!\n................", o, t);
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("\t1 - Метод, определяющий длину окружности по заданному радиусу");
                Console.WriteLine("\t2 - Метод, определяющий площадь круга по заданному радиусу");
                Console.WriteLine("\t3 - Метод, проверяющий принадлежность точки с координатами (x,y)\n\t кругу с радиусом r и координатами центра x0, y0.");
                Console.Write("Ваш выбор: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите R :");
                        double R = double.Parse(Console.ReadLine());
                        double Length = circle.GetLength(R);
                        Console.WriteLine("Результат(длина окружности) = {0}", Length);
                        break;
                    case "2":
                        Console.Write("Введите R :");
                        double r = double.Parse(Console.ReadLine());
                        double Square = circle.GetSquare(r);
                        Console.WriteLine("Результат(площадь круга) = {0}", Square);
                        break;
                    case "3":
                        int x1 = 0;
                        int y1 = 0;
                        Point center_circle = new Point(x1, y1);
                        Console.WriteLine("Введите Х проверяемой точки:");
                        int x2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите Y проверяемой точки:");
                        int y2 = Int32.Parse(Console.ReadLine());
                        Point point = new Point(x2, y2);
                        Console.WriteLine("Радиус окружности:");
                        int radius = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Принадлежность окружности:" + Point.CheckPoint(center_circle, radius, point));
                        break;
                    default:
                        Console.Write("Ошибка! Нет операции с указаным номером");
                        break;
                }
                Console.Write("Нажмите любую кнопку для продолжения!");
                Console.ReadKey();
                o++;
            }
            Console.ReadKey();
        }
    }
}
