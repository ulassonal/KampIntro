using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+toplam);
        }

        public void Cıkar(int sayi3, int sayi4) 
        {
            if (sayi3>sayi4)
            {
                int cıkarma = sayi3 - sayi4;
                Console.WriteLine("Sonuç : "+cıkarma);
            }
            else if (sayi4>sayi3)
            {
                int cıkarma = sayi4 - sayi3;
                Console.WriteLine("Sonuç : "+cıkarma);
            }
            else
            {
                Console.WriteLine("Sonuç : 0 " );
            }
        
        }
        
    }
}
