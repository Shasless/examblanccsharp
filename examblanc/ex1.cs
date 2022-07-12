using System;

namespace examblanc
{
    public class ex1
    {
        public static void armstrong()
        {
            var digit = 0;
            for (int i = 99; i < 1000; i++)
            {
                
                var n = i;
                var sum = 0;
                while (n > 0)
                {
                    digit = n % 10;
                    sum += digit*digit*digit;
                    n = n / 10;
                }
                
                if( i == sum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}