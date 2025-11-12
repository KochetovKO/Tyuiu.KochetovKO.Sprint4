using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task2.V28.Lib;
namespace Tyuiu.KochetovKO.Sprint4.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт 4 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №4                                                                       ");
            Console.WriteLine("Тема: Одномерные массивы (статический ввод)                                   ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №2                                                                      ");
            Console.WriteLine("Вариант №28                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");
            
            Console.WriteLine("Введите количество элементов массива");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(5, 20);
            }

            Console.WriteLine();
            Console.WriteLine("массив : ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Результат");
            Console.WriteLine("***********************************************************************");
            
            int res = ds.Calculate(numsArray);
            Console.ReadKey();
        }
    }
}

