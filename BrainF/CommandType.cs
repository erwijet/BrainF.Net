using System;

namespace BrainF
{
	[Serializable]
	public enum CommandType
	{
		//PRIMARY
		deflen,   // ~ // Expand array by one.
		mvptrpos, // > // Move the pointer right.
		mvptsneg, // < // Move the pointer left.
		addptr,   // + // Add one to the cell at the pointer.
		subptr,   // - // Subtract one to cell at the ponter.
		begloop,  // [ // Define a loop.
		endloop,  // ] // If the value of the cell at the pointer is 0, exit loop, otherwise go to the matching loop definition.

		// I/O
		print,    // . // Print the value of cell at the pointer basied on said cell's ASCII value.
		read,	  // , // Read one value and save the input's ASCII value to the cell at the pointer

		// MISC.
		err,	  //---// Throw error.
		whtespce  //---// Whitespace.
	}

	public enum LineType
	{
		VALID,
		INVALID
	}
}