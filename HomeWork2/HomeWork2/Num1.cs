using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Num1
    {
        public static void runFirstHomeWork()
        {
            char? answer = null;
            do
            {
                int harryShots, larryShots;
                Console.Write("Количество банок простреленных Гарри -> ");
                harryShots = Convert.ToInt32(Console.ReadLine());
                Console.Write("Количество банок простреленных Ларри -> ");
                larryShots = Convert.ToInt32(Console.ReadLine());
                if ((harryShots > 10) || (larryShots > 10))
                {
                    Console.WriteLine("Слишком много выстрелов для 10 банок!!!");
                }
                else if (harryShots + larryShots < 11)
                {
                    Console.WriteLine("Они не прострелили одну и ту же банку!!!");
                }
                else if (harryShots + larryShots > 11)
                {
                    Console.WriteLine("Они должны были прострелить одну и ту же банку и остановиться!!!");
                }
                else
                {
                    Console.WriteLine("Отчет:");
                    Console.WriteLine("Гарри не успел прострелить: " + (10 - harryShots) +
                                      " банок(и), а Ларри не успел прострелить: " + (10 - larryShots) + " банок(и).");
                }
                Console.WriteLine("Чтобы вернуться в меню нажмите \"S\"");
                Console.Write("-> ");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer != 'S');
        }
    }
}
