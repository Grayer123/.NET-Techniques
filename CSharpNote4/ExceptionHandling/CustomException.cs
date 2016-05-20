using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling {
    class CustomException : ApplicationException{
        public override string Message {
            get {
                return "Age Must be greater than 30";
            }
        }
    }
}
