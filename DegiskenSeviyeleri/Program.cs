namespace DegiskenSeviyeleri
{
    
    internal class Program
    {


        // 2 seviye değişken vardır
        // Bunlardan biri metot seviyesinde değişken
        // Diğeri class seviyesinde değişkendir.


        // Metot seviyesinde olan değişkenlere local değişken
        // Class seviyesinde olan değişkenlere global değişken denir


        // Global değişkenler her zaman korunmak zorundadır.

        // Korunması demek atanan ve okunan tüm değerlerin kontrolü bir biçimde yapılmasıdır.
        
        static void Main(string[] args)
        {

            // Local değişken
            int a = 10;

        }
        public void Test()
        {
            // Local değişken
            int a = 10;

        }
    }
}