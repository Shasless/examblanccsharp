using System;

namespace examblanc
{
    public class ex6
    {
        
        public static void inputint()
        {
            while (true)
            {
                Console.WriteLine("Entrez Votre nombre");
                try
                {
                    var str = Console.ReadLine();
                    HarsadandMoran(int.Parse(str));
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
            }
           

        }
        public static void HarsadandMoran(int nbr)
        {
            string str = nbr.ToString();
            int intNbr = 0;
            for (var i = 0; i < str.Length; i++)  
            {  
                intNbr += int.Parse(str[i].ToString());
            }  
            if(nbr%intNbr==0)
            {
                if (prime(intNbr))
                {
                    Console.WriteLine("Moran");
                }
                else
                {
                    Console.WriteLine("Harsad");

                }
            }
            else
            {
                Console.WriteLine("Neither");
            }
        }
        
        public static bool prime(int nbr)
        {
            
            int i;  
            for (i = 2; i <= nbr - 1; i++)  
            {  
                if (nbr % i == 0)  
                {  
                    return false;  
                }  
            }  
            if (i == nbr)  
            {  
                return true;  
            }  
            return false;  
        }
    }
}