using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezkinAA.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1; 
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(((2 * x + 6) / (Math.Cos(x) + x)) - 3, 2);
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}