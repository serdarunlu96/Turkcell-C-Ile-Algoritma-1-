namespace Sbyte_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sbyte sayi;
            //sayi = 123;
            //Console.Write(sayi);

            //sbyte sayi2;
            //Console.Write("Sayiyi giriniz: ");
            //sayi2 = Convert.ToSByte(Console.ReadLine());
            //Console.Write(sayi2);

            sbyte sayi1, sayi2, toplam;
            Console.Write("Sayi1 giriniz: ");
            sayi1 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Sayi2 giriniz: ");
            sayi2 = Convert.ToSByte(Console.ReadLine());
            toplam = Convert.ToSByte(sayi2 + sayi2);
            Console.Write(toplam);
        }
    }
}