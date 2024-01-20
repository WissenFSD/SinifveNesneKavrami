using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsolution
{
    public class Araba
    {
        // Kapsülleme de kapsüllenen değişken her zaman private olarak işaretlenir
        // Private işaretlenen değişkenin dış dünya ile bağlantısı kesilmiştir.
        // Dış dünya ile bağlantısı sadece yazılan metotlar sayesinde olacaktır.
        private string Name;

        public void set_Name(string value)
        {
            // Global değişkeni korumak önemlidir. Onun için bu kapsülleme yapılmaktadır.
            // set metodu içerisinde global değişkene gelecek olan değer kontrol edilir.
            // kontroller sonucu atanmaması gereken bir durum var ise değer kesinlikle atanmaz
            Name = value;
        }
        public string get_Name()
        {
            return Name;
        }
        


    }
}