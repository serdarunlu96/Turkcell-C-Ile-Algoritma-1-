namespace Dizilerde_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizlerde Toplama Islemi");
            Console.WriteLine();
            int[] sayilar = { 10, 20, 30,40,50,60,70,80,90 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
                Console.WriteLine(toplam);
            }
            Console.WriteLine();
            Console.WriteLine(toplam);
        }
    }
}