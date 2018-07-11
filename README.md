BrainF is a c# interpreter library for the BrainF--k language, however it includes a command which is unsupported in standered BrainF--k.
This command is the tilde.
I would leave a link to the full documentation, but its so simple I will include it here.
| Command 	| What it does                                                                                                                	|
|---------	|-----------------------------------------------------------------------------------------------------------------------------	|
| <tilde> 	| Adds one empty cell to the memory array                                                                                     	|
|    >    	| Moves the memory array pointer one to the right                                                                             	|
|    <    	| Moves the memory array pointer one to the left                                                                              	|
|    +    	| Adds one to the cell at the memory pointer                                                                                  	|
|    -    	| Subtracts one from the cell at the memory pointer                                                                           	|
|    [    	| Opens a loop                                                                                                                	|
|    ]    	| If the cell's value at the memory pointer is 0, continue (break the loop). Otherwise, return to where the loop was declared 	|
|    .    	| Print a letter to the console where the ASCII value of the letter is the value at the cell at the memory pointer            	|
|    ,    	| Read one letter and save the ASCII value of that letter to the cell at the memory pointer                                   	|
