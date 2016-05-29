using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication2
{
    class StringFunctions
    {
        public static void Main()
        {
            string str = "Hello how are you?";
            int len = str.Length; //18
            string tmp;
            tmp = str.ToUpper(); //HELLO HOW ARE YOU?
            tmp = str.ToLower(); //hello how are you?
            tmp = str.Substring(0, 5); //(startIndex, Length): Hello
            bool flag = str.Contains("how"); //True; bool string.Contains(string value)
            flag = str.Contains('h'); //True; bool IEnumerable<char>.Contains<char>(char value)
            tmp = str.Replace(' ', '$'); //Hello$how$are$you?
            tmp = str.Replace("Hello", "OLA");
            char ch = str[3]; //l

            char[] arr = str.ToArray();
            foreach (char c in arr) {
                Console.Write(c);
            }

            Console.WriteLine();

            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Substring(0,5));

            Console.WriteLine(str.Contains("h"));

            Console.WriteLine(str.Replace(' ','$'));
            Console.WriteLine(str.Replace("Hello", "OLA"));

            Console.WriteLine(str[4]);

            
            Console.WriteLine();

            /*StringBuilder*/
            StringBuilder sb = new StringBuilder("Hello how are you?"); //StringBuilder is mutable
            sb.Append(" I am fine.");
            tmp = sb.ToString(); //Hello how are you? I am fine.
            Console.WriteLine(sb.ToString());


            string s1 = "123";
            string s2 = "456";
            s1 += s2; //since string C#:immutable; not operated on s1 directly, get copy of "123456", and s1 is reference this string
            Console.WriteLine(s1);
            //Console.WriteLine(sb.ToString());
        }
    }
}

    #region note1

//    /*
//    * string.Length
//    */
//string str = "Hello how are you?";
//    int len = str.Length; //18

//    string tmp;
//    /* 
//     * string.ToUpper(); string.ToLower() 
//     */
//    tmp = str.ToUpper(); //HELLO HOW ARE YOU?
//    tmp = str.ToLower(); //hello how are you?

//    /* 
//     * string string.Substring(startIndex, Length) 
//     */
//    tmp = str.Substring(0, 5); //Hello

//    /* 
//     * bool string.Contains() 
//     */
//    bool flag = str.Contains("how"); //True; bool string.Contains(string value)
//    flag = str.Contains('h'); //True; bool IEnumerable<char>.Contains<char>(char value)

//    /* 
//     * string string.Replace() 
//     */
//    tmp = str.Replace(' ', '$'); //Hello$how$are$you?
//    tmp = str.Replace("Hello", "OLA"); //OLA how are you?

//    char ch = str[3]; //l

//    /* 
//     * char array
//     */
//    char[] arr = str.ToArray();
//    foreach (char c in arr) {   
//        Console.Write(c);
//    }

//    /* 
//     * string is immutable in C#
//     */
//    string s1 = "123";
//    string s2 = "456";
//    s1 += s2; //immutable; not operated on s1 directly, get copy of "123456", and s1 is reference this string

//    /*
//     * StringBuilder is mutable
//     */
//    StringBuilder sb = new StringBuilder("Hello how are you?"); //StringBuilder is mutable
//    sb.Append(" I am fine.");
//    tmp = sb.ToString(); //Hello how are you? I am fine.
//    Console.WriteLine(sb.ToString());

    #endregion 



