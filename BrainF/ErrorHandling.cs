using System;
using System.Collections.Generic;

namespace BrainF.ErrorHandling
{

	public class ErrorHandler
	{
		public bool ErrorsFound {
			get;
			set;
		}

		public delegate void ErrorDelegate (params int[] lineNumbers);

		public BrainF.Interpreter.Interpreter interpreter {
			get;
			set;
		}

		List<int> LinesWithErrors = new List<int>();

		public ErrorHandler(BrainF.Interpreter.Interpreter interpreter) {
			this.interpreter = interpreter;
			ErrorsCollected = (int[] error) => {
				foreach (var lineNumber in error) {
					this.interpreter.log("ERROR FOUND ON LINE: " + lineNumber.ToString ());
				}
			};
		}

		public ErrorDelegate ErrorsCollected {
			get;
			set;
		}

		public void CheckForErrors(Parser parser, IEnumerable<string> lines) {
			int index = 1;
			foreach (var type in parser.GetLineTypes (lines)) {
				if (type == LineType.INVALID)
					LinesWithErrors.Add (index);
				index ++;
			}
			ErrorsFound = (LinesWithErrors.Count != 0);
			ErrorsCollected (LinesWithErrors.ToArray ());
		}
	}
}