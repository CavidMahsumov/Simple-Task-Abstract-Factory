using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class LinuxButton : Button
    {
        public override void Description()
        {
            Console.WriteLine("I am Linux Button");
        }
    }
}
