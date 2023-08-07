using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine {
    public class Variables {
        // Class-level variables - used anywhere in this class. 
        public int classVariable1 = 3; // Visible to other classes
        private int classVariable2 = 7; // Only visible to this class
        private int classVariable3; // Declaring the variable, without setting a value - defauls to 0
        
        public void Function1() {
            int functionVariable1; //visible in Fuction1()
            if (classVariable1 < 5) {
                functionVariable1 = 1;
                int innerVariable1; //only visible in THIS if statement. 
            }
            if (classVariable1 >= 5) {
                functionVariable1 = 2;
                int innerVariable1; // can be reused in different statement. 
            }
        }
        public void Function2() {
            int functionVariable1; // only visible in Function2(), now. 
            if (classVariable2 < 5) {
                functionVariable1 = 3;
                int innerVariable1;
            }
            if (classVariable2 >= 5) {
                functionVariable1 = 4;
                int innerVariable1;
            }
        }
    }

}
