using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongu
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // (1) 1 den 10'a kadar yazdıran döngü.
            /*for (int i = 1; i <= 10; i++)
            {
               Console.WriteLine(i);
            }
            Console.ReadKey();*/

            // (2) 1 ile 40 arasındaki çift sayıları toplayarak yazdıran döngü.
            /*int toplam = 0;
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                    toplam += i;
            }
            Console.WriteLine(toplam);
            Console.ReadKey();*/

            // (3)  Klavyeden Girilen sayının faktöriyelini bulma . (Girilen i değerini 1'er azaltarak çarp.)
            /*Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int i = sayi; i > 1; i--)
            {
                sonuc *= i;
            }
            Console.Write("Faktöriyeli:" + sonuc);
            Console.ReadKey(); */


            // (4) İki sayı arasındaki sayıları belirlenen adıma göre toplayan program
            //örn:başlangıç:10 bitiş:20 adım:2 ise toplam=10+12+14+16+18+20 şekliden oluşacak

            /*int baslangic, bitis, adim, toplam = 0;

            Console.Write("Döngü Başlangıç değerini giriniz:");
            baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Döngü Bitiş değerini giriniz:");
            bitis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Döngü Adım değerini giriniz:");
            adim = Convert.ToInt32(Console.ReadLine());

            for (int i = baslangic; i <= bitis; i += adim)
            {
                toplam = toplam + i;

            }
            Console.WriteLine("Sonuc=" + toplam);
            Console.ReadLine();
            */

            // (5)Taban ve Kuvveti girilen sayının değerini hesaplama
            //Örn: taban:2 üs:5 girildiğinde sonuc=32 yazıdıran program. 

            /*
            int taban, us, sonuc = 1;
            Console.Write("Taban sayısını giriniz:");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kuvvet sayısını giriniz:");
            us = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }

            Console.WriteLine("Tabanı {0} ve kuvveti {1} olan sayının değeri={2}", taban, us, sonuc);

            Console.ReadLine();*/

            // (6) 1-100 arasındaki sayıların kullanıcının girdiği sayıya tam olarak bölünenleri ekrana yazdırma
            //örnek kullanıcı 25 girdi 25,50,75,100 tam olarak bölünür.
            //örnek kullanıcı 3 girdi 3,6,9,......93,96,99

            /*int sayi;
            Console.Write("Bölen sayıyı giriniz...:");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                if (i % sayi == 0)
                {
                    Console.WriteLine("{0} sayısı kalansız bölünür", i);
                }

            }
            Console.ReadKey(); */

            // (7) Kullanıcıdan Aldığı metni 10 kere yazdıran program
            /*Console.Write("Metni Gir : ");
            string metin = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadKey();*/

            // (8) Klavyeden girilen bir sayıya kadar tek sayıların ve çift sayıların toplamını bulan program
            /*int cifttoplam = 0;
            int tektoplam = 0;
            int sayi = 0;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i & Lt; = sayi; i++)
            {
                if (i % 2 == 0)
                {
                    cifttoplam += i;
                }
                else
                {
                    tektoplam += i;
                }
            }
            Console.WriteLine(sayi + " sayısına kadar tek sayıların toplamı: " + tektoplam);
            Console.WriteLine(sayi + " sayısına kadar çift sayıların toplamı: " + cifttoplam);
            Console.ReadKey();*/

            // (9)  Kullanıcının girdiği 10 sayıdan 50 den küçük olanların adetini bulan ve gösteren Console Örneği
            /*int sayi, adet = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ".sayıyı Girin : ");
                sayi = Int32.Parse(Console.ReadLine());
                if (sayi < 50)
                {
                    adet++;
                }
            }
            Console.WriteLine("50 den küçük girilen sayı adeti : " + adet);
            Console.ReadKey();*/

            // (10) Kullanıcının girdiği 5 sayıdan 50′ den büyük olanların toplamını gösteren Console Örneği

            /*int sayi, toplam = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + ".sayıyı Girin : ");
                sayi = Int32.Parse(Console.ReadLine());
                if (sayi > 50)
                {
                    toplam += sayi;
                }
            }
            Console.WriteLine("50 den büyük girilen sayıların toplamı : " + toplam);
            Console.ReadKey();*/

            // (11)  Klavyeden girilecek olan  10 sayıdan en büyük ve en küçük olanı ekrana yazdıran döngü
            /*int eb, ek, sayi;
            Console.Write("1. sayıyı giriniz :");
            sayi = int.Parse(Console.ReadLine());
            eb = sayi;
            ek = sayi;
            for (int i = 2; i <= 10; i++)
            {
                Console.Write("{0}. sayıyı giriniz :", i);
                sayi = int.Parse(Console.ReadLine());
                if (ek > sayi) ek = sayi;
                if (eb < sayi) eb = sayi;
            }
            Console.WriteLine("En büyük sayı {0}", eb);
            Console.WriteLine("En küçük sayı {0}", ek);
            // Console.WriteLine("En büyük sayı {0} \n En küçük sayı {1}", eb,ek); 
            Console.ReadKey();*/

            // (12)  1 ile 50 arasındaki çift sayıları çarpımlarının sonucu ekranda yazdıran  döngü
            //  çarpımda  1 atamammız gerekir etkisiz eleman
            /*int carpim = 1;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                    carpim *= i;
            }
            Console.WriteLine("1-100 arası çift sayıların çarpımı:{ 0}", carpim);
            Console.ReadKey();*/

            // (13) 1’den 10’a kadar olan çarpım tablosunu yazdıran döngü
            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1}={2}", i, j, i * j);
                }
                Console.WriteLine("________\n");
            }
            Console.ReadKey();*/

            // (14) 100 ile 200 Arasındaki Çift Sayıların Toplamının Ortalaması
            /*int i;

            double toplam = 0;

            for (i = 100; i & lt;= 200; i += 2)
 
            {

                toplam += i;

                Console.WriteLine(toplam);

            }

            toplam /= i;

            Console.WriteLine(toplam);

            Console.ReadKey();*/

            // (15) Girilen iki sayını arasındaki sayıların toplamını bulan program
            /*int toplam = 0, a, b;

            Console.WriteLine("Bir sayi giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayi giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {

                toplam += i;

            }

            Console.WriteLine("Toplam : {0}", toplam);

            Console.ReadKey();*/


        }



    }
    }

