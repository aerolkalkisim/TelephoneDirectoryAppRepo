using System;

namespace TelephoneDirectoryApp.Core.Exception.Base
{
    public abstract class BaseException : System.Exception
    {
        protected BaseException(string message) : base(message)
        {

        }
    }
}
