using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KulakovEE.Sprint3.Task2.V19.Lib;

namespace Tyuiu.KulakovEE.Sprint3.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Кулаков Е.Е. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание №2                                                              *");
            Console.WriteLine("* Вариант №19                                                              *");
            Console.WriteLine("* Выполнил: Кулаков Е.Е. | АСОиУб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Написать программу используя while, которая вычисляет произведение ряда  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");


            int startValue = 1;
            int stopValue = 10;


            Console.WriteLine("Старт Шага = " + startValue);
            Console.WriteLine("Конец Шага = " + stopValue);

            Console.WriteLine("*******************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                               *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}