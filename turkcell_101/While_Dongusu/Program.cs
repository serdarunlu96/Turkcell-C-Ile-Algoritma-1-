namespace While_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine("Merhaba Dunya");
            //    sayac++;
            //}

            //int sayi = 1;
            //while (sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}


            int sayi = 1;
            int toplam = 0;
            while (sayi <= 10)
            {
                toplam = toplam + sayi;
                sayi++;
            }
            Console.Write(toplam);
        }
    }
}