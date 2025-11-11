using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task1.V26.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KochetovKO.Sprint4.Task1.V26
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
            Console.WriteLine("Задание №1                                                                      ");
            Console.WriteLine("Вариант №26                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1 ; i++)
            {
                Console.WriteLine("Введите значение " + i  + "элемента массива");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
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
