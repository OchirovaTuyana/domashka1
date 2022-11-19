using System;

namespace zadacha1
{
    class Program
    {
        static void Main()
        {
            int Number1 = new int();
            Console.Write("Введите певрое число: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = new int();
            Console.Write("Введите второе число: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Number3 = new int();
            Console.Write("Введите третье число: ");
            Number3 = Convert.ToInt32(Console.ReadLine());
            int max = Number1;
            if (Number1 > max) max = Number1;
            if (Number2 > max) max = Number2;
            if (Number3 > max) max = Number3;
            Console.WriteLine ($"Максимальное число: {max}");
            
        }
    }

}    

