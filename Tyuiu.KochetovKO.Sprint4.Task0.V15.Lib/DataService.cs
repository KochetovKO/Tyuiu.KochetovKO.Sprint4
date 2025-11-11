using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovKO.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            bool hasOddElements = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOddElements = true;
                }
            }

            return hasOddElements ? product : 0;
        }
    }
}