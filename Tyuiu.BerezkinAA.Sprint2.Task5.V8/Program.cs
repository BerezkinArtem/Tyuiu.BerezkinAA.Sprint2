using Tyuiu.BerezkinAA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m              *");
            Console.WriteLine("* определить дату предыдущего дня.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите месяц: ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            y = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDateOfPreviousDay(x, y));
            Console.ReadKey();
        }
    }
}
