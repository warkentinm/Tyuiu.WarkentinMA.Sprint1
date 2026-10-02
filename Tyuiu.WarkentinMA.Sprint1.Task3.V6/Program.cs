using Tyuiu.WarkentinMA.Sprint1.Task3.V6.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task3.V6
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Варкентин Максим Андреевич | РППб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле           *");
            Console.WriteLine("* на дачу (туда и обратно)                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y, z;
            Console.WriteLine("расстояние до дачи (км): ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("количество бензина, которое потребляет автомобиль на 100 км пробега: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("цена одного литра бензина: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость поездки: " + ds.TravelCost(x, y, z) + "руб.");
            Console.ReadLine();
        }
    }
}
