namespace Ogrenci_SınavNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.Write("Sayiyi giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi == 23)
            //{
            //    Console.Write("Sayi dogru girildi");
            //}
            //else
            //{
            //    Console.Write("Sayi yanlis girildi");
            //}

            int s1, s2, ort;
            Console.Write("Sınav 1: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav 2: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.Write("Ortalamanız: " + ort);

            if (ort >= 50)
            {
                Console.Write("-Gectiniz");
            }
            else
            {
                Console.Write("-Kaldınız");
            }

        }
    }
}