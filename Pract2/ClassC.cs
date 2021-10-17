using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    public abstract class ClassC
    {
        public int a;
        public void XXX() { }

        abstract public void YYY();

    }

    /*public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }

    public abstract class ClassB : ClassA Пример наследования абстрактного класса от другого абстрактного класса
    {
        public new abstract void XXX();
    }

    public class ClassC : ClassB
    {
        public override void XXX()
        {
            System.Console.WriteLine("ClassC XXX");
        }
    }*/

}
