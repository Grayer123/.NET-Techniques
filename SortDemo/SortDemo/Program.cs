using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDemo {
    public class Customer : IComparable<Customer> {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        //if we want to sort by the salary
        public int CompareTo(Customer other) {
            if(this.Salary > other.Salary) {
                return 1;
            }
            else if(this.Salary < other.Salary) {
                return -1;
            }
            else {
                return 0;
            }
            //an alternative way to implement
           // return this.Salary.CompareTo(other.Salary);
        }
    }

    //step 1: implement IComparer interface
    public class SortByName : IComparer<Customer> {
        public int Compare(Customer x, Customer y) {
            return x.Name.CompareTo(y.Name);
        }
    }
    //step 2: Pass an instance of the class that implements IComparer interface,
    // as an argument to the Sort() method.
    class Program {
        //static method service for the delegate
        static int ComparisonCustomer(Customer c1, Customer c2) {
            return c1.Id.CompareTo(c2.Id);
        }

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

            List<Customer> lst = new List<Customer>();
            lst.Add(c2);
            lst.Add(c3);
            lst.Add(c1);
            //lst.Sort();

            /*
             * public void Sort();
             * public void Sort(Comparison<T> comparison); //Comparison<T> is a delegate
             * public void Sort(IComparer<T> comparer);
             * public void Sort(int index, int count, IComparer<T> comparer);
             */

            //Comparison<Customer>

            SortByName sn = new SortByName();
            //public void Sort(IComparer<T> comparer)
            //lst.Sort(sn);
            foreach (var item in lst) {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Id, item.Name, item.Salary);
            }
            Console.WriteLine();

            /*
             * public void Sort(Comparison<T> comparison);
             * namespace System {
             *      public delegate int Comparison<in T>(T x, T y);
             * }
             */

            //method 1: use delegate
            Comparison<Customer> delegateComparison = new Comparison<Customer>(ComparisonCustomer);
            //lst.Sort(delegateComparison);
            //foreach (var item in lst) {
            //    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Id, item.Name, item.Salary);
            //}

            //method 2: use anonymous delegate
            //lst.Sort(delegate (Customer x, Customer y) {return x.Id.CompareTo(y.Id);});
            //foreach (var item in lst) {
            //    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Id, item.Name, item.Salary);
            //}

            //method 3: use lambda function
            lst.Sort((x, y) => x.Id.CompareTo(y.Id));
            foreach (var item in lst) {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", item.Id, item.Name, item.Salary);
                
            }
        }
    }
}






