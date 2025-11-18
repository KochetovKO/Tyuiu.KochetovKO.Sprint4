using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task6.V28.Lib;

namespace Tyuiu.KochetovKO.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 4 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Спринт №4                                                                     ");
            Console.WriteLine("Тема: Класс Array                                                             ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Задание №6                                                                    ");
            Console.WriteLine("Вариант №28                                                                   ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                 ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                             ");
            Console.WriteLine("******************************************************************************");

            var reservoirs = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };

            Console.WriteLine("Исходный массив : ");

            for (int i = 0; i < reservoirs.Length; i++)
            {
                Console.WriteLine(reservoirs[i]);
            }

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                   ");
            Console.WriteLine("*******************************************************************************");

            var res = ds.Calculate(reservoirs);

            Console.WriteLine("Элементы массива имеющие ровно 4 символа:");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Количество элементов с 4 символами: {res.Length}");
            Console.ReadKey();
        }
    }
}