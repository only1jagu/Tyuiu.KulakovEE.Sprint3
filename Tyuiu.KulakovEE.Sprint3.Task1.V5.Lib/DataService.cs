using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KulakovEE.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplyRes = 1;
            while (startValue <= stopValue)
            {
                multiplyRes = multiplyRes * (Math.Cos(0.1) + (Math.Pow(startValue, -2)));
                startValue++;
            }
            return Math.Round(multiplyRes, 3);
        }
    }
}

