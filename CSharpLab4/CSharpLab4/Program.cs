using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLab4.PropertyDemo;
using CSharpLab4.ExtensionMethodsDemo;
using System.Linq.Expressions;


namespace CSharpLab4 {
    class Program {
        static List<Customer> CreateCustomers() {
            return new List<Customer> {
                new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
                new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
                new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
                new Customer(4) { Name = "Ann Devon",        City = "London"    },
                new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
                new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
                new Customer(7) { Name = "Simon Crowther",   City = "London"    },
                new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
            };
        }

        //example of lambda expression
        public static List<Customer> FindCustomerByCity(List<Customer> customers, string city) {
            //anonymous method
            //return customers.FindAll(
            //    delegate (Customer c) {
            //        return c.City == city;
            //    });

            //corresponding lambda expression
            //implicitly typed
            return customers.FindAll(x => x.City == city);

            //explicitly typed
           // return customers.FindAll((Customer x) => x.City == city);
        }

        
        static void Main(string[] args) {
            #region propertyDemo
            //Customer c = new Customer(1);
            //c.Name = "Maria Anders";
            //c.City = "Berlin";
            //in this context, the set accessor is inaccessible
            //c.CustomerID = 1;
            //Not all fields of the object need to be specified in the list. 
            //If not specified, the fields will have their default value.
            Customer c = new Customer(1) {
                Name = "Maria Anders",
                City = "Berlin"
            };
            Console.WriteLine(c);

            List<Point> Square = new List<Point>{
                new Point { X=0, Y=5 },
                new Point { X=5, Y=5 },
                new Point { X=5, Y=0 },
                new Point { X=0, Y=0 }
            };

            List<Customer> customers = CreateCustomers();
            Console.WriteLine("Customers:\n");
            foreach (Customer cu in customers) {
                Console.WriteLine(cu);
            }
            #endregion

            DateTime t = DateTime.Now;

            Console.WriteLine(t.ToShortDateString());

            #region extensionMethodsDemo
            var newCustomer = new Customer(10) {
                Name = "Diego Roel",
                City = "Madrid"
            };

            foreach (var cus in customers) {
                //C# 2.0 feature
                //if (Extensions.Compare(newCustomer, cus)) {
                //    Console.WriteLine("The new customer was already in the list");
                //    return;
                //}

                //C# 3.0 feature
                if (newCustomer.Compare(cus)) {
                    Console.WriteLine("The new customer was already in the list");
                    return;
                }
            }
            Console.WriteLine("The new customer was not in the list");

            var addedCustomers = new List<Customer> {
                new Customer(9)  { Name = "Paolo Accorti", City = "Torino" },
                new Customer(10) { Name = "Diego Roel", City = "Madrid" }
            };

            //C# 3.0 feature
            var updatedCustomers = customers.Append(addedCustomers);
            Console.WriteLine("\n\n\n");
            foreach (var cust in updatedCustomers) {
                Console.WriteLine(cust);
            }

            #endregion

            #region lambdaExpressionDemo
            var customerDictionary = new Dictionary<Customer, string>();
            foreach (var custu in updatedCustomers) {
                customerDictionary.Add(custu, custu.Name.Split(' ')[1]);
            }
            var matches = customerDictionary.FilterBy(
                                                        (customer, lastName) => lastName.StartsWith("A"));
            Console.WriteLine("Number of Matches: {0}", matches.Count);
            #endregion

            #region expressionTreeDemo
            Expression<Func<int, bool>> filter = n => (n * 3) < 5;
            BinaryExpression lt = (BinaryExpression)filter.Body;
            BinaryExpression mult = (BinaryExpression)lt.Left;
            ParameterExpression en = (ParameterExpression)mult.Left;
            ConstantExpression three = (ConstantExpression)mult.Right;
            ConstantExpression five = (ConstantExpression)lt.Right;

            Console.WriteLine("({0} ({1} {2} {3}) {4})", lt.NodeType,
              mult.NodeType, en.Name, three.Value, five.Value);
            #endregion

            #region Relation_FunctionAndExpression
            Func<int, int> addOne = n => n + 1;
            Console.WriteLine("Result: {0}", addOne(5));

            //easy to create and build expressions that can be compiled dynamically 
            //and create new Func objects that pass around code as objects
            Expression<Func<int, int>> addOneExpression = n => n + 1;

            var addOneFunc = addOneExpression.Compile();
            Console.WriteLine("Result: {0}", addOneFunc(5));
            #endregion


        }
    }
}
