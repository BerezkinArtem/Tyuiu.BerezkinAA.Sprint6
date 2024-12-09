using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezkinAA.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
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
                    y =Math.Round(5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5)), 2);
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}