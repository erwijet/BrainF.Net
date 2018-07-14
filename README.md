# BrainF.Net is a c# library in .NET 4.5 

>...[R]egardless of the programming language being used, the functionality, logic, and efficiency of the language are always paramount — unless, of course, you’re talking about Brainf*ck, an esoteric programming language that champions purposefully overcomplicated code

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

Go [here](https://en.wikipedia.org/wiki/Brainfuck) to learn more.\
Go [here](https://esolangs.org/wiki/Brainfuck) for examples and an in-depth understanding of how the language works.

To download this magical library, you could clone this repo and include *BrainF.csproj* in your project, then add a project refrence. Or, you could just download the .dll file from the binaries folder of this repo. To download that file, you can just click [here](https://github.com/erwijet/BrainF/raw/master/BrainF/bin/Debug/BrainF.dll) and save yourself a couple seconds of file hunting, or you *could* go file hunting, if youre into that I guess.


Oh, and also if you want some MD5 checksum hashes or whatever, here they are:

#### *BrainF.dll*

| Algorithm | Hash                                                             |
|:---------:| ---------------------------------------------------------------- |
|  SHA-256  | 38697BBB689DD19FAD0934688B66CB66423C6479A535BBBC031843BA8ABF4DDB |
|  SHA-1    | B3E825E13780EB43D140837E7D34B420BF8A6C9C                         |
|  MD5      | 2228CC2DE5A32DEA181A1D4FF3ACC3C1                                 |

#### *BrainF.csproj*

| Algorithm | Hash                                                             |
|:---------:| ---------------------------------------------------------------- |
|  SHA-256  | 9A58FAFADD46166F60B97113EE7B1E6EA005E5A082AD80C6CB26C7164B27BF4E |
|  SHA-1    | 6A9B0A00CBBDFBF25222AFB64CD2C16003B7493D                         |
|  MD5      | 3E5F2DC53FEB21C0BB2CF3BDF1EAFCC0                                 |
