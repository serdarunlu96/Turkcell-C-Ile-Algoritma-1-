namespace Int_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Int degiskenler ile dizi kullanımı
            Console.WriteLine("Int degiskenler ile dizi kullanımı");
            Console.WriteLine();
            int[] sayilar = {10,20,30,40,50,60,70 };
            Console.WriteLine(sayilar[4]);
            Console.WriteLine();
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}