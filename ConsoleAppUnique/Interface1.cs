using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{

    public abstract class class1
    {
        public abstract void Mul();  // abs

    }
    public abstract class class2
    {
        public abstract void Div();  // abs

    }
    public interface Interface1
    {
        void add();  // abs

    }
    public interface Interface2
    {
        void sub();

    }

    public class Calci : class1, Interface1, Interface2
    {
        public override void Mul() { }
        public void add() { }
        public void sub() { }
    }
}
