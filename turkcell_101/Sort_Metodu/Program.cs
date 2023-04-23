namespace Sort_Metodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort Metodu
            int[] sayilar = { 20, 14, 12, 35, 13 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

        }
    }
}