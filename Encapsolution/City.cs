using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // Encapsulation son version 

    // Yeni nesil kapsülleme de korunacak bir field olmuyor.
    // Direk olarak get ve set olan property'ler yazılıyor
    // İstenilirse set veya get private olarak işaretlenebiliyor.

    // istenilirse bu şekilde değer ataması gerçekleştiriliyor
    public class City
    {
        public string Name { get; } = "Test";


     
    }
}
