using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task4.V23.Lib;
namespace Tyuiu.KochetovKO.Sprint4.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 4 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №4                                                                       ");
            Console.WriteLine("Тема: Двумерные массивы (ввод с клавиатуры)                                     ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №4                                                                      ");
            Console.WriteLine("Вариант №23                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите количество строк в массиве : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество стобцов в массиве : ");
            int colums = Convert.ToInt32(Console.ReadLine());


             int[,] mtrx = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"Введит {i},{j} элемент массива : ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

                }
                
            }

            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]}");   
                }
                Console.WriteLine();
            }








            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Результат");
            Console.WriteLine("***********************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("количество четных элементов = " + res);
            Console.ReadKey();

        }
    }
}

