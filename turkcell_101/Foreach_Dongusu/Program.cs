namespace Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Ankara", "Adana", "Bursa", "Izmir" };
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }
        }
    }
}