using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TomilovAD.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            int a = 0;
            foreach (string item in array)
            {
                if (item.Length < 7)
                {
                    a++;
                }
            }
            return a;
        }
    }
}
