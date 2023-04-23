namespace Algoritmik_Bakteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakteri = 1;
            for (int i = 1; i <= 24; i++)
            {
                bakteri = bakteri * 2;
                Console.WriteLine(bakteri);
            }
        }
    }
}