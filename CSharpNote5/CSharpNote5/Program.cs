using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using CSharpNote5.GenericExample;

namespace CSharpNote5 {
    class Program {
        static void Main(string[] args) {
            #region SortedListDemo
            //ConsultantOperation co = new ConsultantOperation();
            //co.GetAllConsultants();
            //co.PrintConsultants();

            //Consultant c = (Consultant)co.GetConsultantValue("Hongmin");
            //Console.WriteLine("Name = {0}, Age = {1}", c.Name, c.Age);
            #endregion 

            #region HashtableDemo
            //HashExample hs = new HashExample();
            //hs.GetAllConsultants();
            //hs.PrintConsultants();

            //Consultant s = (Consultant)hs.GetConsultantValue("Hongmin");
            //Console.WriteLine("Name = {0}, Age = {1}", s.Name, s.Age);
            #endregion 

            #region GenericDemo
            //CompareValue cv1 = new CompareValue();
            //Console.WriteLine(cv1.CompareTwoValues(20, "20"));
            //Console.WriteLine(cv1.CompareTwoValues<int>(20, 20));

            //CompareValue2<float, int> cv2 = new CompareValue2<float, int>();
            //Console.WriteLine(cv2.IsEqual(30, 40));
            //Console.WriteLine(cv2.IsLarger(20.142f, 20.142f));
            #endregion 

            #region DictionaryDemo
            //DictionaryExample dc = new DictionaryExample();
            //dc.GetAllConsultants();
            //dc.PrintConsultants();
            #endregion 
        }

    }
}
