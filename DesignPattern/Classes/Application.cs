using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Application
    {
        private IGuiFactory factory;
        private Button button;
        private CheckBox CheckBox;

        public Application(IGuiFactory f)
        {
            factory = f;
        }
        public void CreateUi()
        {
            button = factory.CreateButton();
            CheckBox = factory.CreateCheckBox();
        }
        public void Description()
        {
            button.Description();
            CheckBox.Description();
        }
    }
}
