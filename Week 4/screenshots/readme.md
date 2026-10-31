# Week 4 – Screenshots Explanation

This folder contains screenshots of the C# loop examples and practical exercises I worked on during Week 4. These examples helped me understand how loops work and how to use them in Windows Forms applications.

## 1. Decrement Operator Example

**Screenshot:** `screenshot-01.png`

In this example, I practiced different ways to decrease the value of a variable by 1.

- `count--` decreases the value of count by 1.
- `count -= 1` also decreases the value by 1.
- `count = count - 1` is another way to perform the same operation.

These statements help me understand how the decrement operator works in C#.

## 2. Do-While Loop Example

**Screenshot:** `screenshot-02.png`

In this example, I used a `do-while` loop to display a message repeatedly.

- The loop starts by executing the statements inside `do`.
- `MessageBox.Show()` displays the message.
- The counter is increased after each iteration.
- The condition is checked at the end of the loop.

The `do-while` loop executes its statements at least once before checking the condition.

## 3. For Loop Example

**Screenshot:** `screenshot-03.png`

In this example, I used a `for` loop to display the message "Hello" five times.

The loop has three parts:

1. `int i = 0` initializes the counter.
2. `i < 5` checks the condition.
3. `i++` increases the counter by 1.

When the condition becomes false, the loop stops.

## 4. While Loop Example

**Screenshot:** `screenshot-04.png`

In this example, I used a `while` loop to display "Hello" five times.

- First, I initialized the count variable to 0.
- The loop checks whether count is less than 5.
- If the condition is true, the message is displayed.
- `count = count + 1` increases the counter by 1.

The loop continues until the condition becomes false.

## 5. While Loop for Balance Calculation

**Screenshot:** `screenshot-05.png`

In this example, I used a `while` loop to calculate the ending balance for each month.

- The loop checks whether the current month is less than or equal to the number of months.
- The balance is increased using 0.5% interest.
- `lstOutput.Items.Add()` displays the ending balance for each month.
- `month++` moves to the next month.

This example shows how a loop can be used to repeat calculations.

## 6. Complete Balance Calculation Program

**Screenshot:** `screenshot-06.png`

In this screenshot, I worked on a complete program that calculates the ending balance based on the starting balance and the number of months.

The program performs the following steps:

1. Uses `double.Parse()` to read the starting balance from the TextBox.
2. Uses `int.Parse()` to read the number of months.
3. Stores the starting balance in the balance variable.
4. Initializes the month variable to 1.
5. Uses `lstOutput.Items.Clear()` to remove previous results.
6. Uses a `while` loop to calculate the balance for each month.
7. Displays the monthly ending balance inside the ListBox.
8. Displays the final balance using `EndingBalanceOutput.Text`.

### Exception Handling

I also used `try-catch` to handle errors.

- The `try` block contains the balance calculation.
- The `catch` block handles an error if something goes wrong.
- `MessageBox.Show()` displays an error message to the user.

## Conclusion

These screenshots show the practical exercises I completed during Week 4. I practiced decrement operators, different types of loops, and using a while loop to perform monthly balance calculations. I also learned how to display results in a ListBox and handle errors using try-catch.