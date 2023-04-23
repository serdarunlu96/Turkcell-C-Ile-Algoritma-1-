namespace EsitDegil_Operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            Console.Write("Karakteri giriniz: ");
            karakter = Convert.ToChar(Console.ReadLine());

            if(karakter != 'a')
            {
                Console.Write("a harfi girmediniz. Tebrikler");
            }
            else
            {
                Console.Write("Maalesef, a harfi girdiniz");
            }
        }
    }
}