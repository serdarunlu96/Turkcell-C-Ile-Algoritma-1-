namespace Dizi_DegerGirisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diziye dışarıdan eleman girişi
            string[] sehirler = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sehir ismi: ");
                sehirler[i] = Console.ReadLine();
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(sehirler[j]);
            }
        }
    }
}