namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte plaka;
            Console.Write("Lutfen plakayı giriniz: ");
            plaka = byte.Parse(Console.ReadLine());

            switch (plaka)
            {
                case 1: Console.Write("Merhaba Adana"); break;
                case 2: Console.Write("Merhaba Adıyaman"); break;
                case 3: Console.Write("Merhaba Afyon"); break;
                default: Console.Write("Henuz bu sehir bilgisi girilmedi"); break;
            }
        }
    }
}