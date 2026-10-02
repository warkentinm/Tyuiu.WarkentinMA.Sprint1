using Tyuiu.WarkentinMA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Варкентин М.А. | РППБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine(" Выполнила: Варкентин Максим Андреевич | РППб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известны длины стороны прямоугольника.Вычислить периметр прямоугольника *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a, b;
            Console.WriteLine("Введите длину стороны A прямоугольника:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны B прямоугольника:");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Периметр прямоугольника: " + ds.CalculatePerimetr(a, b));
            Console.ReadLine();
        }
    }
}
