using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string message) : base(message) { }
        public ApplicationException(string message, Exception innerException) : base(message, innerException) { }
    }
    public class DALException : ApplicationException
    {
        public DALException(string message) : base(message) { }
        public DALException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class BLLException : ApplicationException
    {
        public BLLException(string message) : base(message) { }
        public BLLException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class UIException : ApplicationException
    {
        public UIException(string message) : base(message) { }
        public UIException(string message, Exception innerException) : base(message, innerException) { }
    }
}

