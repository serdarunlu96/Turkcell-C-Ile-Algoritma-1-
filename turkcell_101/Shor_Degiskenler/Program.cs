namespace Shor_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short s1, s2, toplam;
            //s1 = 650;
            //s2 = 3456;
            //toplam = (short)(s1 + s2);
            //Console.Write(toplam);

            short a, b, c;
            Console.Write("A");
            a = short.Parse(Console.ReadLine());
            Console.Write("B");
            b = short.Parse(Console.ReadLine());
            c = Convert.ToInt16(a + b);
            Console.Write(c);
        }
    }
}