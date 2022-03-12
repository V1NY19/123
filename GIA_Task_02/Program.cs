using System;

namespace GIA_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите exit для остановки цикла");
            string a = "exit";
            string b = "";
            while (b != a)

            {
                Console.Write("Цикл работает, для остановки напиши exit ");
                b = Console.ReadLine();
            }
            Console.WriteLine("Цикл завершён");
            Console.ReadKey();
        }
    }
}
