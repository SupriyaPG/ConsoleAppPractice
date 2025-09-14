using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practiceApp
{
    internal class NegativeNumberException:Exception
    {
        private string _message="Enter only positive number.";

        public String Message
        {
            get { return _message; }
        }      
    }
}
