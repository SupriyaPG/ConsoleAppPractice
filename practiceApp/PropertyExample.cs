using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// It is use to provide getter setter method to read and write the data member value.
// It is basically use to provide data encapsulation to access data member indirectly.

namespace practiceApp
{
    internal class PropertyExample
    {
        private int width;

        public int _Width { get => width; set => width = value; }
    }
}
