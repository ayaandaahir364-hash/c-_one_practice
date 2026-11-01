# CHAPTER THREE: MAKING DECISIONS

##  Decision Structures

**Definition:** A decision structure executes a block of code only when a specified condition is true. A sequence structure executes statements in the order they are written.

```csharp
// Check if sales are greater than 50,000
if (sales > 50000)
{
    // Assign a bonus of 500
    bonus = 500;
}
```

**Relational Operators:**

| Operator | Meaning |
|---|---|
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `==` | Equal to |
| `!=` | Not equal to |

**Note:**
- `==` is used for comparison.
- `=` is used for assignment.

---

##  The if-else Statement

**Definition:** The `if-else` statement executes one block of code when the condition is true and another block when the condition is false.

```csharp
// Check if the temperature is greater than 40
if (temperature > 40)
{
    // Display a message if the condition is true
    MessageBox.Show("It is very hot");
}
else
{
    // Display a message if the condition is false
    MessageBox.Show("The temperature is normal");
}
```

---

##  Nested Decision Structures

**Definition:** A nested decision structure is an `if` statement placed inside another `if` statement. It is used to check multiple conditions.

```csharp
// Check the minimum salary requirement
if (salary >= 40000)
{
    // Check the minimum years of employment
    if (yearsOnJob >= 2)
    {
        // Display a message if both conditions are true
        MessageBox.Show("You qualify for the loan");
    }
    else
    {
        // Display a message if the employment requirement is not met
        MessageBox.Show("Minimum years at current job not met");
    }
}
else
{
    // Display a message if the salary requirement is not met
    MessageBox.Show("Minimum salary requirement not met");
}
```

### The if-else-if Statement

**Definition:** The `if-else-if` statement checks multiple conditions. Only the first true condition is executed.

```csharp
// Check if the score is 90 or above
if (score >= 90)
{
    grade = "A";
}
// Check if the score is 80 or above
else if (score >= 80)
{
    grade = "B";
}
// Check if the score is 70 or above
else if (score >= 70)
{
    grade = "C";
}
// Assign F if none of the conditions is true
else
{
    grade = "F";
}
```

---

##  Logical Operators

**Definition:** Logical operators are used to combine two or more conditions.

| Operator | Meaning |
|---|---|
| `&&` | AND – Both conditions must be true |
| `||` | OR – At least one condition must be true |
| `!` | NOT – Reverses the condition |

### AND Operator

```csharp
// Check if temperature is below 20 and minutes are greater than 12
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("Danger zone");
}
```

### OR Operator

```csharp
// Check if temperature is below 20 or above 100
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("Danger zone");
}
```

### NOT Operator

```csharp
// Check if temperature is not greater than 100
if (!(temperature > 100))
{
    MessageBox.Show("Below the maximum");
}
```

---

## 4.5 Boolean Variables and Flags

**Definition:** A Boolean variable stores only two values: `true` or `false`.

A flag is a Boolean variable used to indicate whether a particular condition exists.

```csharp
// Initialize the flag as false
bool isValid = false;

// Check if the score is between 0 and 100
if (score >= 0 && score <= 100)
{
    // Change the flag to true
    isValid = true;
}

// Check whether the flag is true
if (isValid)
{
    // Continue with the program
}
```

---

## 4.6 Comparing Strings

**Definition:** Strings can be compared using the `==` operator, the `!=` operator, or the `String.Compare()` method.

```csharp
// Compare two string variables
if (name1 == name2)
{
}

// Check if name1 is not equal to bob
if (name1 != "bob")
{
}

// Compare two strings using String.Compare()
if (String.Compare(name1, name2) == 0)
{
    // Both strings are equal
}
```

**Note:** `String.Compare()` returns 0 when both strings are equal.

---

## 4.7 Preventing Exceptions with TryParse

**Definition:** `TryParse()` converts a string into a numeric value without causing an exception if the conversion fails. It returns either `true` or `false`.

```csharp
// Declare an integer variable
int number;

// Try to convert the textbox input into an integer
if (int.TryParse(textBox1.Text, out number))
{
    // Conversion successful
}
else
{
    // Display an error message if conversion fails
    MessageBox.Show("Please enter a valid number");
}
```

**Other TryParse Methods:**
- `int.TryParse()`
- `double.TryParse()`
- `decimal.TryParse()`

---

## 4.8 Input Validation

**Definition:** Input validation is the process of checking user input before using it in a program.

`TryParse()` checks whether the input is a valid number, but it does not check whether the value is within an acceptable range.

```csharp
// Declare an integer variable
int hours;

// Check if the input is a valid integer
if (int.TryParse(textBox1.Text, out hours))
{
    // Check if hours are between 1 and 168
    if (hours > 0 && hours <= 168)
    {
        // Input is valid
    }
}
```

```csharp
// Check if the test score is between 0 and 100
if (testScore >= 0 && testScore <= 100)
{
    // Score is valid
}
```

---

## 4.9 Radio Buttons and Check Boxes

**Definition:**

**RadioButton:** Allows the user to select only one option within a group.

**CheckBox:** Allows the user to select multiple options.

**Important Properties:**

| Property | Meaning |
|---|---|
| `Text` | Displays the text of the control |
| `Checked` | Indicates whether the control is selected |

### RadioButton Example

```csharp
// Check if the radio button is selected
if (choiceRadioButton.Checked)
{
    // Execute the code
}
```

### CheckBox Example

```csharp
// Check if the checkbox is selected
if (option1CheckBox.Checked)
{
    // Execute the code
}
```

### CheckedChanged Event

```csharp
// This event runs when the radio button selection changes
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
    // Write the required code here
}
```

**Note:** Double-click a control in the Designer window to create its event handler.

---

## 4.10 The switch Statement

**Definition:** The `switch` statement selects one block of code from multiple options based on the value of a variable.

```csharp
// Check the value of the day variable
switch (day)
{
    // Execute when day equals 1
    case 1:
        MessageBox.Show("Monday");
        break;

    // Execute when day equals 2
    case 2:
        MessageBox.Show("Tuesday");
        break;

    // Execute when no case matches
    default:
        MessageBox.Show("Unknown day");
        break;
}
```

**Important Keywords:**
- `case`: Defines a possible value.
- `break`: Stops the switch statement.
- `default`: Executes when no case matches.

---

## 4.11 Introduction to List Boxes

**Definition:** A ListBox is a control used to display a list of items and allows the user to select an item.

### ListBox Properties

| Property | Meaning |
|---|---|
| `Items` | Contains all items in the list |
| `Items.Count` | Returns the number of items |
| `SelectedItem` | Returns the selected item |
| `SelectedIndex` | Returns the index of the selected item |
| `Text` | Gets the selected text |

**Note:** `SelectedIndex = -1` means no item is selected.

### Adding Items to a ListBox

```csharp
// Add Monday to the ListBox
daysListBox.Items.Add("Monday");

// Add Tuesday to the ListBox
daysListBox.Items.Add("Tuesday");
```

### Getting the Selected Item

```csharp
// Check if an item is selected
if (fruitListBox.SelectedIndex != -1)
{
    // Store the selected item in a variable
    selectedFruit = fruitListBox.SelectedItem.ToString();
}
```
### Removing Items from a ListBox

```csharp
// Remove Tuesday from the ListBox
daysListBox.Items.Remove("Tuesday");
// Remove the item at index 2
daysListBox.Items.RemoveAt(2);
// Remove all items from the ListBox
daysListBox.Items.Clear();
```
---

# END OF CHAPTER THREE