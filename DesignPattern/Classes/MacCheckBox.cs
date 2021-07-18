using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class MacCheckBox : CheckBox
    {
        public override void Description()
        {
            Console.WriteLine("I am Mac CheckBox");
        }
    }

}
