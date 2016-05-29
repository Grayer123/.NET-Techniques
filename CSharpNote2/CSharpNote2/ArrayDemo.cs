using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ArrayDemo
    {
        public static void Main()
        {
            //enum System.ConsoleColor
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            int tmp = (int)ConsoleColor.Gray;

            //Console.Clear();

            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ConsoleColor.DarkRed);
            Console.WriteLine((int)ConsoleColor.Gray);

            string[] student = { "John", "Gary", "Mike", "Michael" };

            //public static void Sort(Array array);
            //public static void Sort<T>(T[] array, Comparison<T> comparison);
            //Array.Sort(student); //{"Gary", "John", "Michael", "Mike"}
            Console.WriteLine("\n\n\n");
            //sort in descending
            //{"Mike", "Michael", "John", "Gary"}
            Array.Sort<string>(student, new Comparison<string>((s1, s2) => s2.CompareTo(s1)));
            for (int i = 0; i < student.Length; i++) {
                Console.WriteLine(student[i]);
            }

            Console.WriteLine("\n\n\n");

            Array.Reverse(student);
            for (int i = 0; i < student.Length; i++) {
                Console.WriteLine(student[i]);
            }

            Console.WriteLine(student.Length);
            for (int i = 0; i < student.Length; i++) {
                Console.WriteLine(student[i]);
            }


            int[] ssn = new int[5];
            Console.WriteLine(ssn.GetLength(0));
            for (int i = 0; i < ssn.GetLength(0); i++)
            {
                ssn[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(ssn);
            Console.WriteLine("Sorted ssn numbers ");
            foreach (int item in ssn)
            {
                Console.WriteLine(item);
            }

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int row = matrix.GetLength(0); //row
            int col = matrix.GetLength(1); //column

            Console.ReadKey();
        }
    }
}


    #region ArrayDemo
    ///*
    //* enum System.ConsoleColor
    //*/
    //Console.BackgroundColor = ConsoleColor.Gray;
    //Console.ForegroundColor = ConsoleColor.Red;
    //int tmp = (int)ConsoleColor.Gray;

    ///*
    //* Array.Sort()
    //* public static void Sort(Array array);  --ascending 
    //* public static void Sort<T>(T[] array, Comparison<T> comparison);  --descending
    //*/
    //string[] student = { "John", "Gary", "Mike", "Michael" };

    //Array.Sort(student); //{"Gary", "John", "Michael", "Mike"}
    
    ////sort in descending: {"Mike", "Michael", "John", "Gary"}
    //Array.Sort<string>(student, new Comparison<string>((s1, s2) => s2.CompareTo(s1)));


    ///*
    //* Array.Reverse()
    //*/
    //Array.Reverse(student);
    //for (int i = 0; i<student.Length; i++) {
    //    Console.WriteLine(student[i]);
    //}

    ///*
    //* foreach
    //*/
    //foreach (string s in student) {
    //    Console.WriteLine(s);
    //}

    ///*
    //* two dimensional array 
    //*/
    //int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
    //int row = matrix.GetLength(0); //row
    //int col = matrix.GetLength(1); //column

    #endregion
