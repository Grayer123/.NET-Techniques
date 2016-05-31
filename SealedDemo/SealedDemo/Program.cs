using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo {
    /*
     * Sealed Class:
     * Sealed classes are the opposite of abstract class:
     * Abstract classes force to derive a subclass in order to use them
     * Sealed class prevent further subclasses from being derived
     * 
     * Individual methods could also be marked as sealed, which prevents them being overridden in subclasses
     * Usually override sealed: are used together (to prevent subclass again override this method)
     */
    class A {
        private int val1;
        private int val2;
        public virtual int getVal() {
            return val1;
        }

        public int getKey() {
            return val2;
        }

        //abstract method could not put into a non-abstract class
        //public abstract void show();  //error
    }


    class B : A {
        int val;

        //prevent this virtual function being override in the further subclass
        public override sealed int getVal() {
            return val;
        }

        //call base class's method in the derived class
        public int getSomeKey() {
            return base.getKey() * 2;
        }
    }

    class C : B {
        //cannot override inherited member: B.getVal() because it is sealed
        //public override int getVal() {}  //error
    }

    abstract class S {
        //could not declare a body if marked as abstract class
        //public abstract void show() { }  //error

        //abstract method can only put inside a abstract class
        public abstract void show();
    }
    class Program {
        static void Main(string[] args) {
        }
    }
}
