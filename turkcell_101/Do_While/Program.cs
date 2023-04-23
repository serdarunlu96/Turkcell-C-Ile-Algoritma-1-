namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi <= 10);
        }
    }
}