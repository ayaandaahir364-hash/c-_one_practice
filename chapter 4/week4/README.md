##  while loop:

Repeats a block of code as long as a Boolean expression is true. It is a pretest loop: the condition is tested before each iteration. If the condition is false at the start, the loop never runs.


 ## for loop:

Used when a counter variable controls how many times the loop runs. It has three parts: Initialization (once), Test (if true, iterate), Update (change the counter). It is a pretest loop.

 ## do-while loop:

A posttest loop: it runs the body first, then tests the condition. So it always runs at least once.

Example: do { MessageBox.Show(number.ToString()); } while (number < 0);

 ## files (3 steps):
1. Open the file
2. Process the file (write or read)
3. Close the file

 ## StreamReader (read from a file):

StreamReader reads data from a text file. File.OpenText(): opens the file for reading. ReadLine(): reads one line and returns it as a string. Read(): reads the next character(s). EndOfStream: true when the end of the file is reached.

 ## StreamWriter (write to a file):

StreamWriter writes data to a text file. Write(): writes an item without a newline. WriteLine(): writes an item, then a newline. Close(): closes the file.