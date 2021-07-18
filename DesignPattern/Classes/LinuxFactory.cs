using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class LinuxFactory : IGuiFactory
    {
        public Button CreateButton()
        {
            return new LinuxButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new LinuxCheckBox();
        }
    }
}
