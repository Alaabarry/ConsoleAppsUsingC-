using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeeSimpleApp
{  

    //create inteface iQuiettable that class employee will inherite from...
     interface iQuiettable
    { 
        //create Quite method that like abstract method dosenot contain a body the call it later in employee class which it call polymorphism
        void Quiet();
    }
}
