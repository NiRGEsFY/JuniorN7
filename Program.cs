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
            Console.WriteLine("Хэй путник сколько у тебя золота в карманах?");
            int gold = 0;
            bool isTestHowMuchgold = false;
            bool isTestHowMuchcrystalBuy = false;
            int costcrystal = 50;
            uint crystal = 0;
            while (isTestHowMuchgold == false)
            {
                isTestHowMuchgold = int.TryParse(Console.ReadLine(), out gold);
                if (isTestHowMuchgold == false)
                {
                    Console.WriteLine("Что-то странное ты написал, посмотри еще раз!");
                }
                else
                {
                    if (gold < 50)
                    {
                        Console.WriteLine("У вас не хватает золото даже на один крисстал и вы уходите");
                        isTestHowMuchcrystalBuy = true;
                        break;
                    }
                    Console.WriteLine("Ну вот цена криссталла = '" + costcrystal + "'\nСколько брать будешь?");
                    break;
                }
            }
            while (isTestHowMuchcrystalBuy == false)
            {
                isTestHowMuchcrystalBuy = uint.TryParse(Console.ReadLine(), out crystal);
                if (isTestHowMuchcrystalBuy == false)
                {
                    Console.WriteLine("Что-то невнятное ты произнес, повтори пожалуйста");
                }
                else
                {
                    if ((costcrystal * crystal) > gold)
                    {
                        Console.WriteLine("У тебя нехватает золота, может поменяешь свое решение?");
                        isTestHowMuchcrystalBuy = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("После покупки вы заглянули в свой рюкзак и увидели \n" + "Криссталы - " + crystal + "\nЗолото - " + (gold - (costcrystal * crystal)));
                        break;
                    }
                }
            }
            Console.WriteLine(gold);
            Console.ReadLine();
        }
    }
}
