using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KochetovKO.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;                    
                    }
                }
            }
            return count;
        }
    }
}
