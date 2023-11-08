using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşullar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Koşullar programlama akışı kontrol etmek e yön vermek için kullanılan araçlardır.
            */

            #region Tanımlama

            //if (Koşul parantezi) Koşul parantezi içerisindeki kod MUTLAKA boolean veri üretmelidir.
            //{
            //Şartım sağlanıyor ise bu parantezler arasını çalıştır.
            //Şağlanmıyorsa bu parantezin içindeki kodları tamamen atla.
            //}

            #endregion

            #region Kullanım

            //// if ile beraber else kullanılırsa = ya if ya ese çalışır.

            //int sayi = 9;

            //if (sayi > 10)
            //{
            //    Console.WriteLine("Sayı 10'dan büyük");
            //}
            //else  // Doğrudan if'in koşuluna bağlı
            //{
            //    Console.WriteLine("Sayı 10'dan küçük");
            //}
            //// Console.WriteLine("Koşul alaını dışı");
            #endregion

            #region  konsoldan alınan sayı negatif mi pozitif mi?

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //string s1 = Console.ReadLine();
            //int s2 = Convert.ToInt32(s1);

            //if (s2 > 0)
            //{
            //    Console.WriteLine("Sayı Pozitif ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Negatif ");
            //}

            #endregion

            #region Konsoldan alınan sayı çiftmi tek mi?

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //string s1 = Console.ReadLine();
            //int s2 = Convert.ToInt32(s1);
            //int kalan = s2 % 2;

            //if (kalan ==0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı tek");
            //}

            #endregion

            #region Konsoldan alınan 2 sayının ortalaması

            //Console.WriteLine("Lütfen notunuzu girin");
            //double s1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen notunuzu girin");
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (s1 + s2) / 2;
            //Console.Write("Ortalama =");
            //Console.WriteLine(ortalama);

            //if (ortalama >= 50)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Geçtiniz");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Kaldınız");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}


            #endregion

        }
    }
}