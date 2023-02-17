using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X в диапазоне от -1 до 1");
            bool wrongNumber = false;
            double x;
            do
            {
                wrongNumber = false;
                x = Convert.ToDouble(Console.ReadLine());
                if (!(x >= -1 && x < 1))
                {
                    wrongNumber = true;
                    Console.WriteLine("Вы ввели число, которое выходит из диапозона, введите ещё раз");
                }
            } while (wrongNumber);

            Console.WriteLine("Введите количество иттераций");
            int n;
            do
            {
                wrongNumber = false;
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    wrongNumber = true;
                    Console.WriteLine("Вы ввели недопустимое число иттераций, введите ещё раз");
                }
            } while (wrongNumber);

            double sum = 0;
            
            for(double i = 1; i < n + 1; i++)
            {
               
                sum += Math.Pow(x,i) / i;
            }
            sum *= -1;
            Console.WriteLine($"Результат: {Math.Round(sum, 4)}");
        }
    }
}
