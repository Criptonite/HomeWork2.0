using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Num3
    {
        public static void runThirdHomeWork()
        {
            char? answer = null;
            do
            {
                int number;
                Console.WriteLine("Введите число до которого будем счиать...");
                Console.Write("-> ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 1)
                {
                    int i = 1;
                    int sum = 0;
                    while (i <= number)
                    {
                        sum += i;
                        i++;
                    }
                    Console.WriteLine("Сумма равна: " + sum);
                }
                else
                {
                    int i = 1;
                    int sum = 0;
                    while (i >= number)
                    {
                        sum += i;
                        i--;
                    }
                    Console.WriteLine("Сумма равна: " + sum);
                }
                Console.WriteLine("Чтобы вернуться в меню нажмите \"S\"");
                Console.Write("-> ");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer != 'S');
        } 
    }
}
