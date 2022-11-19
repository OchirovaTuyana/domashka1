using System;

namespace zadacha3
{
    class Program
    {
        static void Main()
        {
            int Number = new int();
            Console.Write("Введите число: ");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0) 
            {
                Console.WriteLine("Число является чётным");
            }
            else
            {
                Console.WriteLine("Число не является чётным");
            }
        }
    }

}    