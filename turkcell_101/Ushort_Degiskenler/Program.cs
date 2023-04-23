namespace Ushort_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ushort s1, s2, toplam;
            //s1 = 34;
            //s2 = 56;
            //toplam = (ushort)(s1 + s2);
            //Console.Write(toplam);

            ushort kenar1, kenar2, alan, cevre;
            Console.Write("Kısa kenarı giriniz: ");
            kenar1 = ushort.Parse(Console.ReadLine());
            Console.Write("Uzun kenarı giriniz: ");
            kenar2 = ushort.Parse(Console.ReadLine());
            alan = (ushort)(kenar1 * kenar2);
            cevre = (ushort)(kenar1 + kenar1 + kenar2 + kenar2);
            Console.Write("Alan: " + alan + " Cevre: " + cevre);
        }
    }
}