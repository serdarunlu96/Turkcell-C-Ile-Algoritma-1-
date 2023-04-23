namespace Bool__Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool durum;
            //durum = true;
            //Console.Write("Ogrenci sınavı gecti mi?: ");
            //Console.Write(durum);

            bool uyemi;
            Console.Write("Kullanıcı sisteme uye mi?: ");
            uyemi = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Kullanıcının sistem uyelik durumu " + uyemi);
        }
    }
}