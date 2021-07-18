using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface IGuiFactory
    {
        Button CreateButton();
        CheckBox CreateCheckBox();
    }
}
