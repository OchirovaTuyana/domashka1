using System;

namespace zadacha4
{
    class Program
    {
        static void Main()
        {
            int N = new int();
            Console.Write("Введите число: ");
            N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < N -1 )
            {
                i += 2;
                Console.WriteLine(i);
            }
        }
    }

}    