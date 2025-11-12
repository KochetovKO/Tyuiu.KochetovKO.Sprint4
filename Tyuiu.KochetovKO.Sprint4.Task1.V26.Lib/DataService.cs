using System.Buffers;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KochetovKO.Sprint4.Task1.V26.Lib
{
    public class DataService : ISprint4Task1V26
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            bool hasodd = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                    hasodd = true;
                } 
            }
            return hasodd ? sum : 0;
        }   
    }   
}
