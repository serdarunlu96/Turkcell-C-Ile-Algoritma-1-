namespace Foreach_Aritmetik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach ve Aritemetik İşlemler
            //int[] sayilar = { 23, 55, 32, 16, 89, 70 };
            //int toplam = 0;
            //foreach (int x in sayilar) 
            //{
            //    toplam = toplam + x;
            //}
            //Console.Write("Toplam: " + toplam);

            int[] sayilar = { 34, 22, 11, 67, 89, 50 };

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }

        }
    }
}