# BrainF is a C# library for the BrainF--k
## Except that a special Command, the tilde, was added as a valid command.

| Command 	| What it does                                                                                                                	|
|---------	|-----------------------------------------------------------------------------------------------------------------------------	|
| ~ 	| Adds one empty cell to the memory array                                                                                     	|
|    >    	| Moves the memory array pointer one to the right                                                                             	|
|    <    	| Moves the memory array pointer one to the left                                                                              	|
|    +    	| Adds one to the cell at the memory pointer                                                                                  	|
|    -    	| Subtracts one from the cell at the memory pointer                                                                           	|
|    [    	| Opens a loop                                                                                                                	|
|    ]    	| If the cell's value at the memory pointer is 0, continue (break the loop). Otherwise, return to where the loop was declared 	|
|    .    	| Print a letter to the console where the ASCII value of the letter is the value at the cell at the memory pointer            	|
|    ,    	| Read one letter and save the ASCII value of that letter to the cell at the memory pointer                                   	|

Go [here](https://en.wikipedia.org/wiki/Brainfuck) to learn more.

Go [here](https://esolangs.org/wiki/Brainfuck) for examples and an in-depth understanding of how the language works.
