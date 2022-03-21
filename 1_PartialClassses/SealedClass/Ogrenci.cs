using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ClassTypes.SealedClass
{
    // sealed => miras vermesini istemediğiniz sınıfları sealed ile engelleyebilirsiniz...
    public sealed class Ogrenci
    {
        public string Adi { get; set; }
    }

    // Ogrenci sınıfı Sealed olduğu için SubOgrenci, Ogrenci sınıfından türetilemez....
    //public class SubOgrenci : Ogrenci
    //{
    //}
}
