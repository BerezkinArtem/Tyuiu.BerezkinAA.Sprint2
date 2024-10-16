using Tyuiu.BerezkinAA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g, m, n;
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch.                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g, m и n. По заданным g, n и m определить дату следуюищего дня.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите месяц: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год:  ");
            g = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine(res);
        }
    }
}