namespace Length_Komutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length Komutu Kullanımı");
            Console.WriteLine();

            string[] kisiler = { "ali","veli","ayse","ahmet","eylül", };
            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i]);
            }
            Console.WriteLine();
            Console.WriteLine(kisiler.Length);
        }
    }
}