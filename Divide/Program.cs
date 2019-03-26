using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        /// <summary>
        /// Метод, возвращающий количество разрядов в целом числе, которое подаётся в метод, как входной параметр.
        /// </summary>
        /// <param name="Целое число"></param>
        /// <returns> Количество разрядов (количество цифр из которых состоит целое число) </returns>
        static int NumberOfSign(int n)
        {
            int residual = 0;
            int counter = 0;
            while(n != 0)
            {
                residual = n / 10;
                n = residual;
                counter++;
            }
            return counter;
        }
        static void Main()
        {
            int N = 0;
            do
            {
                Console.WriteLine("Введите N, где N это количество выведенных на экран чисел, удовлетворяющих условиям задачи:");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    int counter = 0;
                    int i = 1;
                    while (i > 0 && counter != N)
                    {
                        int digitAmount = NumberOfSign(i);
                        if (i % digitAmount == 0)
                        {
                            Console.Write($"{i} ");
                            counter++;
                            i++;
                        }
                        else
                            i++;
                    }
                }
                else if (N < 0)
                {
                    Console.WriteLine("Вводимое число N не может быть меньше нуля. Попробуйте ещё раз:\n");
                }
                else
                {
                    Console.WriteLine("Вводимое число N не может быть равным нулю. Попробуйте ещё раз:\n");
                }
            } while (N < 0 || N == 0);

            Console.ReadKey();
        }
    }
}
