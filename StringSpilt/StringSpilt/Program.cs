using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSpilt {
    class Program {
        static void Main(string[] args) {
            //public String[] Split(params char[] separator);
            //public String[] Split(char[] separator, StringSplitOptions options);
            //public String[] Split(String[] separator, StringSplitOptions options);
            //public String[] Split(char[] separator, int count);
            //public String[] Split(char[] separator, int count, StringSplitOptions options);
            //public String[] Split(String[] separator, int count, StringSplitOptions options);
            {
                string s = "try harder while we still can";
                //public String[] Split(params char[] separator);
                string[] str = s.Split(' ');  //{[try], [harder], [while], [we], [still], [can]}

            }
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                string text = "one\ttwo three:four,five six seven";
                //public String[] Split(params char[] separator);
                string[] words = text.Split(delimiterChars); //{[one], [two], [three], [four], [five], [six], [seven]}
            }

            {//By default, String.Split returns empty strings when two separating characters appear contiguously in the target string.
                string[] delimiterStrings = { "one", " " };
                string str = "This one is that one";
                string[] words1 = str.Split(delimiterStrings, StringSplitOptions.None); //{[this], [""], [""], [is], [that], [""], [""]}
                string[] word2 = str.Split(delimiterStrings, StringSplitOptions.RemoveEmptyEntries); //{[this], [is], [that]}
            }

            {
                string[] separatingChars = { "<<", "..." };
                string text = "one<<two<<...three<four";
                string[] words1 = text.Split(separatingChars, System.StringSplitOptions.None); //{[one], [two], [""], [three<four]}
                string[] word2 = text.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries); //{[one], [two], [three<four]}
            }

            {
                string[] str = { "one", "two", "three" };
                //public static String Join(String separator, params String[] value);
                string s = String.Join(",", str); //one,two,three
            }
        }
    }
}



