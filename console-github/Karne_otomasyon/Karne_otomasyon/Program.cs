using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karne_otomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            int yas, sube,snv1,snv2,proje;
            double ortalama;

            //Öğrenci bilgi//

            Console.WriteLine("Adınızı girin:");
            ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı girin:");
            soyad = Console.ReadLine();

            Console.WriteLine("Yaşınızı girin:");
            yas = int.Parse(Console.ReadLine());

            Console.WriteLine("Şubenizi girin:");
            sube = int.Parse(Console.ReadLine());

            //Sınav notu//

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("1.Sınavı girin:");
            snv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sınavı girin:");
            snv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Proje Notunu girin:");
            proje = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("*****ÖĞRENCİ BİLGİ*****");

            Console.WriteLine();

            Console.WriteLine("Adınız:" + ad + "\nSoyadınız:" + soyad + "\nYaşınız:" + yas + "\nŞubeniz:" + sube);

            Console.WriteLine("");

            ortalama = (snv1 + snv2 + proje) / 3;
            Console.WriteLine("Ortalama = " + ortalama);

            Console.WriteLine("");

            if (ortalama > 50)
            {
                Console.WriteLine("Sınıfı Geçtiniz...");
            }
            else
            {
                Console.WriteLine("Sınıfta Kaldınız...");
            }

            Console.ReadLine();
        }



            
        }
    }
