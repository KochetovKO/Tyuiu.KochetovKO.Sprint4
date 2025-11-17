using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task3.V27.Lib;
namespace Tyuiu.KochetovKO.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 4 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №4                                                                       ");
            Console.WriteLine("Тема: Двумерные массивы (статический ввод)                                      ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №3                                                                      ");
            Console.WriteLine("Вариант №27                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            int[,] mtrx = new int[5, 5] { {4, 3, 5, 5, 3 },

                                       { 6, 7, 4, 4, 3 },

                                       { 3, 3, 7, 3, 6 },

                                       { 3, 4, 3, 7, 7 },

                                       { 3, 5, 6, 3, 6, } }; 
           
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

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

