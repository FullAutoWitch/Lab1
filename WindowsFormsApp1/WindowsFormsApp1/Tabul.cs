using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Tabul
    {
        //Варіант 11

        //Поле з результуючим масивом
        public double[,] xy = new double[1000, 2];
        //Реальна кількість елементів у масиві
        public int n = 0;
        //Метод для обрахунку функцій
        private double f1(double x)
        {
            return Math.Sqrt(Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(x), 4));
        }
        private double f2(double x) 
        {
            return Math.Pow(Math.Log(x), 2) + Math.Sqrt(x);
        }
        private double f3(double x) 
        {
            return Math.Pow(Math.Tan(x), 2) + Math.Sqrt(x);
        }
        //Метод табулювання
        public void tab(double xn = -2.74, double xk = 28.29, double h = 0.1, double a = 0.1) 
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
