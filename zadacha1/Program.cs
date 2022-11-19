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
            if(Number1 < Number2)
            {
                Console.WriteLine ($"Большее число: {Number2}");
                Console.WriteLine ($"Меньшее число: {Number1}");
            }
            else
            {
                Console.WriteLine ($"Большее число: {Number1}");
                Console.WriteLine ($"Меньшее число: {Number2}");
            }    
        }
    }

}    

