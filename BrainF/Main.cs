using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BrainF.Interpreter
{
	public class Interpreter
	{
		public delegate void Log(string message);

		int len;
		int xloc;
		int yloc;
		int loop = 0;
		IEnumerable<string> inputLines;

		public Stack<LoopStart> loops {
			get;
			set;
		}

		public BrainF.Execution.Hub hub {
			get;
			set;
		}

		public Log log {
			get;
			set;
		}

		/*
		public int ptr {
			get;
			set;
		}

		public int[] arr {
			get;
			set;
		}
		*/

		int[] arr;
		int ptr;

		public int GetPointer()
		{
			return ptr;
		}

		public Execution.Executer exe {
			get;
			set;
		}

		public int[] GetArray()
		{
			return arr;
		}

		public Interpreter(BrainF.Execution.Hub h)
		{
			this.hub = h;
			loops = new Stack<LoopStart> ();

			Setup ();
			xloc = 0;
			yloc = 0;
			log = new Log ((string msg) => {
				ConsoleColor col = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine (msg);
				Console.ForegroundColor = col;
			});

			//DEFINE ACTIONS FOR HUB

			hub.EXPAND_ARRAY = new Func<int[], int[]> ((int[] oldArray) => { //ADD AN EMPTY CELL TO THE ARRAY
				List<int> newArrayList = new List<int>();
				foreach (var cell in oldArray) {
					newArrayList.Add (cell);
				}
				newArrayList.Add ( 0 );
				len++;
				return newArrayList.ToArray ();
			});

			hub.LoopGetsDefined = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				loops.Push(new LoopStart(xloc, yloc));
				loop ++;
			});

			hub.LoopGetsClosed = new BrainF.Execution.Hub.CommandAction((ref int ptr, ref int[] arr) => {
                LoopStart exitingLoop = loops.Pop();
                if (arr[ptr] != 0) {
					xloc = exitingLoop.x - 1;
					yloc = exitingLoop.y;
				} loop --;
			});

			hub.PointerAddsValue = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				arr[ptr] ++;
			});

			hub.PointerGetsInput = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				arr[ptr] = (int)Console.ReadKey ().KeyChar;
			});

			hub.PointerMovesLeft = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				if (ptr > 0)
					ptr --;
			});

			hub.PointerMovesRight = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				if (ptr < arr.Length - 1)
					ptr ++;
			});

			hub.PointerPrintsValue = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				Console.Write(((char) arr[ptr]).ToString());
			});

			hub.PointerSubtractsValue = new BrainF.Execution.Hub.CommandAction ((ref int ptr, ref int[] arr) => {
				if (arr[ptr] > 0)
					arr[ptr] --;
			});

			// ASSIGN HUB TO EXECUTER

			exe = new BrainF.Execution.Executer (hub);
		}

		internal void Setup()
		{
			len = 0;
			ptr = 0;
			arr = null;
			arr = new int[len];
		}

        public void ExecuteNextCommand(CommandType ct)
        {
            exe.PerformCommand(ref ptr, ref arr, ct);
            xloc++;
        }

        public void ExecuteSet(CommandSet @set)
        {
            yloc = 0;
            xloc = 0;
            while (yloc <= set.Count - 1)
            {
                xloc = 0;
                while (xloc < set[yloc].Count)
                {
                    ExecuteNextCommand(set[yloc][xloc]);
                }
                yloc++;
            }
        }
	}

	public class LoopStart
	{
		public int x {
			get;
			set;
		}
		public int y {
			get;
			set;
		}

		public LoopStart(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}

