using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using FunctionLibrary;

namespace SmartMenuAp
{
    class Bindings : IBindings
    {
 
        public void Call(string callId)
        {
            switch (callId)
            {
                case "1":
                    Console.WriteLine(Functions.DoThis());
                    break;
                case "2":
                    Console.WriteLine(Functions.DoThat());
                    break;
                case "3":
                    bool correctInput = false;
                    do
                    {
                        Console.WriteLine("Tell me what to do.");
                        string userInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(userInput))
                        {
                            Console.WriteLine(Functions.DoSomething(userInput));
                            correctInput = true;
                        }
                    } while (!correctInput);
                    break;
                case "4":
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    break;
                default:
                    Console.WriteLine("This should never happen.");
                    break;
            }
        }
    }
}
