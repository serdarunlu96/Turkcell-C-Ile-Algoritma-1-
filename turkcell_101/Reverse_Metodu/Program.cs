namespace Reverse_Metodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Adana", "Ankara", "Zonguldak", "Malatya", "Elazığ", "Bursa" };
            // Array.Reverse(sehirler);
            Array.Sort(sehirler);
            Array.Reverse(sehirler);
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
        }
    }
}