using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BerezkinAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y == x) && (y == -x) && (y == x * x - 2))
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
