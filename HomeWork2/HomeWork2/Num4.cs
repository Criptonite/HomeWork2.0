using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Num4
    {
        public static void runFourthHomeWork()
        {
            char? answer = null;
            do
            {
                int number;
                Console.WriteLine("Введите пятизначное число");
                Console.Write("-> ");
                number = Convert.ToInt32(Console.ReadLine());
                if ((number >= 99999) && (number <= 100000))
                {
                    Console.WriteLine("Введено не пятизначное число!!!");
                }
                else
                {
                    int i = 0;
                    int oper = 10000;
                    int firstNum = 0;
                    while (oper != 0)
                    {
                        firstNum = (number / oper) % 10;
                        Console.WriteLine(++i + " цифра равна " + firstNum);
                        oper /= 10;
                    }
                }
                Console.WriteLine("Чтобы вернуться в меню нажмите \"S\"");
                Console.Write("-> ");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer != 'S');
        }
    }
}
