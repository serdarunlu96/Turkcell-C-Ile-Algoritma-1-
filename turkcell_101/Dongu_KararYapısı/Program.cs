namespace Dongu_KararYapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 24 % 9;
            //Console.Write(sayi);

            //int sayi;
            //Console.Write("Sayıyı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //if(sayi % 2 == 0)
            //{
            //    Console.Write("Sayi cifttir");
            //}
            //else
            //{
            //    Console.Write("Sayi tektir");
            //}

            for (int i = 1; i <= 20 ; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}