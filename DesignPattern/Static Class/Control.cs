using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    static class Control
    {
        public static void Run()
        {
            IGuiFactory gUIFactory;

            try
            {
                while (true)
                {
                    Console.WriteLine("1)Win Check Box and Button");
                    Console.WriteLine("2)Mac Check Box and Button");
                    Console.WriteLine("3)Linux Check Box and Button");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        gUIFactory = new WinFactory();

                    }
                    else if (a == 2)
                    {
                        gUIFactory = new MacFactory();

                    }
                    else if (a == 3)
                    {
                        gUIFactory = new LinuxFactory();

                    }
                    else
                    {
                        throw new WrongSelectionException("Wrong Selection Exception");
                    }
                    Application application = new Application(gUIFactory);
                    application.CreateUi();
                    application.Description();

                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Run();
            }

        }
    }
}
