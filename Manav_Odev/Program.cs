using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hale Hoşgeldiniz");
            Console.WriteLine("Meyveler İçin M\nSebzeler İçin S'e Baasınız");
            string secim = Console.ReadLine().ToUpper();
            if (secim == "M")
            {
                Console.WriteLine("MEYVELERİMİZ\nElma\nArmut\nPortakal");
                Console.WriteLine("Alacağınız Meyvenin İsmi Ve Kilosunu Giriniz");
                int sayı = 3;             
                string[] meyve_ismi = new string[sayı];
                int[] urun_fiyatı = new int[sayı];

                for (int i = 0; i < sayı; i++)
                {
                    Console.WriteLine((i + 1) + ". ürünün adının giriniz");
                    meyve_ismi[i] = Console.ReadLine();
                    Console.WriteLine((i + 1) + ". ürünün kilosunu giriniz");
                    urun_fiyatı[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < sayı; i++)
                {
                    Console.WriteLine(meyve_ismi[i] + " " + urun_fiyatı[i]);
                }

            }
            if (secim == "S")
            {
                Console.WriteLine("SEBZELERİMİZ\nDomates\nBiber\nSalatalık");
                Console.WriteLine("Alacağınız Sebzenin İsmi Ve Kilosunu Giriniz");
                int sayı = 3;
                string[] sebze_ismi = new string[sayı];
                int[] urun_kilosu = new int[sayı];

                for (int i = 0; i < sayı; i++)
                {
                    Console.WriteLine((i + 1) + ". ürünün adının giriniz");
                    sebze_ismi[i] = Console.ReadLine();
                    Console.WriteLine((i + 1) + ". ürünün kilosunu giriniz");
                    urun_kilosu[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < sayı; i++)
                {
                    Console.WriteLine(sebze_ismi[i] + " " + urun_kilosu[i]);
                }
                Console.WriteLine("Manava Hoşgeldiniz\nAlacağınız Ürünün ismini Ve Kaç Kilo Alacağınızı Giriniz");
                string ismi = Console.ReadLine().ToUpper();
                string ismi1 = Console.ReadLine().ToUpper();
                int kilo = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
