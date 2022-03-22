using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ClassTypes.GenericClass
{
    // Generic sınıf...
    public class Demo<T>
    {
        public T MyProperty { get; set; }
    }

    public class A : IGeneric<B>
    {
        public void Ekle(B parametre)
        {
            throw new NotImplementedException();
        }
    }
    public class B : IGeneric<A>
    {
        public void Ekle(A parametre)
        {
            throw new NotImplementedException();
        }
    }

    // generic interface
    public interface IGeneric<T>
    {
        void Ekle(T parametre);
    }
}
