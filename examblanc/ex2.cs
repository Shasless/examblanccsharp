using System;

namespace examblanc
{
    public class ex2
    {
        public static void callfbi()
        {
            while (true)
            {Console.WriteLine("Entrez un string");
                try
                {
                    string str = Console.ReadLine();
                fbi(str);
                    break;
                }
                catch (Exception e)
                {
                }
                
            }
           

        }
        public static void fbi(string s)
        {
            Random aleatoire = new Random();

            for(int i = 0; i < s.Length/3; i++)
            {
                int rand = aleatoire.Next(s.Length);
                s= s.Remove(rand, 1).Insert(rand, "*");

            }
            Console.WriteLine(s);
        }

    }
}