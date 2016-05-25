using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo1 {
    /// <summary>
    /// similar with absract class
    /// must have the exact syntax with the function
    /// what happens when the function has optional parameters or has param
    /// can we skip the optional parameters in the delegate? or we must also mention the optional parameter
    /// no
    /// must have the exact syntax with the function
    /// communicate with the two parties, cannot talk
    /// 
    /// </summary>
    /// <returns></returns>
    public delegate void MathDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, (a + b));
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", a, b, (a - b));
        }
    }
}
