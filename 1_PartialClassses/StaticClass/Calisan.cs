using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ClassTypes.StaticClass
{
    public class Calisan
    {

        // static üye => nesne oluturmadan erilebilen üyelerdir. Dikkatli kullanıldığı sürce verimli varlıklardır..;

        // static field
        public static string KurumAdi;

        // static metot
        public static void KurumAdiYazdir()
        {
            Console.Write(KurumAdi);
        }

        public static int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public string Adi { get; set; }


        // static üyelerin gövdelerin sadece static üyelere erişebilir...

        private static int myField { get; set; }
        public static int MyProperty
        {
            get
            {
                return myField;
            }
            set
            {
                myField = value;
            }
        }

    }
}
