using System;
using System.Collections.Generic;

namespace examblanc
{
    public class ex3
    {
        public static void throwdice()
        {
            double stat = 0;
            List<int> hand = new List<int>();
            for(int i = 0; i < 999; i++)
            {
                hand = fivedices();
                stat += iscorrect(hand);

            }
            Console.WriteLine("Sur 1000 lancer il y a " + stat + " contenant  4 2 1. Ce qui donne une statde "+stat/1000*100+"%");
        }
        
        public static List<int> fivedices()
        {
            Random aleatoire = new Random();
            List<int> hand = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                int rand = aleatoire.Next(1,7);
               hand.Add(rand);

            }
           // hand.ForEach(Console.Write);
           // Console.WriteLine();
            return hand;
        }
        public static int iscorrect(List<int> hand )
        {
            if (hand.Contains(1))
            {
                if (hand.Contains(2))
                {
                    if (hand.Contains(4))
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}