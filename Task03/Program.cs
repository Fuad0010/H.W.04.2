using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.

            Console.Write("Toplamaq istediyniz ededin miqdarini yazin:");
            int result = Collect(Convert.ToInt32(Console.ReadLine()),(Convert.ToInt32(Console.ReadLine())));
            Console.Clear();
            Console.Write($"Toplam:{result}");

        }
        static int Collect(int number,int num)
        {
            for (int i = 1; i < number; i++)
            {
             num += Convert.ToInt32(Console.ReadLine());
            }

            return num;
        }




    }
}
