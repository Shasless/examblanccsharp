using System;

namespace examblanc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex 1:");

            ex1 ex1 = new ex1();
            ex1.armstrong();
            Console.WriteLine("Ex 2:");

            ex2 ex2 = new ex2();
            ex2.callfbi();
           
           Console.WriteLine("Ex 3:");

            ex3 ex3 = new ex3();
            ex3.throwdice();
            Console.WriteLine("Ex 4:");

            ex4 ex4 = new ex4();
            ex4.inputstrf();
           Console.WriteLine("Ex 5:");

           ex5 ex5 = new ex5();
           ex5.inputstrf();
           Console.WriteLine("Ex 6:");

           ex6 ex6 = new ex6();
           ex6.inputint();
           Console.WriteLine("Ex 7:");

           ex7 ex7 = new ex7();
           ex7.inputdata();
          // ex7.OverpayCalculator(9.5,18, 10, 2.2);
          // ex7.OverpayCalculator(15,18, 10, 1.5);
          // ex7.OverpayCalculator(9,13.5, 8.2, 3);
        }
    }
}