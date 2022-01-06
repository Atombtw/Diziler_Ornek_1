using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();   
            
            Console.Write("Metin giriniz : ");
            class1.metin = Console.ReadLine();
            for (int i = 0; i < class1.harfler.Length; i++)
            {
                for (int j = 0; j < class1.metin.Length; j++)
                {
                    if (class1.metin[j] == class1.harfler[i])
                    {
                        class1.sayac++;
                    }
                }
            }
            Console.Write("Cümledeki Sesli Harf Sayısı : " + class1.sayac);
            Console.ReadKey();
        }
    }
}
