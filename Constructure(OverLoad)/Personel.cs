using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructure_OverLoad_
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }


        public Personel()
        {
            // nesne oluşturulurken belleğe çıkması gereken kodlar yazılır atamalar yapılır
            //Ad = "Ahmet";
        }
        public Personel(string ad)
        {
            this.Ad = ad;
        }
        public Personel(string ad,string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Personel(string ad,string soyad,int yas)
        {
            // bu ctor aşırı yüklenmiş bir ctor'dur. Nesne belleğe çıkarken  ad soyad ve yaş değerinide alıp bellege çıkacaktır.
            //Ad=ad;
            //Soyad=soyad;
            //Yas=yas;

            // iki farklı şekilde atama yapılabilir. This anahtar sözcüğü sadece karışıklığı önlemek amacı ile bu sınıfa ait üyeleri listelemek için kullanılır
            this.Ad = ad;
            this.Yas = yas;
            this.Soyad = soyad;
        }
    }
}
