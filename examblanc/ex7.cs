using System;

namespace examblanc
{
    public class ex7
    {
        public static void inputdata()
        {
            while (true)
            {
                Console.WriteLine("Entrez Votre data avec une virgule si besoin");
                try
                {
                    Console.WriteLine("Start hour:");

                    var start = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("End hour:");

                    var end = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Rate:");

                    var rate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Overtime:");

                    var overtime = Convert.ToDouble(Console.ReadLine());
                    OverpayCalculator(start,end,rate,overtime);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
            }
           

        }
        public static void OverpayCalculator(double start, double end, double rate, double overtime)
        {
            double pay = 0;
            if (end > 17)
            {
                pay += (end - 17) * overtime*rate;
                end =17;    
            }
            if (start < 9)
            {
                pay += (9- start) * overtime*rate;
                start = 9;
            }

            if (start > 12.5 && start < 14)
            {
                start = 12.5;
            }
            
            if (end > 12.5 && end < 14)
            {
                end = 14;

            }
            double totheure = end - start;
            if (start <= 12.5 && end >= 14)
            {
                 totheure -=1.5;
                 
            }
                    
            
            pay += totheure * rate;
            Console.WriteLine("Votre paye est de : " + pay+"euro" );
        }
    }
}