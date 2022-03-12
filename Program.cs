using System;

namespace TrainingPractice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас золота?");
            int temp_gold;
            temp_gold = Convert.ToInt32(Console.ReadLine());
            int crystal_price = 3;
            Console.WriteLine("Вы можете купить максимум " + temp_gold / crystal_price + " кристалов по цене " + crystal_price + " за штуку");
            Console.WriteLine("Сколько хотите купить кристалов?");
            int buy_crystal;
            buy_crystal = Convert.ToInt32(Console.ReadLine());
            int max_buy_crystal = temp_gold / crystal_price;
            if (buy_crystal > max_buy_crystal)
            {
                Console.WriteLine("Вы не можете купить столько кристалов " + ", у вас всего лишь " + temp_gold + " золота. ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы купили " + buy_crystal + " кристалов. У вас осталось " + (temp_gold - buy_crystal * crystal_price) + " золота");
                Console.ReadKey();
            }
        }
    }
}
