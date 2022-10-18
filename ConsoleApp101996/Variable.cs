using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp101996
{
    public static class Variable
    {
        public static void DeleniesOstatkom(int a, int b) //1
        {
            int c = a / b;
            double d = a % b;
            Console.WriteLine($"Delenie bez ostatka {c}");
            Console.WriteLine($"Delenie s ostatkom {d}");
        }
        public static double DrobnoeDelenie(int a, int b) //2
        {
            double c = (5 * a + b * b) / (b - a);
            return c;
        }

        public static double Equation(int a,int b,int c) //4
        {
            double x = (c - b) / a;
            return x;
        }

        public static void LineEquation (int x1,int y1,int x2,int y2) //5
        {
            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;
            Console.WriteLine("y=" +a + "x" + b);
        }
    }
}
    

