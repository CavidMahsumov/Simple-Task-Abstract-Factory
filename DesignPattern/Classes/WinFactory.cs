using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class WinFactory : IGuiFactory
    {
        public Button CreateButton()
        {
            return new WinButton();

        }

        public CheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }
}
