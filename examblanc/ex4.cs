using System;
using System.Linq;

namespace examblanc
{
    public class ex4
    {
        
        public static void inputstrf()
        {
            while (true)
            {
                Console.WriteLine("Entrez Votre argument");
                try
                {
                    string str = Console.ReadLine();
                    casinverter(str);
                    break;
                }
                catch (Exception e)
                {
                }
                
            }
           

        }
        public static void casinverter(string str)
        {
           Console.WriteLine(str.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                   char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
        }
    }
}