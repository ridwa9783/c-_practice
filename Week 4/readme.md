# Week 4 – Chapter 4: Loops in C#

## Introduction

This week was about loops and how they are used in C# programming. A loop allows a program to repeat instructions without writing the same statements many times. I learned the different types of loops and how to control their execution using conditions and counter variables.

## 1. Repeating Statements with the while Loop

The `while` loop is used when we want to repeat a task as long as a given condition remains true.

**Example:**

```csharp
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}
```

In this program, the counter starts at zero. The condition checks whether the counter is below 5. Each time the loop runs, the message is displayed and the counter increases by one.

### Important Points

- The condition of a while loop must be a Boolean expression.
- The statements inside the loop are called the loop body.
- Each repetition is known as an iteration.
- A counter variable can be used to track the number of repetitions.

### Pretest Loop

A `while` loop is called a pretest loop because it checks its condition before executing the statements.

If the condition is false at the beginning, the loop body will not run.

### Infinite Loop

An infinite loop occurs when the condition never becomes false. This can happen when the programmer forgets to update the counter variable.

For example, if `count` remains zero while the condition is `count < 5`, the loop will continue running.

## 2. Increasing and Decreasing Variables

C# provides special operators for changing the value of numeric variables.

### Increment Operator (++)

Increment means adding one to a variable.

The following statements perform the same operation:

```csharp
count++;
count += 1;
count = count + 1;
```

### Decrement Operator (--)

Decrement means subtracting one from a variable.

```csharp
count--;
count -= 1;
count = count - 1;
```

### Prefix and Postfix

These operators can be written before or after a variable.

- Prefix: `++count` or `--count`
- Postfix: `count++` or `count--`

The difference is related to when the variable is updated. Prefix changes the value before it is used, while postfix uses the current value before changing it.

## 3. Using the for Loop

The `for` loop is useful when we want to repeat a task a specific number of times.

It contains three main expressions:

1. **Initialization:** Gives the counter its starting value.
2. **Condition:** Determines whether another iteration should happen.
3. **Update:** Changes the counter after each iteration.

**Example:**

```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

The message is displayed five times because the loop starts at zero and stops when the counter reaches five.

### Changing the Counter Update

The update expression does not always have to increase the counter by one.

**Increasing by 10:**

```csharp
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}
```

**Counting backward:**

```csharp
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

Like the while loop, the `for` loop is also a pretest loop because it checks the condition before running its body.

## 4. The do-while Loop

The `do-while` loop is another way to repeat statements. Its main difference from the while loop is that it executes the loop body before checking the condition.

**Example:**

```csharp
int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);
```

Even though the condition is false, the message box appears once because the statements execute before the condition is checked.

### Posttest Loop

The `do-while` loop is called a posttest loop because the condition is evaluated after the loop body.

**Difference between while and do-while:**

- `while` checks the condition first.
- `do-while` executes the body first and checks the condition afterward.
- A `while` loop may execute zero times.
- A `do-while` loop executes at least once.

## Conclusion

In this week, I studied how repetition works in C#. I learned when to use while, for, and do-while loops. I also practiced controlling loops through counter variables and the increment and decrement operators. These topics helped me understand how to repeat instructions and avoid unnecessary repeated code.