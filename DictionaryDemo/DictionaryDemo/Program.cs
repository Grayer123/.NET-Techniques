using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo {
    /// <summary>
    ///A dictionary is a collection of (key, value) pairs.
	///Dictionary class is present in the namespace of System.Collections.Generic; 
	///when creating a dictionary, need to specify the type for key and value;
	///Dictionary provides fast lookups for values using keys;
    ///Keys in the dictionary must be unique;
    /// </summary>
    class Program {
        static void Main(string[] args) {
            //Hashtable
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < 10; i = i + 2) {
                if (dict.ContainsKey(i)) {
                    dict[i].Add(i);
                }
                else {
                    List<int> tmp1 = new List<int>();
                    tmp1.Add(i);
                    dict.Add(i, tmp1);
                }
                //dict[i].Add(i);
            }

            for (int i = 20; i >= 0; i = i - 2) {
                if (dict.ContainsKey(i)) {
                    dict[i].Add(i);
                }
                else {
                    List<int> tmp1 = new List<int>();
                    tmp1.Add(i);
                    dict.Add(i, tmp1);
                }
            }
            //the KeyValuePair could be replaced by var
            foreach(KeyValuePair<int, List<int>> p in dict) {
                Console.WriteLine(p.Key + ": This key has appeared: " + p.Value.Count);
            }

            //dict.Keys
            Console.WriteLine("All the keys in the dict are:");
            foreach (var k in dict.Keys) {
                Console.WriteLine(k);
            }

            //dict.Values
            Console.WriteLine("All the values in the dict are:");
            foreach (var k in dict.Values) {
                foreach(var l in k) {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }


            //dict.TryGetValue()
            //if the given key is out of scope, don't get an exception
            List<int> tmp;
            if(dict.TryGetValue(200, out tmp)) {
                Console.WriteLine("dict[200] 's length is: {0}", tmp.Count);
            }
            else {
                Console.WriteLine("The key is not found!");
            }


            //Count() function
            //define some logic in the Count() function: using lambda expression
            Console.WriteLine("Num of Lists with which size > 1: {0}", dict.Count(kvp => kvp.Value.Count > 1));

            //Remove(key) function
            //if the key does not exist, then nothing happens, no exception threw
            dict.Remove(999);

            //Clear() function
            //remove all the content from the dictionary
            //dict.Clear();

            //Convert Array or List to Dictionary
            List<float> lst1 = new List<float>();
            lst1.Add(2.1f);
            lst1.Add(3.87f);
            lst1.Add(6.98f);
            Dictionary<int, List<float>> newDict = lst1.ToDictionary(lstx => lstx.GetHashCode(), lsty => lst1);
            foreach(var item in newDict.Keys) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }        
    }
}
#region DictionaryNote
//Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
//for (int i = 0; i< 10; i = i + 2) {
//    if (dict.ContainsKey(i)) {
//        dict[i].Add(i);
//    }
//    else {
//        List<int> tmp1 = new List<int>();
//        tmp1.Add(i);
//        dict.Add(i, tmp1);
//    }
//    //dict[i].Add(i);
//}

//for (int i = 20; i >= 0; i = i - 2) {
//    if (dict.ContainsKey(i)) {
//        dict[i].Add(i);
//    }
//    else {
//        List<int> tmp1 = new List<int>();
//        tmp1.Add(i);
//        dict.Add(i, tmp1);
//    }
//}
////the KeyValuePair could be replaced by var
//foreach(KeyValuePair<int, List<int>> p in dict) {
//    Console.WriteLine(p.Key + ": This key has appeared: " + p.Value.Count);
//}

////dict.Keys
//Console.WriteLine("All the keys in the dict are:");
//foreach (var k in dict.Keys) {
//    Console.WriteLine(k);
//}

////dict.Values
//Console.WriteLine("All the values in the dict are:");
//foreach (var k in dict.Values) {
//    foreach(var l in k) {
//        Console.Write(l + " ");
//    }
//    Console.WriteLine();
//}


////dict.TryGetValue()
////if the given key is out of scope, don't get an exception
//List<int> tmp;
//if(dict.TryGetValue(200, out tmp)) {
//    Console.WriteLine("dict[200] 's length is: {0}", tmp.Count);
//}
//else {
//    Console.WriteLine("The key is not found!");
//}


////Count() function
////define some logic in the Count() function: using lambda expression
//Console.WriteLine("Num of Lists with which size > 1: {0}", dict.Count(kvp => kvp.Value.Count > 1));

////Remove(key) function
////if the key does not exist, then nothing happens, no exception threw
//dict.Remove(999);

////Clear() function
////remove all the content from the dictionary
//dict.Clear();

////Convert Array or List to Dictionary
//List<float> lst1 = new List<float>();
//lst1.Add(2.1f);
//lst1.Add(3.87f);
//lst1.Add(6.98f);
//Dictionary<int, List<float>> newDict = lst1.ToDictionary(lstx => lstx.GetHashCode(), lsty => lst1);
//foreach(var item in newDict.Keys) {
//    Console.Write(item + " ");
//}
//Console.WriteLine();
#endregion
