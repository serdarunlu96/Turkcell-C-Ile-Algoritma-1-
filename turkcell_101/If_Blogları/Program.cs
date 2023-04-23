namespace If_Blogları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, ort;
            Console.Write("Sınav 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınav 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınav 3: ");
            s3 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2 + s3) / 3;
            Console.Write("Ortalamanız: " + ort);

            if (ort <= 49)
            {
                Console.Write("Kaldınız.");
            }
            if (ort >= 50 & ort <= 65)
            {
                Console.Write("Durum Orta.");
            }
            if (ort >= 66 & ort <= 79)
            {
                Console.Write("Durum Iyi.");
            }
            if (ort >= 80)
            {
                Console.Write("Durum Cok Iyi.");
            }
        }
    }
}