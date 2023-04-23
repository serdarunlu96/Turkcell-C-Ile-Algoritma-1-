namespace IndexOf_Metodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IndexOf Metodu
            string[] kisiler = { "Buse", "Ali", "Hakan", "Furkan", "Eylül" };
            int sira;
            Array.Sort(kisiler);
            sira = Array.IndexOf(kisiler, "Hakan");
            Console.Write(sira);
        }
    }
}