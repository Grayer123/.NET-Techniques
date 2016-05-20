using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpNote4.Abstract;
using CSharpNote4.ListCollection;
using CSharpNote4.CollectionExamples;
using BusinessLogic;
using ExceptionHandling;

namespace CSharpNote4 {
    class Program {
        //abstract class
        //can contain abstract method and not abstract class
        static void Main(string[] args) {
            #region Abstract
            //BaseCustomer bc = new Customer();
            //BaseCustomer ld = new Lead();
            //bc.ValidateInput();
            //ld.ValidateInput();
            ////Factory pattern
            #endregion

            #region ListDemo
            ListDemo lst = new ListDemo();
            lst.ListExample();
            #endregion

            #region BusinessLogic
            DashBoard db = new DashBoard();
            db.Task();
            #endregion

            #region ExceptionHandling
            //Class1 c = new Class1();
            //c.ExceptionHandlingDemo();
            #endregion

            #region ArrayList
            //ArrayListExample ale = new ArrayListExample();
            //ale.ArrayListDemo();
            #endregion

            #region QueueExample
            //QueueExample qe = new QueueExample();
            //qe.QueueDemo();
            #endregion

            #region StackExample
            //StackExample st = new StackExample();
            //st.StackDemo();
            #endregion


            Console.ReadLine();
        }
    }
}
