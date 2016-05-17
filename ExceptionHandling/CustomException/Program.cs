using System;
using System.IO;
using System.Runtime.Serialization;

namespace CustomException {
    [Serializable] //work across application domains
    public class UserAlreadyLoggedInException: Exception {
        public UserAlreadyLoggedInException() : base() {}
        public UserAlreadyLoggedInException(string msg) : base(msg){} //constructor overloading

        public UserAlreadyLoggedInException(string msg, Exception innerException) : base(msg, innerException) {}

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    class Program {
        static void Main(string[] args) {
            //throw new FileNotFoundException("File xyz not found"); //because constructor support passing a string
            try {
                throw new UserAlreadyLoggedInException("User logged in, no repeated session allowed");
            }
            catch(UserAlreadyLoggedInException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


