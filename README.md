BrainF is a c# interpreter library for the BrainF*ck language

In this example I will explain the diffrent namespaces and demo how an interpreter could be assembled from this library.

```csharp
using BrainF;
```
The BrainF namespace contains three key elements: The Parser, The CommandType enum and the LineType enum. This class can be thought of as the *primary* namespace in the sense that the Parser class pulles on the CommandType and LineType enum. The enum code is as follows: 
```csharp
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
```
The parser **does** have the code for error detection, however the ```BrainF.ErrorHandling``` namespace will call on the Parser class and will call internal methods. The parser contains the code is the Error Handler would like to be replaced with a custom version, however it is the default.

```csharp
using BrainF.ErrorHandling;
```

