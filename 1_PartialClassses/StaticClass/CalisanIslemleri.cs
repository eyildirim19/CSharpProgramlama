using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ClassTypes.StaticClass
{

    // static classlar içerisinde static üye geliştirmek için kullanılan sınıflar..
    public static class CalisanIslemleri
    {
        // Name üyesi static olmadığı için static sınıflarda tanımlanamazlar...
        //  public string Name { get; set; }

        public static decimal MaasHesapla(int gun, decimal gunlukUcret)
        {
            return gunlukUcret * gun;
        }

        public static int IzınHesapla(Calisan cls)
        {
            int kullanilabilirIzın = 0;

            // calisana göre zin hesapla...


            return kullanilabilirIzın;
        }
    }
}