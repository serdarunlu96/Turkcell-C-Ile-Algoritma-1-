namespace Ogrenci_Not_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, bolum, ders;
            int s1, s2, s3, ort;

            //string degisken atamaları
            ad = "Serdar";
            soyad = "Unlu";
            bolum = "Bilgisayar Muhendisligi";
            ders = "C# Programlama";

            //Int degisken atamaları
            s1 = 65;
            s2 = 70;
            s3 = 88;
            ort = (s1 + s1 +s3) / 3;

            //Yazdırma komutları
            Console.WriteLine("***** Ogrenci Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("Ogrenci adı ve soyadı: " + ad + " " + soyad);
            Console.WriteLine("Ogrenci bolumu: " + bolum);
            Console.WriteLine("Ders: " + ders);
            Console.WriteLine("Sınav 1: " + s1);
            Console.WriteLine("Sınav 2: " + s2);
            Console.WriteLine("Sınav 3: " + s3);
            Console.WriteLine("Ortalamanız: " + ort);
        }
    }
}