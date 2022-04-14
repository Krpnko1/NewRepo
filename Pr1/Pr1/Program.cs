using System;

namespace Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Obyv a = new Obyv();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 - Добавить обувь" + " " +
                "2 - Вывести обувь" + " " + "3 - Выход");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            a.Input();
                            break;
                        }
                    case 2:
                        {
                            a.Print();
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}
