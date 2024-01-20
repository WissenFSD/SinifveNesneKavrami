using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    
    // Kapsüllemek c# 1.0 dan sonra güncellendi. Kısa yazımı şu şekilde oldu


    //  version 2.0 encapsulation
    public class Wissen
    {

        private string _name;
        public string Name 
        { 
            get { return _name; }
            set 
            {

                // validasyon için kod yazilabilir.
                _name = value; 
            
            
            }
        }
           
}

    }
}
