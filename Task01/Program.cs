using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
              Task 01:
              Bir method olsun iki parametr qebul etsin,
              ve bu parametrlerden birincini ikincinciye bolub neticeni geri qaytarsin.
            */

            string Result = Divide(Convert.ToDouble(Console.ReadLine()), 
                                  (Convert.ToDouble(Console.ReadLine())));

            Console.Clear();
            Console.WriteLine(Result);

        }
        static string Divide(double Num1, double Num2)
        {
            double Sum = Num1 / Num2;

            return $"{Num1} / {Num2} = {Sum}";
        }



    }
}
