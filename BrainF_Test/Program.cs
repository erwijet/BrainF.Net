using System;
using BrainF;
using BrainF.ErrorHandling;
using BrainF.Execution;
using BrainF.Interpreter;

namespace BrainF_Test
{
	class MainClass
	{
		public static void Main (string[] args) {
            string[] input = new string[] {
                "~ ~~~~~~~~~~",
                ">++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++.",
                ">,5"
            };

            Interpreter i = new Interpreter(new Hub());
            ErrorHandler eh = new ErrorHandler(i); ;
            Parser p = new Parser();
            eh.CheckForErrors(p, input);
            if (!eh.ErrorsFound)
            {
                i.ExecuteSet(p.Run(input));
                i.log("\n[PROGRAM EXIT]");
            }
            Console.ReadLine();
		}
	}
}
