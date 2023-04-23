namespace Dıkdortgen_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dikdortgen kısa kenar giriniz: ");
            int kisa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dikdortgen uzun kenar giriniz: ");
            int uzun = Convert.ToInt32(Console.ReadLine());

            int cevre = 2 * (kisa + uzun);
            int alan = kisa * uzun;

            Console.WriteLine("Dikdortgen cevresi: " + cevre);
            Console.WriteLine("Dikdortgen alani: " + alan);
        }
    }
}