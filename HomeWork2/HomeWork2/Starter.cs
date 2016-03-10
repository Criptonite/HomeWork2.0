using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork2
{
    class Starter
    {
        static void Main(string[] args)
        {
            char? answer = null;
            do
            {
                int choise;
                Console.WriteLine("Выберете одну из указаных ниже программ:");
                Console.WriteLine("1. Гарри и Ларри");
                Console.WriteLine("2. Максимум");
                Console.WriteLine("3. Сумма чисел от 1 до N");
                Console.WriteLine("4. Деление числа на разряды");
                Console.Write("-> ");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Num1.runFirstHomeWork();
                        break;
                    case 2:
                        Num2.runSecondHomeWork();
                        break;
                    case 3:
                        Num3.runThirdHomeWork();
                        break;
                    case 4: Num4.runFourthHomeWork();
                        break;
                    default:
                        Console.WriteLine("Тут такого нет и пока не планируется...");
                        break;
                }
                Console.WriteLine("Если вы хотите закрыть программу нажмите \"S\"");
                Console.Write("-> ");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer != 'S');
        }

    }
}
