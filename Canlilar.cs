using System;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Calılar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Calılar solunum yapar.");
        }

        protected void Bosaltım()
        {
            Console.WriteLine("Calılar boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canılar uyaranlara tepki verir.");
        }
    }
}