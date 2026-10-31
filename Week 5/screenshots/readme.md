# Week 5 – Screenshots Explanation

This folder contains screenshots of the C# file handling examples I practiced during Week 5. These examples helped me understand how to create text files, write data into files, append new information, and read data from existing files.

## 1. StreamReader and ReadToEnd Method

**Screenshot:** `screenshot-01.png`

In this example, I used `StreamReader` to read data from an existing text file.

- `StreamReader` is used to read information from a file.
- `File.OpenText()` opens an existing text file.
- `ReadToEnd()` reads all the remaining content from the file.
- `ListBox.Items.Add()` displays the read information inside a ListBox.

This example helped me understand how to read all the content from a text file.

## 2. Append Data to an Existing File

**Screenshot:** `screenshot-02.png`

In this example, I used `StreamWriter` with `File.AppendText()` to add new information to an existing text file.

The program performs the following steps:

1. Creates a `StreamWriter` variable.
2. Uses `File.AppendText()` to open the existing file.
3. Uses `WriteLine()` to add new information.
4. Uses `Close()` to close the file.
5. Displays a success message using `MessageBox.Show()`.

I also used `try-catch` to handle errors that may happen while working with the file.

## 3. Create a New Text File

**Screenshot:** `screenshot-03.png`

In this example, I used `File.CreateText()` to create a new text file.

The program writes the names of football teams from the English Premier League into the file.

The teams included are:

- Big Six teams in the Premier League
- Manchester City
- Manchester United
- Chelsea
- Arsenal
- Liverpool
- Tottenham Hotspur

I used `WriteLine()` to write each team on a separate line.

After writing the information, I used `Close()` to close the file and displayed a success message.

I also used `try-catch` to handle possible errors.

## 4. StreamWriter – Writing Data into a File

**Screenshot:** `screenshot-04.png`

In this example, I practiced using `StreamWriter` to create and write information into a text file called `Ca242.txt`.

- `StreamWriter outputfile` declares the variable used to write data.
- `File.CreateText("Ca242.txt")` creates the text file.
- `Write()` writes information into the file.
- `Close()` closes the file after writing.

The information I wrote into the file includes:

- The best class in semester 5.
- Jamhuriya University.
- Subject Java.

This example helped me understand how to write text into a file using the `Write()` method.

## 5. Reading All Text from a File Using ReadAllText

**Screenshot:** `screenshot-05.png`

In this example, I used `File.ReadAllText()` to read all the information from an existing text file.

- `File.ReadAllText()` reads the complete content of the file.
- The returned information is stored in a string variable called `read_alltext`.
- `ListBox.Items.Add()` displays the information inside a ListBox.
- `try-catch` handles possible errors.

Unlike reading a file line by line using a loop, this method reads the entire file content at once.

## 6. StreamWriter Declaration

**Screenshot:** `screenshot-06.png`

In this example, I declared a `StreamWriter` variable called `outputfile`.

`StreamWriter` is used when we want to write or append information to a text file.

This declaration prepares the variable that will be used in the file handling operations.

## Conclusion

These screenshots show the practical exercises I completed during Week 5. I learned how to create new text files, append information to existing files, read file contents using different methods, and write data using StreamWriter. I also practiced using try-catch to handle file-related errors in C#.