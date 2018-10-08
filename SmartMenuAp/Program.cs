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
            string language, errorPath;
            language = ChooseLanguage(out errorPath);
            menu.LoadMenu(language, errorPath);
            menu.Activate(bindings);
        }

        private string ChooseLanguage(out string errorFile)
        {
            int userInput = 0;
            string menuChoice;

            Console.WriteLine("Press 1 for English");
            Console.WriteLine("Tryk 2 for dansk");

            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput > 2 || userInput < 1)
            {
                Console.WriteLine("Please enter valid input.");
                Console.WriteLine("Indtast veligst en gyldig v�rdi.");
            }

            if (userInput == 1)
            {
                menuChoice = "MenuSpecEn.txt";
                errorFile = "ErrorlistEn.txt";
            }
            else
            {
                menuChoice = "MenuSpecDk.txt";
                errorFile = "ErrorlistDk.txt";
            }

            return menuChoice;

        }
    }
}
