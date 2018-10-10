using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;
using SmartMenuLibrary;

namespace SmartMenuAp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            Bindings bindings = new Bindings();

            //TODO: Be able to choose language.
            string language = menu.ChooseLanguage(out string errorPath,out string bindingsPath);
            menu.LoadMenu(language, errorPath);
            menu.Activate(bindings);
        }
    }
}
