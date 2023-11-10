using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worlist_algoritması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("istediğiniz uzunluğunu girin: ");
            int wordlistUzunlugu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kaç tane rastgele kelime veya rakam üretmek istiyorsunuz? ");
            int kelimeSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            List<string> brute_force = WordlistOlustur(wordlistUzunlugu, kelimeSayisi);

            Console.WriteLine("Oluşturulan Wordlist:");
            Console.WriteLine("\n");
            foreach (string kelime in brute_force)
            {
                Console.WriteLine(kelime);
            }

            Console.ReadLine();
        }

        static List<string> WordlistOlustur(int uzunluk, int adet)
        {
            Random random = new Random();
            const string karakterler = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            List<string> brute_force = new List<string>();

            for (int i = 0; i < adet; i++)
            {
                char[] kelime = new char[uzunluk];
                for (int j = 0; j < uzunluk; j++)
                {
                    kelime[j] = karakterler[random.Next(karakterler.Length)];
                }
                brute_force.Add(new string(kelime));
            }

            return brute_force;
        }
    }
}
