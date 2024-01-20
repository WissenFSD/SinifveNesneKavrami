using Encapsulation;

namespace Encapsolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Araba sınıfına artık global değişken üzerinden değil onu kapsülleyen metot ile eriştik
            Araba a = new Araba();
            a.set_Name("Renault");

            // Ogrenci sınıfının içerisinde Yas global değişkenini kapsülleme iile validasyon yaptık
  
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.set_Yas(50);

            Wissen wissen = new Wissen();
            wissen.Name = "Beşiktaş";

            City city = new City();
            city.Name = "İstanbul";


        }
    }
}