using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ExtensionsMetot.MyExtenions
{
    public static class UzantiMetotlar
    {
        // Extension metots => C# içerisindeki ön tanımlı tiplere(class,struct,interface) yapılarını bozmadan modül eklemek için kullanılır..
        // Extension metotlar static olmalıdır,static üyelerde static classlar içerisinde olmalıdır.....bir metodun extension metot olabilmesi için parametre this ifadesi ile tanımlanır...
        public static int inteCevir(this string str)
        {
            // this string ifadesi, stringlerdeki instance'i ifade eder...
            return int.Parse(str);
        }
        public static string terscevir(this string str)
        {
           char[] chr= str.ToCharArray();
            Array.Reverse(chr);
            return new string(chr);
        }
        public static string stringedonustur(this int value)
        {
            return value.ToString();
        }
    }
}