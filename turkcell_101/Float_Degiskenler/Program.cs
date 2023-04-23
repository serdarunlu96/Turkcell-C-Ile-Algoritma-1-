namespace Float_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float sayi, sayi1;
            //sayi = 345;
            //sayi1 = 345.67f;
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi1);

            float s1, s2, toplam;
            
            Console.WriteLine("Sayi1 giriniz:");
            s1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sayi2 giriniz:");
            s2 = float.Parse(Console.ReadLine());
            toplam = s1 + s2;
            Console.Write(toplam);
        }
    }
}