# BrainF is a C# library for the BrainF--k language.
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

To download this magical library, you could clone this repo and include *BrainF.csproj* in your project, then add a project refrence. 
Or, you could just download the .dll file from the binaries folder of this repo. To download that file, you can just click [here](https://github.com/erwijet/BrainF/raw/master/BrainF/bin/Debug/BrainF.dll) and save yourself a couple seconds of file hunting, or you *could* go file hunting, if youre into that I guess.

Oh, and also if you want some MD5 checksum hashes or whatever, here they are:

| File | Hash                                      |
| ---- | ----------------------------------------- |
| BrainF.csproj | 3E5F2DC53FEB21C0BB2CF3BDF1EAFCC0 |
| BrainF.dll    | 2228CC2DE5A32DEA181A1D4FF3ACC3C1 |
