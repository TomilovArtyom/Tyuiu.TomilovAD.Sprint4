using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TomilovAD.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {


            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int a = 10;

            for (int i = 0; i < rows; i++)
            {
                int j = columns - 1;
                if (array[i, j] < a)
                {
                    a = array[i, j];
                }                   
            }    
            return a;
        }
    }
}
