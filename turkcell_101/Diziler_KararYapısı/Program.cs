namespace Diziler_KararYapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizilerle berarber karar yapısı kullanımı
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 20 == 0 || sayilar[i] % 30 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
        }
    }
}