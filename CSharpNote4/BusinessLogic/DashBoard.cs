using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class DashBoard {
        private void Menu() {
            string[] menuOptions = Enum.GetNames(typeof(Operations));
            Console.WriteLine("Select an option below");
            foreach (var item in menuOptions) {
                Console.WriteLine(item);
            }
        }
        //only the dash board class to be public 
        //abstract 
        //capsulation
        //reference only the dll file
        //internal: it can be used in the same assembly(inside BussinessLogic)
        //in CSharpNote4: only the Dashboard works
        //unless declared as public
        //all other are internal
        //put all in the DLL file
        
        public void Task() {
            //better to assign to out variable first
            Operations op; //= Operations.Exit;
            IOperation od = new OperationDefinition(); //interface call the derived class
            do {
                Console.Clear(); //clear the buffer
                Menu();
                Console.WriteLine("Enter options");
                Enum.TryParse<Operations>(Console.ReadLine(), out op);
                switch (op) {
                    case Operations.Insert:
                        od.Insert();
                        break;
                    case Operations.PrintAll:
                        od.PrintAll();
                        break;
                    case Operations.Delete:
                        od.Delete();
                        break;
                    case Operations.Update:
                        od.Update();
                        break;
                    case Operations.Exit:
                        Console.WriteLine("Thanks of your Visit !!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (op != Operations.Exit);
        }
    }
}
