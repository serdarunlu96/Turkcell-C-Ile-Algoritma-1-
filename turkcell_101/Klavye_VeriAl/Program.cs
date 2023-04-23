namespace Klavye_VeriAl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir, ilce;
            Console.Write("Lutfen sehrinizi girin: ");
            sehir = Console.ReadLine();
            Console.Write("Lutfen ilcenizi girin: ");
            ilce = Console.ReadLine();
            Console.WriteLine("Girdiginiz sehir ve ilce: " + sehir + "-" + ilce);
        }
    }
}