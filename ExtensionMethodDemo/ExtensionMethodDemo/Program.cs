using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo {
    public static class StringHelper {
        public static string ChangeFirstLetterCase(this string inputString) {
            if (inputString.Length == 0) {
                return inputString;
            }
            char[] charArray = inputString.ToCharArray();
            charArray[0] = char.IsLower(charArray[0]) ? char.ToUpper(charArray[0]) : char.ToUpper(charArray[0]);
            //string s = new string(charArray);
            return new string(charArray);

        }

        public static string ChangeFirstLetterToSpecific(this string inputString, string s) {
            if(inputString.Length == 0) {
                return inputString;
            }
            return inputString.Replace(inputString[0].ToString(), s);
        }
    }

    class Program {
        static void Main(string[] args) {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
            IEnumerable<int> evenNums1 = nums.Where(x => x % 2 == 0);
            IEnumerable<int> evenNums2 = Enumerable.Where(nums, x => x % 2 == 0);
            foreach(var num in evenNums2) {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("\n");

            string str = "jeff";
            string res1 = StringHelper.ChangeFirstLetterCase(str);
            string res2 = str.ChangeFirstLetterCase();

            string s = "Good_";
            string res3 = StringHelper.ChangeFirstLetterToSpecific(str, s);
            string res4 = str.ChangeFirstLetterToSpecific(s);

            Console.WriteLine("{0} \n{1} \n\n{2} \n{3} \n", res1, res2, res3, res4);
        }
    }
}


