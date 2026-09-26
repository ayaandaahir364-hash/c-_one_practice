## Discuss chapter one
## Topics

##  Objects

* Object contains **data** and performs **operations**.
* **Properties** represent data/characteristics.
* **Methods** represent operations.

##  Controls

* Controls are **visible objects** in a GUI.
* Common controls: **Label, Button, TextBox**.
* Some objects are invisible, such as **Timer** and **OpenFileDialog**.
* A **class** describes a type of object.

##  .NET Framework

* .NET is a collection of **classes and code** for creating Windows applications.
* **C# is supported by .NET**.
* Controls are defined by specialized .NET classes.

##  Visual Studio

* Visual Studio is an **IDE (Integrated Development Environment)**.
* Important parts:

  * Designer Window
  * Solution Explorer
  * Properties Window
  * Toolbox
  * Code Editor

##  Toolbox

* Used to **select controls** for an application.
* Common controls include Button, CheckBox, ComboBox, Label, and ListBox.
* Usually located on the **left side** of Visual Studio.

##  Solution Explorer

* Displays the **projects and files** in a solution.
* Used to open files such as `Form1.cs` and `Program.cs`.
* To display the form: **Right-click Form1.cs  View Designer**.

##  Properties Window

* Displays properties of the **selected object**.
* Properties control how an object **looks and behaves**.
* Contains property names and their values.
* The `Text` property controls displayed text.

## 9. Forms

* A Windows Forms App automatically creates **Form1**.
* The form is the main window of the GUI.
* The **bounding box and sizing handles** are used to resize the form.

##  Adding Controls

* Controls are added from the Toolbox.
* Double-click a control or **drag and drop** it onto the form.
* Controls can be moved, resized, changed, or deleted.

##  Naming Controls

* Control names are called **identifiers**.
* First character must be a **letter or underscore**.
* Other characters can be letters, numbers, or underscores.
* **Spaces are not allowed**.
* C# commonly uses **camelCase**.

##  GUI Application

* GUI means **Graphical User Interface**.
* Users interact with applications through controls.
* The chapter's example uses a **Form and Button** to display "Hello World".

##  C# Code Organization

C# code is organized into:

* **Namespace**  contains classes.
* **Class**  contains methods.
* **Method**  contains statements that perform operations.
* A file containing code is a **source code file**.

##  Program.cs and Form1.cs

* `Program.cs` contains the application's **startup code**.
* `Form1.cs` contains code associated with **Form1**.
* Both can be opened through Solution Explorer.

##  Event-Driven Programming

* GUI applications are **event-driven**.
* The program waits for an event and responds.
* Examples: **button click, key press, mouse movement**.

##  Event Handler

* An event handler is a **method that responds to an event**.
* Double-clicking a control can create its event handler.
* Code inside the handler runs when the event occurs.

##  MessageBox

* A MessageBox displays a **message to the user**.
* `.NET` provides `MessageBox.Show()`.
* It is commonly used inside an event handler.

##  Label Control

* A Label displays **text or program output**.
* Important properties:

  * `Text`
  * `Name`
  * `Font`
  * `BorderStyle`
  * `AutoSize`
  * `TextAlign`

##  TextAlign

The Label text can be positioned in nine ways:

* TopLeft, TopCenter, TopRight
* MiddleLeft, MiddleCenter, MiddleRight
* BottomLeft, BottomCenter, BottomRight

##  Displaying Output in a Label

* The `Text` property can be changed using the **assignment operator `=`**.
* Example: `answerLabel.Text = "Hello";`
* To clear the Label: `answerLabel.Text = "";

##  PictureBox

* PictureBox is used to **display images**.
* Important properties:

  * `Image`
  * `SizeMode`
  * `Visible`
* A PictureBox can respond to a **Click event**.

##  Sequential Execution

* Statements execute **in the order they appear**.
* Correct sequence is important.
* Incorrect sequence can cause **logic errors**.

##  Comments

* Comments explain parts of source code.
* Single-line comment: 
* Block comment: 
* Comments help make code easier to understand.

## Blank Lines and Indentation

* Blank lines and indentation improve **code readability**.
* Indentation shows the structure of the code.

##  Closing a Form

* `this.Close();`  closes the **current form**.
* `Application.Exit();`  closes the **entire application**.

##  Syntax Errors

* A syntax error occurs when code does not follow **C# syntax rules**.
* Visual Studio checks code while you type.
* Errors are commonly shown with a **red jagged underline**.
* Syntax errors must be corrected before the program can compile successfully.
