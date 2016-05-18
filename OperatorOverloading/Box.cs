using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    class Box {
        //fields
        private double length;
        private double breadth;
        private double height;

        //Properties
        public double Len {
            get {
                return length;
            }
            set {
                length = value;
            }
        }

        public double Bre {
            get {
                return breadth;
            }
            set {
                breadth = value;
            }
        }

        public double Hei {
            get {
                return height;
            }
            set {
                height = value;
            }
        }
   
        public double getVolume() {
            return length * breadth * height;
        }

        public static Box operator +(Box b1, Box b2) {
            Box box = new Box();
            box.Len = b1.Len + b2.Len;
            box.Bre = b1.Bre + b2.Bre;
            box.Hei = b1.Hei + b2.Hei;
            return box;
        }
        static void Main(string[] args) {
            Box box1 = new Box() {// Declare Box1 of type Box
                Len = 6.0,
                Bre = 7.0,
                Hei = 5.0
            };

            Box box2 = new Box() {// Declare Box2 of type Box
                Len = 12.0,
                Bre = 13.0,
                Hei = 10.0
            };

            Box box3 = new Box();

            double volume = 0.0;    // Store the volume of a box here

            // volume of box 1
            volume = box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            box3 = box1 + box2;

            // volume of box 3
            volume = box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
        }
    }
}
