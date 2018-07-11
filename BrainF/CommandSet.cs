using System;
using System.Collections.Generic;

namespace BrainF
{
	[Serializable]
	public class CommandSet : IEnumerable<List<CommandType>>
	{
		List<List<CommandType>> commands;
		
		public CommandSet ()
		{
			commands = new List<List<CommandType>> ();
		}

		public void add (IEnumerable<CommandType> @set)
		{
			commands.Add (set as List<CommandType>);
		}

		public IEnumerator<List<CommandType>> GetEnumerator()
		{
			return commands.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

        public int Count { get => commands.Count; }

        public List<CommandType> this [int index] {
			get {
				return commands [index];
			}
			set {
				commands [index] = value;
			}
		}
	}
}

