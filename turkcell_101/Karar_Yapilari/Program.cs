namespace Karar_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;
            Console.Write("Sehir adi: ");
            sehir = Console.ReadLine();
            if( sehir == "adana")
            {
                Console.Write("Dogru sehir");
            }
            else
            {
                Console.Write("Yanlıs sehir");
            }
        }
    }
}