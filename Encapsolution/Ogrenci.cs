using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Ogrenci
    {
        private int Yas;

        public void set_Yas(int value)
        {
            if(value>7 && value < 20)
            {
                Yas = value;
            }
            else
            {
                throw new Exception("Invalid Age");
            }
        }
        public int get_Yas() {
        
            return Yas;
        }
    }
}
