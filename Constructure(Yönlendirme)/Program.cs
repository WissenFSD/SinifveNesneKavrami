namespace Constructure_Yönlendirme_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel("Kerem", "Ayaz");
            Console.WriteLine("Şirket adı : {0}",p.CompanyName);
            Console.WriteLine("Ad : {0}",p.Name);
            Console.ReadLine();
        }
    }
}