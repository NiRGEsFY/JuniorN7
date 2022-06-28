using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorN7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько золота есть?");
            int gold = int.Parse(Console.ReadLine());
            int costOfCrystals = 50;
            Console.WriteLine("Сколько кристалов надо?");
            int crystalWhatYouBuy = int.Parse(Console.ReadLine());
            gold = gold - costOfCrystals * crystalWhatYouBuy;
            Console.WriteLine("У тебя: \nКристаллы - "+crystalWhatYouBuy+"\nЗолото - " + gold);
        }
    }
}
