using System;
using System.Linq;

namespace examblanc
{
    public class ex5
    {
        public static void inputstrf()
        {
            while (true)
            {
                Console.WriteLine("Entrez Votre phrase");
                try
                {
                    string str = Console.ReadLine();
                    Smoooooth(str);
                    break;
                }
                catch (Exception e)
                {
                }
                
            }
           

        }
        public static void Smoooooth(string str)
        {
            string[] subs = str.ToLower().Split(' ');

            if(subs.Length==1 || subs.Length==0)
            {
                Console.WriteLine("Votre phrase est trop courte");
                inputstrf();
            }
           
            for(int i = 0; i < subs.Length-1; i++)
            {
   
                if(subs[i][subs[i].Length-1]!=subs[i+1][0])
                {

                    Console.WriteLine("La phrase n'est pas  smooth :(");
                    return;
                }
            }
            Console.WriteLine("La phrase est smooth :)");
        }
    }
}