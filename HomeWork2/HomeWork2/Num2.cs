using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Num2
    {
        public static void runSecondHomeWork()
        {
            char? answer = null;
            do
            {
                int n;
                Console.WriteLine("Введите n");
                Console.Write("-> ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Отрицательное n");
                }
                else
                {
                    makeSeries(n);
                }
                Console.WriteLine("Чтобы вернуться в меню нажмите \"S\"");
                Console.Write("-> ");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer != 'S');
        }

        public static void makeSeries(int n)
        {
            List<int> numbers = new List<int>();
            int i = 0;
            while (i <= n)
            {
                if (i == 0)
                {
                    numbers.Add(0);
                }
                else if (i == 1)
                {
                    numbers.Add(1);
                }
                else if (i%2 == 0)
                {
                    numbers.Add(numbers[i/2]);
                }
                else if (i%2 != 0)
                {
                    numbers.Add(numbers[(i - 1)/2] + numbers[((i - 1)/2) + 1]);
                }
                i++;
            }
            numbers.Sort();
                Console.WriteLine(numbers[numbers.Count - 1]);
        }
    }
}
