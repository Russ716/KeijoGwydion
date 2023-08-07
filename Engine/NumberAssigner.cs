using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Another thing you can do with a static class (and a static variable) is to hold values such as a system-wide counter.

Let’s say you want a program to hand out unique, sequential numbers to the people who use it.

You could create a static NumberAssigner class, with a static GetNextNumber method, that keeps track of a static _nextNumber variable.*/

namespace Engine {
    public static class NumberAssigner {
        static int _nextNumber = 0;
        public static int GetNextNumber() {
            _nextNumber = (_nextNumber + 1);
            return _nextNumber;
        }
    }
}
/*When you start the program, _nextNumber has a value of 0.

When a user calls the GetNextNumber method, the code adds 1 to _nextNumber and returns the value (in this case, 1) to the program. The next time the GetNextNumber method is called, it adds 1 to _nextNumber (resulting in 2 this time) and returns 2 to the program.
When you use a static variable to hold a value, make sure it’s one that you really want to be shared for every user.

*/