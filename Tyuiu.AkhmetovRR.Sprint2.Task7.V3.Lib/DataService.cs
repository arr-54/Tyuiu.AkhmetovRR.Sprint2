using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AkhmetovRR.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x > 0 && (x <= 1) && ((y > 0)) && (x <= 1)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
