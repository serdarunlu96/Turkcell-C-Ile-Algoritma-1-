namespace Ardisik_Sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;
            //// 0 1 2 3 4 5
            //// 0 1 3 6 10 15 --> toplam = toplam + i
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);

            //5 faktöriyel
            int faktoriyel = 1;
            for (int i = 5; i >= 1; i--)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine(faktoriyel);
        }
    }
}