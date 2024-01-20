using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructure_Yapıcı_Metot_
{
    public class Ogrenci
    {
        public string Name { get;  set; }
        public string Soyad { get; set; }




        // Default constructor(kısa adı ile ctor)


        // Ctor nesne belleğe çıkarken yanında çıkarılacak olan değerleri kapsar
        // Ctor içerisine yazılacak olan değerler nesne belleğe çıkarken çalıştırılacaktır
        // Ctor her nesne için bir kez çalışır
        // Ctor metoda benzer metotlardan farkı geri dönüş tipinin olmaması ve Adının sınıfın adı ile aynı olması gerekmektedir.
        // Eğer siz bir ctor yazmazsanız derleyici sizin yerinize bir tane ctor yazacaktır
        // Aşağıdaki ctor default ctor olarak da adlandırılabilir.


        // to be contunied ;

        public Ogrenci()
        {
            Name = "Ahmet";
            Soyad = "Gümüş";
                
        }
    }
}
