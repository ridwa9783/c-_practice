# Week 3 – Making Decisions in C#

## Introduction

In this week, I studied how C# programs make decisions based on different conditions. I learned how to control the execution of a program by checking values entered by the user. I also practiced comparing data, using logical operators, and working with Windows Forms controls.

## 1. Understanding Conditions in C#

A condition is an expression that the program checks to determine whether something is true or false.

C# uses decision-making statements to execute different blocks of code depending on the result of a condition.

For example:

```csharp
int temperature = 90;

if (temperature > 40)
{
    MessageBox.Show("The weather is hot.");
}
```

Here, the program checks whether the temperature is greater than 40. If the condition is true, it displays a message.

## 2. Relational Operators

Relational operators are used to compare two values. They help the program make decisions.

The common relational operators are:

| Operator | Meaning |
|---|---|
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `==` | Equal to |
| `!=` | Not equal to |

These operators return either `true` or `false`.

## 3. The if Statement

The `if` statement executes a block of code only when its condition is true.

**Example:**

```csharp
int age = 20;

if (age >= 18)
{
    MessageBox.Show("You are an adult.");
}
```

If the age is 18 or above, the message will appear. If the condition is false, the program skips the block.

## 4. The if-else Statement

The `if-else` statement provides two possible paths for a program.

- The `if` block runs when the condition is true.
- The `else` block runs when the condition is false.

**Example:**

```csharp
double temperature = 25;

if (temperature > 30)
{
    MessageBox.Show("It is hot.");
}
else
{
    MessageBox.Show("It is not hot.");
}
```

This structure is useful when a program needs to choose between two actions.

## 5. Multiple Conditions Using if-else-if

Sometimes a program needs to check more than two possible conditions. In that situation, we can use an `if-else-if` structure.

**Example:**

```csharp
int score = 85;

if (score >= 90)
{
    MessageBox.Show("Grade A");
}
else if (score >= 80)
{
    MessageBox.Show("Grade B");
}
else if (score >= 70)
{
    MessageBox.Show("Grade C");
}
else
{
    MessageBox.Show("Grade F");
}
```

The program checks the conditions from top to bottom. When one condition becomes true, its block executes and the remaining conditions are skipped.

## 6. Nested if Statements

A nested decision structure means placing one `if` statement inside another `if` or `else` block.

It is useful when a decision depends on more than one requirement.

For example, a bank may check a person's salary first and then check their years of employment before approving a loan.

```csharp
if (salary >= 40000)
{
    if (yearsOnJob >= 2)
    {
        MessageBox.Show("You qualify for the loan.");
    }
    else
    {
        MessageBox.Show("You need more work experience.");
    }
}
else
{
    MessageBox.Show("Salary requirement not met.");
}
```

The inner condition is checked only when the outer condition is true.

## 7. Logical Operators

Logical operators allow us to combine or reverse conditions.

C# has three main logical operators:

### AND (&&)

The AND operator returns true only when both conditions are true.

```csharp
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("Good conditions.");
}
```

### OR (||)

The OR operator returns true when at least one of the conditions is true.

```csharp
if (temperature < 20 || minutes > 12)
{
    MessageBox.Show("One condition is satisfied.");
}
```

### NOT (!)

The NOT operator reverses the result of a condition. True becomes false, and false becomes true.

```csharp
if (!(temperature < 20))
{
    MessageBox.Show("Temperature is not below 20.");
}
```

## 8. Boolean Variables

A Boolean variable stores only two possible values: `true` or `false`.

It is declared using the `bool` keyword.

**Example:**

```csharp
bool isPassed;

isPassed = true;
```

Boolean variables are useful for storing the result of a condition and checking the status of something.

For example, a program can use a Boolean variable to determine whether a player has reached a required score.

## 9. Comparing String Values

C# allows us to compare strings to determine whether two text values are equal or different.

One way is to use the equality operators:

```csharp
if (name1 == name2)
{
    MessageBox.Show("The names are equal.");
}
else
{
    MessageBox.Show("The names are different.");
}
```

We can also use the `!=` operator to check whether two strings are not equal.

### String.Compare Method

Another way to compare two strings is by using `String.Compare()`.

```csharp
if (String.Compare(name1, name2) == 0)
{
    MessageBox.Show("The names are the same.");
}
else
{
    MessageBox.Show("The names are different.");
}
```

When the method returns `0`, the two strings are equal according to the comparison being performed.

## 10. Validating User Input with TryParse

When users enter numbers into TextBoxes, the program should check whether the entered value can be converted into the required data type.

The `TryParse()` method helps us perform this check without causing a conversion exception for invalid input.

**Example:**

```csharp
int hours;

if (int.TryParse(txthours.Text, out hours))
{
    MessageBox.Show("Valid number entered.");
}
else
{
    MessageBox.Show("Please enter a valid number.");
}
```

If the input can be converted into an integer, the method returns true. Otherwise, it returns false.

## 11. The switch Statement

The `switch` statement is another way to make decisions. It is useful when one variable needs to be compared with several possible values.

**Example:**

```csharp
switch (day)
{
    case "Monday":
        MessageBox.Show("First day of the week.");
        break;

    case "Tuesday":
        MessageBox.Show("Tuesday selected.");
        break;

    default:
        MessageBox.Show("Invalid day.");
        break;
}
```

Important parts of a switch statement:

- `switch` specifies the value being checked.
- `case` represents a possible matching value.
- `break` ends the current case.
- `default` executes when no case matches.

## 12. Working with ListBox Items

A ListBox is a Windows Forms control used to display a list of items. Users can select one or more items depending on its configuration.

C# provides different methods for managing ListBox items.

### Adding Items

The `Items.Add()` method adds a new item to the ListBox.

```csharp
ListBox1.Items.Add("Computer Science");
```

### Removing a Selected Item

The `Items.Remove()` method removes a particular item from the list.

```csharp
if (ListBox1.SelectedIndex != -1)
{
    ListBox1.Items.Remove(ListBox1.SelectedItem);
}
```

`SelectedIndex` returns `-1` when no item is selected.

### Clearing All Items

The `Items.Clear()` method removes every item from the ListBox.

```csharp
ListBox1.Items.Clear();
```

We can also use `Items.Count` to check how many items are currently stored in the ListBox.

## Conclusion

During this week, I learned how to make C# programs respond to different conditions. I practiced using comparison operators, decision statements, logical operators, Boolean variables, and string comparison methods. I also learned how to validate input with TryParse and manage items inside a ListBox. These concepts are important when developing Windows Forms applications that need to respond to user input.