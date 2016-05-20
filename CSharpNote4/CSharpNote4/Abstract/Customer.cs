using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote4.Abstract {
    /// <summary>
    /// opposite to sealed class, must inherit from this abstract class
    /// cannot instantiate an abstract class(cannot acall constructor of an abstract class outside a abstract class)
    /// but we could create a constructor inside a abstract class to use the functionality of the abstract 
    /// an abstract class is a class which can contain both abstrct and non-abstract methods
    /// you can create a constructor inside abstrct class
    /// if a method is marked as abstract, then it can only de declared without any definition(body)
    /// to solve multiple inheritance -- interface
    /// interface only abstract methods
    /// 
    /// </summary>
    abstract class BaseCustomer {
        public BaseCustomer() {
            Console.WriteLine("This is an abstract class");
        }
        public int CustomerNum { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }

        public string EmailId { get; set; }

        public decimal BillAmt { get; set; }

        //by fault virtual, cannot be declared as virtual
        public abstract void ValidateInput();

        public void WelcomeMsg() {
            Console.WriteLine("Welcome to Abstract class");
        }
    }

    class Customer : BaseCustomer {
        //constructor
        public Customer() : base() { }
        public override void ValidateInput() {
            Console.Write("Customer Number =>");
            CustomerNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name =>");
            Name = Console.ReadLine();

            Console.Write("Email Id =>");
            EmailId = Console.ReadLine();

            Console.Write("Mobile Id =>");
            Mobile = Console.ReadLine();

            Console.Write("Bill Amount => ");
            BillAmt = Convert.ToDecimal(Console.ReadLine());

            //c equal to currency, then a $ added
            Console.WriteLine("Name = {0}, Bill Amount = {1:c}", Name, BillAmt);

        }
    }

    //ctrl + . 
    //ask whether implement the abstract method
    class Lead : BaseCustomer {
        public Lead() : base() { }
        public override void ValidateInput() {
            Console.Write("Customer Number =>");
            CustomerNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name =>");
            Name = Console.ReadLine();

            Console.Write("Email Id =>");
            EmailId = Console.ReadLine();

            Console.Write("Mobile Id =>");
            Mobile = Console.ReadLine();

            //c equal to currency, then a $ added
            Console.WriteLine("Name = {0}, Mobile = {1}, Bill Amount = {2:c}", Name, Mobile, BillAmt);
        }
    }
}
