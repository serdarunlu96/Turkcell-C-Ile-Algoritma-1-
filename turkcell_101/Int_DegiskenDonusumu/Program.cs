namespace Int_DegiskenDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.Write("Sayiyi giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //Console.Write(sayi);

            int s1, s2 ,toplam;
            Console.Write("Sayi 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 + s2;
            Console.Write(toplam);
        }
    }
}