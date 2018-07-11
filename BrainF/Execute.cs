using System;
using System.Collections;
using System.Collections.Generic;

namespace BrainF.Execution
{
	public class Executer
	{
		Hub h;

		public Executer(Hub hub)
		{
			h = hub;
		}

		public void PerformCommand(ref int ptr, ref int[] arr, CommandType command)
		{
			switch (command) {
			case CommandType.addptr:
				h.PointerAddsValue (ref ptr, ref arr);
				break;
			case CommandType.begloop:
				h.LoopGetsDefined (ref ptr, ref arr);
				break;
			case CommandType.deflen:
				arr = h.EXPAND_ARRAY (arr);
				break;
			case CommandType.endloop:
				h.LoopGetsClosed (ref ptr, ref arr);
				break;
			case CommandType.mvptrpos:
				h.PointerMovesRight (ref ptr, ref arr);
				break;
			case CommandType.mvptsneg:
				h.PointerMovesLeft (ref ptr, ref arr);
				break;
			case CommandType.print:
				h.PointerPrintsValue (ref ptr, ref arr);
				break;
			case CommandType.read:
				h.PointerGetsInput (ref ptr, ref arr);
				break;
			case CommandType.subptr:
				h.PointerSubtractsValue (ref ptr, ref arr);
				break;
			}
		}
	}

	public class Hub
	{
		public delegate void CommandAction(ref int ptr, ref int[] arr);
		public Hub() { } 
		public CommandAction PointerMovesLeft;
		public CommandAction PointerMovesRight;
		public CommandAction PointerAddsValue;
		public CommandAction PointerSubtractsValue;
		public CommandAction PointerGetsInput;
		public CommandAction PointerPrintsValue;
		public CommandAction LoopGetsDefined;
		public CommandAction LoopGetsClosed;
		public Func<int[], int[]> EXPAND_ARRAY;
	}
}

