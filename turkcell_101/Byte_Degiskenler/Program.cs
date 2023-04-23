namespace Byte_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte sayi1, sayi2, toplam;
            //sayi1 = 24;
            //sayi2 = 36;
            //toplam = Convert.ToByte(sayi1+sayi2);
            //Console.Write(toplam);

            byte s1, s2, carpim;
            Console.Write("1.Sayi: ");
            s1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2.Sayi: ");
            s2 = Convert.ToByte(Console.ReadLine());
            carpim = Convert.ToByte(s1*s2);
            Console.Write(carpim);
        }
    }
}