using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab4.PropertyDemo {
    //public class Point {
    //    private int x;
    //    private int y;

    //    public int X { get { return x; } set { x = value; } }
    //    public int Y { get { return y; } set { y = value; } }
    //}

    //to simplify: let the compiler generate the field
    public class Point {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
