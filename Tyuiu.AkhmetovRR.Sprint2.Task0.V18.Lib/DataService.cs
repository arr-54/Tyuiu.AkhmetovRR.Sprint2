using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AkhmetovRR.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x == y;
            result[1] = x != y;
            result[2] = y < x;
            result[3] = x > y;
            result[4] = y <= x;
            result[5] = y >= x;

            return result;
        }
    }
}