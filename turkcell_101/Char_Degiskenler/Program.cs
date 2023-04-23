namespace Char_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char degisken;
            //degisken = 'a';
            //Console.Write(degisken);

            //char deger;
            //deger = '+';
            //Console.Write(deger);

            char secim;
            Console.Write("Lutfen seciminizi yapınız: ");
            secim = Convert.ToChar(Console.ReadLine());
            Console.Write("Seciminiz: " + secim);

        }
    }
}