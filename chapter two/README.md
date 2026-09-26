# # Chapter 2 
## Topics

- 3.1 Reading Input with TextBox Controls
- 3.2 A First Look at Variables
- 3.3 Numeric Data Types and Variables
- 3.4 Performing Calculations
- 3.5 Inputting and Outputting Numeric Values *(introduced)*

##  Reading Input with TextBox Controls

**TextBox Control**
- A rectangular control that accepts keyboard input from the user.
- Found in the *Common Control* group of the Toolbox.
- Added to a form by double-clicking it in the Toolbox.
- Default name follows the pattern `textBoxn` (where n = 1, 2, 3, …).

**The Text Property**
- A TextBox's `Text` property stores whatever the user types in, always as a **string**.
- Example: `textBox1.Text = "Hello";`
- To clear a TextBox, assign it an empty string in any of these ways:
  ```csharp
  textBox1.Text = "";
  textBox1.Text = string.Empty;
  textBox1.Clear();
  ```

---

##  A First Look at Variables

**What Is a Variable?**
- A variable is a named storage location in memory.
- A variable must be **declared** before it is used.
- Declaration syntax: `DataType VariableName;`

**Data Types**
- Every variable must be declared with a proper data type.
- Data types that store basic/fundamental values (like numbers and strings) are called **primitive data types**.
- In C#, primitive types are built into the language — they are not created by the programmer.

**Variable Naming Rules**
- Choose meaningful names.
- The first character must be a letter (upper/lowercase) or an underscore (`_`).
- Names cannot contain spaces.
- Reserved keywords cannot be used as variable names.

**String Variables**
- A `string` holds a sequence of characters (names, phone numbers, etc.).
- Assigned using double quotes:
  ```csharp
  productDescription = "Jamhuuriya University";
  ```
- Can be displayed in a Label:
  ```csharp
  productLabel = productDescription;
  ```
- Or shown in a message box:
  ```csharp
  MessageBox.Show(productDescription);
  ```

**String Concatenation**
- The `+` operator joins (concatenates) strings.
- Can also combine a string with another data type (e.g., `int` or `double`):
  ```csharp
  12 + " apples";
  "Total is " + 25.75;
  ```

**Declaring Variables Before Using Them**
- A variable can be declared first and assigned/used later in the code.

**Local Variables and Scope**
- A **local variable** belongs only to the method in which it is declared.
- Only code inside that method can access it.
- **Scope** = the part of the program where a variable can be accessed.
- **Lifetime** = how long the variable exists in memory while the program runs.
- A local variable is created when its method starts executing and destroyed when the method ends.

**Duplicate Variable Names**
- Two variables cannot share the same name within the same scope.
- The same name **can** be reused in different methods.

**Assignment Compatibility**
- A value can only be assigned to a variable if it is compatible with that variable's data type (e.g., only strings are compatible with the `string` type).

**Initializing Variables**
- A variable must be assigned a value before it is used.
- Using an unassigned variable causes a compiler error: *"Use of unassigned local variable."*

**Declaring Multiple Variables in One Statement**
```csharp
string lastName, firstName, middleName;
```
- A long declaration can also be spread across multiple lines:
  ```csharp
  string lastName = "Khalaf",
         firstName = "Mohamed",
         middleName = "Abdullahi";
  ```

---

##  Numeric Data Types and Variables

**Common Numeric Types**
| Type | Description |
|---|---|
| `int` | Whole numbers (up to 2,147,483,647) |
| `double` | Real numbers, including fractional values |
| `decimal` | Real numbers with greater precision than `double`; typically used for financial values |

**Numeric Literals**
- A numeric literal is a number written directly into code (never in quotes).
- Whole numbers (e.g., `40`, `99`) are treated as `int`.
- Numbers with a decimal point (e.g., `87.6`, `3.14`) are treated as `double`.
- Appending `m` or `M` creates a `decimal` literal:
  ```csharp
  decimal payRate = 28.75m;
  ```

**Assignment Compatibility for Numeric Types**
- `int` variables → only accept `int` values.
- `double` variables → accept both `int` and `double` values (not `decimal`).
- `decimal` variables → accept both `int` and `decimal` values (not `double`).

**Explicit Conversion with Cast Operators**
- Type casting explicitly converts one type to another using the type name in parentheses:
  ```csharp
  wholeNumber = (int)moneyNumber;
  realNumber = (double)moneyNumber;
  ```

**The `var` Keyword**
- `var` lets the compiler infer a variable's type from its initial value (type inference).
- An initialization value is **required** when using `var`.
- Can only be used for **local** variables.
  ```csharp
  var interestRate = 12.0;
  var stockCode = "D465U";
  var accountBalance = 1000.0m;
  ```
---

##  Performing Calculations

**Math Operators**
| Operator | Name | Description |
|---|---|---|
| `+` | Addition | Adds two numbers |
| `-` | Subtraction | Subtracts one number from another |
| `*` | Multiplication | Multiplies two numbers |
| `/` | Division | Divides one number by another (quotient) |
| `%` | Modulus | Divides one number by another (remainder) |

**Rules for Calculations**

- Follow the standard order of operations; use parentheses to group when needed:
  ```csharp
  result = (a + b) / 4;
  ```
- Mixed data-type rules:
  - `int` + `double` result is `double`.
  - `int` + `decimal`  result is `decimal`.
  - `double` and `decimal` **cannot** be combined directly.

**Integer Division**
- Dividing an `int` by an `int` always produces an integer result (fractional part is dropped).
  ```csharp
  int x = 7, y = 3;
  MessageBox.Show((x / y).ToString());   // Result: 2
  ```
- To avoid integer division, cast one operand to `double`:
  ```csharp
  MessageBox.Show(((double)x / y).ToString());
  ``
---

## 3.5 Inputting and Outputting Numeric Values

- Keyboard input (even numbers typed into a TextBox) is always treated as a **string**.
- To use that input as a number, it must be converted using a `Parse` method:
  - `int.Parse`
  - `double.Parse`
  - `decimal.Parse`
  ```csharp
  int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
  double temperature = double.Parse(temperatureTextBox.Text);
  ```

**Displaying Numeric Values**

- A control's `Text` property only accepts strings, so numeric values must be converted to strings using `ToString()`:
  ```csharp
  decimal grossPay = 1550.0m;
  grossPayLabel.Text = grossPay.ToString();

  int myNumber = 123;
  MessageBox.Show(myNumber.ToString());
  ```
- Alternative: implicit string conversion with the `+` operator:
  ```csharp
  int idNumber = 1044;
  string output = "Your ID number is " + idNumber;
