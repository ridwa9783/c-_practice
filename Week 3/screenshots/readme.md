# Week 3 – Screenshots Explanation

This folder contains screenshots of the C# programs and examples I practiced during Week 3. These examples helped me understand decision-making statements, logical operators, string comparison, input validation, and working with ListBox controls in Windows Forms.

## 1. Switch Statement Example

**Screenshot:** `screenshot-01.png`

In this example, I used the `switch` statement to check the day entered by the user.

- `txtday.Text.ToLower()` converts the input into lowercase.
- Each `case` checks a different day of the week.
- `MessageBox.Show()` displays the matching day.
- `break` stops the execution of the current case.
- `default` displays a message when the entered day is invalid.

## 2. Input Validation Using TryParse

**Screenshot:** `screenshot-02.png`

In this example, I used `int.TryParse()` to check whether the user entered a valid number of hours.

- `int.TryParse()` checks if the input can be converted into an integer.
- If the input is valid, the program displays the entered number.
- If the input is invalid, it displays an error message.

This method helps prevent invalid numeric input.

## 3. String.Compare Method

**Screenshot:** `screenshot-03.png`

In this example, I used the `String.Compare()` method to compare two string variables.

- `String.Compare(name1, name2)` compares the two names.
- If the result is `0`, the names are the same.
- Otherwise, the names are different.

## 4. Comparing a String with a String Literal

**Screenshot:** `screenshot-04.png`

In this example, I compared the `name1` variable with the string `"bob"` using the `!=` operator.

- If the name is not equal to `"bob"`, the program displays that the name is not bob.
- Otherwise, it displays that the name is bob.

## 5. Comparing Two Strings Using the == Operator

**Screenshot:** `screenshot-05.png`

In this example, I created two string variables and assigned values from two TextBoxes.

- `name1` gets its value from `txtname1.Text`.
- `name2` gets its value from `txtname2.Text`.
- The `==` operator checks whether both strings have the same value.
- The program displays a message depending on the result.

## 6. Boolean Variable Example

**Screenshot:** `screenshot-06.png`

In this example, I used a Boolean variable called `isGrandMaster`.

- First, I declared a `double` variable to store the player's points.
- I used `double.Parse()` to read the points from the TextBox.
- If the points are greater than 5000, `isGrandMaster` becomes `true`.
- Otherwise, it becomes `false`.
- Finally, `MessageBox.Show()` displays the Boolean result.

## 7. Decision Structure with Logical Operators

**Screenshot:** `screenshot-07.png`

In this example, I practiced the three logical operators in C#.

**AND operator (`&&`)**

Both conditions must be true for the statement to execute.

**OR operator (`||`)**

At least one condition must be true for the statement to execute.

**NOT operator (`!`)**

This operator reverses a Boolean condition.

I used temperature and minutes as variables to practice these operators.

## 8. If-Else If Statement Example

**Screenshot:** `screenshot-08.png`

In this example, I used an `if-else if` structure to calculate a student's grade based on their test score.

- 90 or above = A
- 80 or above = B
- 70 or above = C
- 60 or above = D
- Below 60 = F

The program checks the score and assigns the correct grade to the `grade` variable.

## 9. Nested Decision-Making Example

**Screenshot:** `screenshot-09.png`

In this example, I used a nested `if-else` statement to check whether a person qualifies for a loan.

The program checks two conditions:

1. The salary must be greater than or equal to 40000.
2. The person must have worked for at least 2 years.

If both requirements are met, the program displays that the person qualifies for the loan. Otherwise, it displays the reason why the requirements are not met.

## 10. If-Else Statement Example

**Screenshot:** `screenshot-10.png`

In this example, I used an `if-else` statement to check the temperature.

- If the temperature is greater than 40, the program displays "It's hot outside!"
- Otherwise, it displays "It's not hot outside."

This example helped me understand how an `if-else` statement chooses between two different actions.

## 11. Clear All Items from a ListBox

**Screenshot:** `screenshot-11.png`

In this example, I used the `ListBox1.Items.Clear()` method to remove all items from a ListBox.

- `ListBox1.Items.Count` checks how many items are inside the ListBox.
- If the ListBox contains items, `Clear()` removes all of them.
- If it is already empty, the program displays a message.

## 12. Remove a Selected Item from a ListBox

**Screenshot:** `screenshot-12.png`

In this example, I used the `Remove()` method to delete a selected item from a ListBox.

- `ListBox1.SelectedIndex != -1` checks whether an item is selected.
- `ListBox1.SelectedItem` gets the selected item.
- `ListBox1.Items.Remove()` removes that item.
- If no item is selected, the program displays a message asking the user to select an item.

## Conclusion

These screenshots show the practical examples I worked on during Week 3. Through these exercises, I practiced using decision-making statements, comparing strings, validating user input, working with Boolean variables, applying logical operators, and managing items in a ListBox.