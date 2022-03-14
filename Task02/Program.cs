using System;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          Task02
          Repeat deyə bir method olsun,
          və iki parametr qəbul etsin,
          biri "word" digeri "count"
          yəni bu şəkildə "Repeat(string word, int count)"
          bu method goderilen word-u gonderilen count
          qeder yan-yana yazdirib geri qaytarsin.
          Meselen:
          Repeat("Ha!") //Ha!
          Repeat("Ha!,2)//Ha!Ha!
          Repeat("Ha!,3)//Ha!Ha!Ha!
          */
            string result = Repeat(Convert.ToString(Console.ReadLine()),
                                  (Convert.ToInt32(Console.ReadLine())));
            Console.Clear();
            Console.Write(result);
        }
        static string Repeat(string word, int count)
        {
            
            for (int i = 0; i <= count; i++)
            {
                Console.Write(word);
            }
            return word;
        }
    }
}
