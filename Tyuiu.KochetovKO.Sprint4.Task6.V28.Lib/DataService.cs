using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KochetovKO.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length == 4);
            return mas;
        }
    }
}
