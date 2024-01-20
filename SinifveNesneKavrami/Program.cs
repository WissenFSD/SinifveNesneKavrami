// See https://aka.ms/new-console-template for more information

// Nesne yönetimli programlama
// Hayatta karşılaştığımız tüm nesneleri programlama aşamasında oluşturma demektir.

// 
// Ogrenci şuan 



// Sınıf : Sınıf nesne'nin şablonudur. Nesneler oluşturmak için öncelikle şablona ihtiyaç duyarız. Nesnenin özelliklerini öncesinde şablona girmemiz gerekmektedir. 
// Nesne : Sınıfdan oluşturulmuş veya oluşturulacak olan sanal üyeye verilen isimdir.
// Nesne n adet olabilir.


using SinifveNesneKavrami;
using System.Collections;


// İlk öğrenci nesnemizi oluşturduk 
Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "KEmal";
ogrenci.Soyad = "Ayaz";
ogrenci.SinifNo = 12;
ogrenci.KapiNo = 18;
ogrenci.Yas = 10;


// 2 yol (Oluşturma)
Ogrenci ogrenci2 = new Ogrenci
{
    Ad = "Yaşar",
    Soyad = "Kemal",
    Yas = 70,
    KapiNo = 20,
    SinifNo = 21,
};

// Ogrenci nesnesi üzerinden metot çağrımı yapabiliriz.
ogrenci2.OkulaGit();


// Ogrenci nesnemi temizleme(Null atamak pointerin nesneyi işaret etmemesini sağlar)
// Not : NEsne bir süre sonra GC tarafından silinecektir. 
//ogrenci2 = null;



// OGrenci nesnelerinden oluşan 5 uzunlukta bir dizi oluşuturun
Ogrenci[] ogrenciDizi = new Ogrenci[3];


ogrenciDizi[0] = ogrenci;
ogrenciDizi[1] = ogrenci2;


// Ogrenci dizisi oluşturulduğunda dizinin her bir elemanı aslında bir oğrenci pointeri olmuş olacaktır(Başlangıç değerinden ötürü) sonrasında o pointere bir nesne bağlamış oluyoruz
ogrenciDizi[2] = new Ogrenci
{
    Ad = "Murat",
    Soyad = "Göçmen",
    Yas = 15,
    KapiNo = 20,
    SinifNo = 21,
};


// Nesne dizisini ekrana yazdırmak
foreach (Ogrenci item in ogrenciDizi)
{
    Console.WriteLine("Öprenci");
    Console.WriteLine("Ad : {0}",item.Ad);
}








  