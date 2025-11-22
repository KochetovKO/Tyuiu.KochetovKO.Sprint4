using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KochetovKO.Sprint4.Task7.V14.Lib
{
    public class DataService : ISprint4Task7V14
    {
        public int Calculate(int rows, int colums, string value)
        {
            int[,] mtrx = new int[rows, colums];
            
            int index = 0;

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < colums; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(index, 1));
                    index++;


                }

            }
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (mtrx[i, j] % 2 != 0)
                    {
                        count += mtrx[i, j];
                    }
                
                
                }
            }
            return count;


        }
    }
}
