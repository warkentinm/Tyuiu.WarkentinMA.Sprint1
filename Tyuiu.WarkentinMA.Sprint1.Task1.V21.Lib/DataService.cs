using tyuiu.cources.programming.interfaces.Sprint1; 

namespace Tyuiu.WarkentinMA.Sprint1.Task1.V21.Lib
{
    public class DataService : ISprint1Task1V21
    {
        public double Calculate(double x, double y)
        {
            return (x * y) / (3 + y);
        }
    }
}
