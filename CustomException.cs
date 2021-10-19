using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_UserRegistration_Exception
{
    
    public class MyException : Exception
    {
        public MyException(string Message) : base(Message)
        {

        }
        public MyException()
        {

        }

    }
}
