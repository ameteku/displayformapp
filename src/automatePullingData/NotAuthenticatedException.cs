using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFormApp.src.automatePullingData
{
    public class NotAuthenticatedException : Exception
    {
        public  NotAuthenticatedException(): base() { }
        public NotAuthenticatedException(String message): base(message) { }
    }
}
