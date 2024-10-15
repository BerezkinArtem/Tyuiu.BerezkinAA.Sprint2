using Tyuiu.BerezkinAA.Sprint2.Task4.V4.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое с использоавнием        *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x,y c *");
            Console.WriteLine("* с клавиатуры, если x+2<y, то z=sin(x)+2y, иначе cos(y)+2xy              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите переменную X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции: " + res);
            Console.ReadKey();
        }
    }
}
