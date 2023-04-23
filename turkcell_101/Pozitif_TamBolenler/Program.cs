namespace Pozitif_TamBolenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tam bolenleri bulma
            // 20 --> 1 2 4 5 10 20
            int sayi;
            Console.Write("Sayiyi giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if(sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}