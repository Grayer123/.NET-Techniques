using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    /// <summary>
    /// all the interface starts with letter I
    /// interface is a collection of public abstract methods.
    /// By default all methods in the interface are public and abstract 
    /// cannot mark it public or abstract (again)
    /// interface cannot have fields
    /// cannot have const
    /// interface supports multiple inheritance
    /// interface can have properties and indexers
    /// </summary>
    interface IOperation {
        //string str; //wrong
        //const string str;
        //string OpeationName { get; set; } //properties
        void Insert();
        void Delete();
        void Update();
        void PrintAll();

        Dept FindById(int id);

    }
}
