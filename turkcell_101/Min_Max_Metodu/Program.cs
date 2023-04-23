namespace Min_Max_Metodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Min Max Metodları
            int[] sayilar = { 76, 43, 12, 56, 34 };
            Console.WriteLine("En kucuk sayi: " + sayilar.Min());
            Console.WriteLine("En buyuk sayi: " + sayilar.Max());
        }
    }
}