using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo {
    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary  { get; set; }
    }
    /// <summary>
    /// a derived class from the base class Customer
    /// </summary>
    public class SavingCustomer : Customer {
        public int SavingId { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            Customer c1 = new Customer {
                Id = 100,
                Name = "Mary",
                Salary = 8000
            };
            Customer c2 = new Customer {
                Id = 101,
                Name = "Mike",
                Salary = 7000
            };
            Customer c3 = new Customer {
                Id = 102,
                Name = "Ran",
                Salary = 9000
            };

            SavingCustomer sc1 = new SavingCustomer {
                Id = 103,
                Name = "Sam",
                Salary = 6500,
                SavingId = 122
            };


            List<Customer> lst = new List<Customer>();
            lst.Add(c1);
            lst.Add(c2);
            lst.Add(c3);
            /*
             *list<T>.Insert(int index, T item);
            */
            lst.Insert(0, c3);

            //lst could also add derived class object
            lst.Add(sc1);

            foreach (var item in lst) {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Id, item.Name, item.Salary);
            }

            /*
             * int List<T>.IndexOf(T item);
             * int List<T>.IndexOf(T item, int index); //the starting index
             * int List<T>.IndexOf(T item, int index, int count); //starting index, and count for words last
             */
            int idx1 = lst.IndexOf(c3); //0
            int idx2 = lst.IndexOf(c3, 1); //3
            int idx3 = lst.IndexOf(c3, 1, 2); //-1; cannot find c3 in lst[1] && lst[2]
            //int idx4 = lst.IndexOf(c3, 1, 5); //throw an ArgumentOutOfRangeException
            Console.WriteLine("index1 = {0}", idx1);
            Console.WriteLine("index2 = {0}", idx2);
            Console.WriteLine("index3 = {0}", idx3);

            /*
             * bool List<T>.Contains()
             * checks if an item exists in the list.
             */
            bool flag1 = lst.Contains(c3); //true


            /*
             * bool List<T>.Exists(Predicate<T> match)
             * checks if an item exists in the list based on a condition
             * cannot pass the object itself
             */
            bool flag2 = lst.Exists(cst => cst.Salary > 8000); //true
            bool flag3 = lst.Exists(cst => cst.Name.StartsWith("P")); //false


            /*
             * T List<T>.Find(Predicate<T> match)
             * searches for an element that matches the conditions defined by the specified
             * lambda expression and returns the FIRST matching item frim the list
             */
            Customer tmp1 = lst.Find(cst => cst.Salary > 5000);
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", tmp1.Id, tmp1.Name, tmp1.Salary);
            Console.WriteLine("\n\n\n");

            /*
             * T List<T>.FindLast(Predicate<T> match)
             * searches for an element that matches the conditions defined by the specified
             * lambda expression and returns the LAST matching item frim the list
             */
            Customer tmp2 = lst.FindLast(cst => cst.Salary > 5000);
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", tmp2.Id, tmp2.Name, tmp2.Salary);
            Console.WriteLine("\n\n\n");

            /*
             * T List<T>.FindLast(Predicate<T> match)
             * searches for an element that matches the conditions defined by the specified
             * lambda expression and returns the LAST matching item frim the list
             */
            List<Customer> tmpList1 = lst.FindAll(cst => cst.Salary > 5000);
            foreach (var item in tmpList1) {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Id, item.Name, item.Salary);
            }
            Console.WriteLine("\n\n\n");

            /*
             *  int List<T>.FindIndex(Predicate<T> match);
             * int List<T>.FindIndex(int startIndex, Predicate<T> match);
             * int List<T>.FindIndex(int startIndex, int count, Predicate<T> match); //starting index, and count for words last(from front to the back)
             * --returns the index of the first item, that matches the conditions specified by the lambda expression.
             */
            int idx4 = lst.FindIndex(1, 3, x => x.Salary < 7699);
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", lst[idx4].Id, lst[idx4].Name, lst[idx4].Salary);
            Console.WriteLine("\n\n\n");

            /*
             * int List<T>.FindLastIndex(Predicate<T> match);
             * int List<T>.FindLastIndex(int startIndex, Predicate<T> match);
             * int List<T>.FindLastIndex(int startIndex, int count, Predicate<T> match); //starting index, and count for words last(from back to the front)
             * --returns the index of the last item, that matches the conditions specified by the lambda expression.
             */
            int idx5 = lst.FindLastIndex(4, 3, x => x.Salary < 0);
            if (idx5 != -1) {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", lst[idx5].Id, lst[idx5].Name, lst[idx5].Salary);
            }
            else {
                Console.WriteLine("Cannot find this object!");
            }
            Console.WriteLine("\n\n\n");



            //Convert an Array to a List: ToList() method
            Customer[] arr1 = new Customer[3];
            arr1[0] = c1; arr1[1] = c2; arr1[2] = c3;
            List<Customer> listArr = arr1.ToList();

            //Convert an List to a Array: ToArray() method
            Customer[] arr2 = lst.ToArray();

            //Convert an List to a Dictionary: ToDictionary() method
            lst.RemoveAt(0); //remove duplicate, otherwise thorw a runtime exception 
            Dictionary<int, Customer> dict = lst.ToDictionary(x => x.Id);
            foreach (var item in dict) {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Value.Id, item.Value.Name, item.Value.Salary);
            }

            Console.WriteLine("\n\n\n");

            /*
             * void List<T>.AddRange(List<T> lst)
             * Allows adding another list of items, to the end of the list           
             */
            lst.AddRange(lst);

            /*
             * List<T> List<T>.GetRange(int index, int count)
             * index is the starting index, and count is the number of elements to return          
             */
            List<Customer> newList1 = lst.GetRange(1, 2);

            /*
             * void List<T>.InsertRange(int index, List<T> lst)
             * allows to insert another list of items to the list at the specified index          
             */
            lst.InsertRange(1, lst);

            /*
             * bool List<T>.Remove(T);
             * void List<T>.Remove(int index);  
             * int List<T>.RemoveAll(Predicate<T> match); //return the number of elements removed from the List
             * void List<T>.RemoveRange(int index, int count); 
             * void List<T>.Clear(); //remove all the elements without any specification
             */
            bool flag4 = lst.Remove(c2);
            lst.RemoveAt(0);
            int tmpRes = lst.RemoveAll(x => x.Salary < 5000);
            lst.RemoveRange(1, 2);
            lst.Clear()
        }
    }
}
