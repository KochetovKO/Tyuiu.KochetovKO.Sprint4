using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint4.Task7.V14.Lib;

namespace Tyuiu.KochetovKO.Sprint4.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 4 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Спринт №4                                                                     ");
            Console.WriteLine("Тема: Добавление к решению итоговых проектов по спринту                       ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Задание №6                                                                    ");
            Console.WriteLine("Вариант №28                                                                   ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                 ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                             ");
            Console.WriteLine("******************************************************************************");

            int rows = 3;
            int colums = 4;
            int[,] mtrx = new int[rows, colums];

            string str = "458712659137";

            int index = 0;

            Console.WriteLine("\nМассив : ");

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{str[index]} \t");
                    index++;
                }
            
            }

    
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                   ");
            Console.WriteLine("*******************************************************************************");

            int res = ds.Calculate(rows, colums, str);


            Console.WriteLine("сумма нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}