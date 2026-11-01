# Chapter 4: Loops, Files, and Random Numbers

## 1. The while Loop


- Repeats statements as long as a Boolean expression is true.
- A **counter variable** tracks how many times a loop runs.
- **Infinite loop:** the condition never becomes false .

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;   // without this, the loop is infinite
}
```
## 2. Increment and Decrement Operators
- **Postfix** (`count++`): use the old value, then change it.
- **Prefix** (`++count`): change the value first, then use it.
## 3. The for Loop
- Designed for loops controlled by a counter. It is a pretest loop.
- Three parts: **Initialization** (once), **Test** (if true, iterate), **Update** (change the counter).
```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
for (int c = 0; c <= 100; c += 10) { }   // step by 10
for (int c = 10; c >= 0; c--) { }        // backward
```
## 4. The do-while Loop
- A **posttest loop**: runs the body once before testing the condition.
```csharp
do
{
    statements;
} while (BooleanExpression);
```
## 5. Using Files for Data Storage
- Three steps: **open** the file, **process** it (read/write), **close** it.
- **Text file** = data encoded as text (e.g., Unicode). **Binary file** = not text, can't be read in a text editor. This chapter uses text files only.
- .NET classes: `StreamWriter` (write) and `StreamReader` (read).

**Writing**
```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Calculus I");   // WriteLine adds a newline; Write does not
outputFile.Close();
```
- `File.CreateText`: creates the file; **erases** it if it already exists.
- `File.AppendText`: adds to the end of an existing file without erasing.
- Use a path with the `@` prefix: `File.AppendText(@"C:\Data\Names.txt");`

**Reading**
```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");
string line = inputFile.ReadLine();
inputFile.Close();
```
- `ReadLine`: one line as a string. `Read`: next character(s). Also `ReadToEnd`, `File.ReadAllText`.
- `EndOfStream` is true at the end of the file; read all lines with a loop:
```csharp
while (!inputFile.EndOfStream)
{
    // read a line
}
```
## 6. OpenFileDialog and SaveFileDialog
- Standard Windows **Open** / **Save As** dialogs; **invisible controls** shown in the component tray.
- `ShowDialog()` shows them and returns a `DialogResult` (`OK` or `Cancel`).
- The chosen path and name are stored in the `Filename` property.
- `InitialDirectory` sets the folder shown first.
```csharp
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.Filename);
}
openFileDialog.InitialDirectory = @"C:\Data";

if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(saveFileDialog.Filename);
}
```
## 7. Random Numbers
- Use the `Random` class: `Random rand = new Random();`
- `Next()`: random integer from 0 to 2,147,483,647.
- `Next(max + 1)`: random integer from 0 to `max`. Example: `rand.Next(100)` gives 0–99.
- `NextDouble()`: random decimal from 0.0 to 1.0.
## 8. The Load Event
- Occurs when the form is loaded into memory. Double-click the form in the Designer to create the handler.
- Code inside it runs when the form launches.
```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```
© 2024, Pearson Education, Ltd. All Rights Reserved