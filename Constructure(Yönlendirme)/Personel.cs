using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructure_Yönlendirme_
{
    public class Personel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string CompanyName { get; set; }

        public int Age { get; set; }

        public Personel()
        {
            // Her zaman sabit olan ve belleğe çıkması istenen şey yazılır.
            this.CompanyName = "Türk Şeker A.Ş";
        }
        public Personel(string name)
        {
            this.Name = name;
        }

        //this() ifadesi ile bir ctor başka bir ctor'a yönlendirilebilir. 
        // Bu örnekte, iki parametre alan ctor default ctor'a yönlendirildi.


        //  ne için bu yöntemi kullanabiliriz


        // ÖRnek
        // bir nesne oluşturmak istiyoruz bunun için bir ctor yazdık. Ancak bu nesne de birde kullanıcı tarafından verilmeyecek olan sabit bir değer var. Bu örnekte bu değer CompanyName değeri oldu. CompanyName alanına dışarıdan bir değer gelmemesini ancak nesne ile bellleğe çıkması için CompanyName alanına ait değeri Default Ctor içerisinde verdik. Nesne 2 parametreli ctor ile ayağa kaldırıldığında 2 parametreli ctor'u default Ctor'a yönlendirdik. Böylece hem 2 parametreli ctor ile nesne ayağa kalktı hemde default ctor çalışarak CompanyName alanını da ayağa kaldırdı.

        //c# da istenilen ctor farklı ctorlara yönlendirilebilir.
        // Buradaki önemli konu yönlendiğiniz ctor'un verisini de veriyor olmanızdır.
        public Personel(string name, string surname):this() { 

            this.Name = name;
            this.Surname = surname;
        }
        public Personel(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age; 
        }
    }
}
