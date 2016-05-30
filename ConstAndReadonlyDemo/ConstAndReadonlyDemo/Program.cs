using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndReadonlyDemo {
    class Program {
        /* compile time constant(absolutely constant)
         * consts are implicitly static; could use a ClassName.ConstantName to access;
         * have to give a value to const when declare it
         * cannot be changed later
         * are copied into every assembly that uses them (every assembly gets a local copy of values)
         */
        public const int cmToMeters = 100;

        /* runtime constant(semi-constant)
         * must have set value, by the time constructor exits
         * are evaluated when instance is created
         * once its constructor is done, then it cannot be changed
         */
        public readonly double PI;
        public readonly double tmp1 = 3.0;
        public readonly double tmp2 = 3.0;

        /* Are evaluated when code execution hits class reference 
         * (when new instance is created or a static method is executed)
         * Must have an evaluated value by the time the static constructor is done
         * It's not recommended to put ThreadStaticAttribute on these 
         * (static constructors will be executed in one thread only and will set the value for its thread; 
         * all other threads will have this value uninitialized)
         */
        public static readonly double tmp3;

        public Program() {
            //cmToMeters = 101; //error: cannot be changed
            PI = 3.14;
            tmp2 = 3.1;
        }

        //static constructor
        static Program() {
            tmp3 = 3.999;
        }
        static void Main(string[] args) {
            //cmToMeters = 101; //error: cannot be changed
            //tmp3 = 5.14; //error: cannot be changed
        }
    }
}
