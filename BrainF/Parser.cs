using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrainF
{
	public class Parser
	{
		readonly Hashtable RuleSet;
		readonly char[] LEGAL_COMMANDS;
		
		public Parser ()
		{
			LEGAL_COMMANDS = new char[] { '>', '<', ',', '.', '[', ']', '+', '-', '~' };
			RuleSet = new Hashtable ();

			#region DEFINE_RULESET

			RuleSet.Add('<', CommandType.mvptsneg);
			RuleSet.Add('>', CommandType.mvptrpos);
			RuleSet.Add(' ', CommandType.whtespce);
			RuleSet.Add('[', CommandType.begloop);
			RuleSet.Add(']', CommandType.endloop);
			RuleSet.Add('~', CommandType.deflen);
			RuleSet.Add('+', CommandType.addptr);
			RuleSet.Add('-', CommandType.subptr);
			RuleSet.Add('.', CommandType.print);
			RuleSet.Add(',', CommandType.read);

			#endregion
		}

		public CommandSet Run(IEnumerable<string> data)
		{
			CommandSet toReturn = new CommandSet ();
			foreach (var line in data) {
				ParseLine (line, ref toReturn);
			}
			return toReturn;
		}

		public void ParseLine(string line, ref CommandSet cs) 
		{
			List<CommandType> toAdd = new List<CommandType> ();
			foreach (var thisChar in line) {
				toAdd.Add (GetCommandFrom (thisChar));
			}
			cs.add (toAdd);
		}

		internal CommandType GetCommandFrom(char key) 
		{
			char[] keys = new char[RuleSet.Count];
			CommandType[] cmds = new CommandType[RuleSet.Count];
			RuleSet.Keys.CopyTo (keys, 0);
			RuleSet.Values.CopyTo (cmds, 0);
			List<char> @ref = new List<char> (keys);
			return cmds [@ref.IndexOf (key)];
		}

		public IEnumerable<LineType> GetLineTypes(IEnumerable<string> lines) 
		{
			foreach (var line in lines) {
				yield return ValidateLine (line);
			} 
		}


		#region ERROR_PARSING

		internal LineType ValidateLine (string line)
		{
			bool isValid = true;

			foreach (var thisChar in line) {
				if (thisChar != ' ') {
					bool charValid = false;
					foreach (var validChar in LEGAL_COMMANDS) {
						if (validChar == thisChar)
							charValid = true;
						else if (validChar == ' ')
							charValid = true;
					}
					if (isValid == true)
						isValid = charValid;
				}
			}

			if (line.Length > 0) {
				if (isValid)
					return LineType.VALID;
				else
					return LineType.INVALID;
			} else
				return LineType.VALID; // Line is whitespace
		}

		#endregion
	}
}

