namespace Constructure_OverLoad_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Default Ctor nesnenin üyelerinin değeri boş oluştu.
            Personel p1 = new Personel();

            //  parametreli ctor sadece ad verisi alan ctor
            Personel p2 = new Personel("Yaşar");

            //  Ad ve Soyad olan ctor ile nesne üretimi
            Personel p3 = new Personel("Yaşar", "Kemal");


            // Ad Soyad ve Yaş olan ctor nesne üretimi
            Personel p4 = new Personel("Yaşar", "Kemal", 40);



        }
    }
}