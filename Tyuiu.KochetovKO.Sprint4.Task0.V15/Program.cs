using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task0.V15.Lib;
namespace Tyuiu.KochetovKO.Sprint4.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт 4 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №4                                                                       ");
            Console.WriteLine("Тема: Одномерные массивы (статический ввод)                                   ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №0                                                                      ");
            Console.WriteLine("Вариант №15                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("исходный массив");
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Результат");
            Console.WriteLine("********************************************************************************");

            int result = ds.GetMultOddArrEl(array);
            Console.WriteLine("Произведение нечётных элементов = " + result);

            Console.ReadKey();
        }
    }
}