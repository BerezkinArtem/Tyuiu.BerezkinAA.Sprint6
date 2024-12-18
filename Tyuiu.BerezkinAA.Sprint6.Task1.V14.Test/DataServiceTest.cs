﻿using Tyuiu.BerezkinAA.Sprint6.Task1.V14.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = 1 + (stopValue - startValue);

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -2.15;
            valueWaitArray[1] = -2.57;
            valueWaitArray[2] = -3;
            valueWaitArray[3] = -3.83;
            valueWaitArray[4] = -11.7;
            valueWaitArray[5] = 3;
            valueWaitArray[6] = 2.19;
            valueWaitArray[7] = 3.31;
            valueWaitArray[8] = 2.97;
            valueWaitArray[9] = 1.18;
            valueWaitArray[10] = 0.03;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}