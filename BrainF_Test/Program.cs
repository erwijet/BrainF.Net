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
            string[] input = System.IO.File.ReadAllLines("script.bf");          // Load Script.bf
                                               
            Interpreter i = new Interpreter(new Hub());                         // Declare Interpreter with a default Hub
            ErrorHandler eh = new ErrorHandler(i);                              // Declare an ErrorHanlder linked to the Interpreter                
            Parser p = new Parser();                                            // Declare a new Parser
            eh.CheckForErrors(p, input);                                        // Check for errors using the Parser to break the text code down into functions and pipe the output though Interpreter.Log
            if (!eh.ErrorsFound)                                                // If no errors were found, continue
            {                                  
                i.ExecuteSet(p.Run(input));                                     // Use the parser to convert the text into a Command Set Matrix, the use the Interpreter's Hub to execute a function for each command found
                i.log("\n[PROGRAM EXIT]");                                      // [PROGRAM EXIT]
            }
            Console.ReadLine();                                                 // Press <enter> to exit
		}
	}
}
