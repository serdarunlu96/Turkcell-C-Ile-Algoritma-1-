namespace Ve_VeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanici, sifre;
            Console.Write("Kullanıcı adiniz: ");
            kullanici = Console.ReadLine();
            Console.Write("Sifreniz: ");
            sifre = Console.ReadLine();

            if (kullanici =="admin" | sifre == "123456") 
            {
                Console.Write("Hosgeldiniz");
            }
            else
            {
                Console.Write("Hata");
            }
        }
    }
}