﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KulakovEE.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
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
                if (x == -2)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x, 3);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}