namespace Double_DegiskenDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen ondalıklı sayıyı ejranan yazdıran kod blogu
            double sayi1 ,sayi2 ,toplam;
            Console.Write("Sayi1 giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayi2 giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.Write("Sonuc: " + toplam);
        }
    }
}