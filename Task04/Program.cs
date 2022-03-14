using System;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Sahe deyə Method(lar) yaradılır.
             Çevrənin sahəsi - S = p*r² (p=3)
             Düzbucaqlının sahəsi - S = a*b
             Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2
             */
            int result = Sahe(10,12);
            Console.WriteLine(result);
        }
        
        static double Sahe (int P = 3,double R = 5)
        {
            
            double S = P * (R*R);
            return S;
        }
        static int Sahe (int A,int B)
        {
            int S = A * B;
            return S;
        }
        static int Sahe (int P = 5, int R = 4, int a = 6,int b = 2,int c = 8)
        {
            int S = P * R;
            P = (a + b + c) / 2;
            return S;
        }
    
    }
}
