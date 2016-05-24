using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// Id should always be non-negative number
/// Name cannot be set to NULL
/// If student Name is missing, then "No Name" should be returned
/// PassMark should be read-only
/// </summary>
namespace PropertyDemo {
    /// <summary>
    /// Marking the class fields public and exposing to the external world is bad, 
    /// as we will not have control over what gets assigned and returned.
    /// </summary>
    //public class Student {
    //    public int Id;
    //    public string Name;
    //    public int passMark;
    //}

    /// <summary>
    /// Programming Languages that do not have properties use getter and setter methods
    /// to encapsulate and protect fields.
    /// </summary>
    public class Student1 {
        private int id;
        private string name;
        private int passMark = 100;

        //set and get method for field id
        public void SetId(int num) {
            if(num <= 0) {
                throw new Exception("Student Id cannot be negative");
            }
            this.id = num;
        }
        public int GetId() {
            return id;
        }

        //set and get method method for field name
        public void SetName(string s) {
            if (string.IsNullOrEmpty(s)) {
                throw new Exception("Student Name cannot be null or empty.");
            }
            this.name = s;
        }
        public string GetName() {
            //if (string.IsNullOrEmpty(this.name)) {
            //    return "No Name";
            //}
            //return this.name;
            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
        }

        //get method for field passMark, for read only, so no set method
        public int GetMark() {
            return this.passMark;
        }
    }

    /// <summary>
    /// Properties can also specify private set{}; private get{}
    /// </summary>
    public class Student2 {
        private int id;
        private string name;
        private int passMark = 100;

        //Read/Write Properties
        public int Id {
            get {
                return this.id;
            }
            set {
                if(value <= 0) {
                    throw new Exception("Student Id cannot be negative");
                }
                this.id = value;
            }
        }

        //Read/Write Properties
        public string Name {
            get {
                return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Student Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        //Read Only Properties
        public int PassMark {
            get {
                return this.passMark;
            }
        }

        //Auto Implemented Properties
        public string City { get; set; }

        //Auto Implemented Properties
        public string Email { get; set; }
    }

    class Program {
        static void Main(string[] args) {
            Student2 stu = new Student2 {
                Id = 100,
                City = "New Jersy",
                Email = "123@123.com"
            };
            Console.WriteLine("Id = {0}, Name = {1}, PassMark = {2}, City = {3}, Email = {4}", stu.Id, stu.Name, stu.PassMark, stu.City, stu.Email);
        }
    }
}
