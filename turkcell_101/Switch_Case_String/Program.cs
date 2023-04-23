namespace Switch_Case_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String değişkenler ile switch case mevsim uygulaması");
            Console.WriteLine();
            Console.Write("Lutfen mevsimi giriniz: ");
            string mevsim;
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz": Console.WriteLine("Haziran - Temmuz - Ağustos"); break;
                case "ilkbahar": Console.WriteLine("Mart - Nisan - Mayıs"); break;
                case "sonbahar": Console.WriteLine("Eylül - Ekim - Kasım"); break;
                case "kış": Console.WriteLine("Aralık - Ocak - Şubat"); break;
                default: Console.Write("Hatalı mevsim girişi"); break;
            }
        }
    }
}