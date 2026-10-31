# Week 5 – Chapter 4: Files and Random Numbers

## Introduction

In Week 5, I continued with Chapter 4 and studied how C# applications work with files. I learned how to store information in text files, retrieve saved data, and allow users to select files through Windows dialog boxes. I also studied random number generation and the Form Load event.

## 1. Storing Information in Files

A program can use files to keep information for future use. Instead of losing data when the application closes, the program can save it in a file.

Working with a file normally involves three stages:

1. **Open:** Establish a connection between the application and the file.
2. **Process:** Read information from the file or write new information into it.
3. **Close:** End the connection after finishing the operation.

### Different File Types

There are two general types of files:

- **Text Files:** Store information as readable text.
- **Binary Files:** Store information in binary format, which is not normally readable using a text editor.

The examples in this chapter mainly focus on text files.

## 2. StreamWriter Class

`StreamWriter` is a C# class used to write information into text files.

Before writing data, we declare a StreamWriter variable and open the file.

**Example:**

```csharp
StreamWriter outputFile;

outputFile = File.CreateText("Students.txt");

outputFile.WriteLine("Ahmed");
outputFile.WriteLine("Mohamed");
outputFile.WriteLine("Ali");

outputFile.Close();
```

Here, `CreateText()` creates the file, while `WriteLine()` stores the names on separate lines.

### Write() and WriteLine()

Both methods are used to write information into a file, but they work differently.

- `Write()` writes data without moving to a new line.
- `WriteLine()` writes data and then moves to the next line.

### CreateText() Method

The `File.CreateText()` method creates a text file with the specified name.

If a file with that name already exists, its previous contents are erased.

### AppendText() Method

Sometimes we need to add more information without deleting the existing data. In that situation, we use `File.AppendText()`.

**Example:**

```csharp
StreamWriter outputFile;

outputFile = File.AppendText("Students.txt");

outputFile.WriteLine("Hassan");
outputFile.WriteLine("Abdi");

outputFile.Close();
```

This method adds the new information to the existing file.

## 3. Reading Information with StreamReader

`StreamReader` is used to retrieve information from a text file.

To read a file, we first declare a StreamReader variable and use `File.OpenText()`.

**Example:**

```csharp
StreamReader inputFile;

inputFile = File.OpenText("Students.txt");
```

### Methods for Reading Data

C# provides different methods for reading file contents:

| Method | Purpose |
|---|---|
| `ReadLine()` | Reads one line from the file. |
| `Read()` | Reads the next character or characters. |
| `ReadToEnd()` | Reads the remaining content of the file. |
| `File.ReadAllText()` | Reads all text from a file. |

After completing the reading operation, we close the file connection using `Close()`.

## 4. Reading a File Using a Loop

When a file contains many lines, a loop can be used to read its contents until the end is reached.

The `EndOfStream` property tells us whether the StreamReader has reached the end of the file.

**Example:**

```csharp
while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    listBox1.Items.Add(line);
}
```

The loop continues while there is still information available to read.

## 5. OpenFileDialog Control

`OpenFileDialog` allows users to choose an existing file from their computer.

It displays the standard Windows Open dialog box.

Unlike visible controls such as Button, Label, and TextBox, OpenFileDialog is an invisible control. It appears in the component tray in the Windows Forms Designer.

### ShowDialog() Method

The `ShowDialog()` method displays the Open dialog box.

```csharp
openFileDialog.ShowDialog();
```

### DialogResult

After the dialog appears, the application can check which option the user selected.

- `DialogResult.OK` means the user selected Open.
- `DialogResult.Cancel` means the user cancelled the operation.

**Example:**

```csharp
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.FileName);
}
```

### FileName Property

The `FileName` property contains the path and name of the file selected by the user.

### InitialDirectory Property

The `InitialDirectory` property allows us to specify which folder should appear first when the Open dialog box is displayed.

**Example:**

```csharp
openFileDialog.InitialDirectory = @"C:\Data";
```

## 6. SaveFileDialog Control

`SaveFileDialog` is used when an application needs the user to choose where to save a file.

It displays the standard Windows Save As dialog box.

**Example:**

```csharp
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(saveFileDialog.FileName);
}
```

If the user selects OK, the application can use the selected file path to create the output file.

## 7. Generating Random Numbers

C# provides the `Random` class for generating random values.

First, we create an object from the Random class.

```csharp
Random rand = new Random();
```

The chapter introduces two commonly used methods.

### Next() Method

The `Next()` method generates a random integer.

```csharp
int number1 = rand.Next();
```

It can also generate an integer within a specified range.

```csharp
int number = rand.Next(100);
```

This example generates a number from 0 to 99.

### NextDouble() Method

The `NextDouble()` method generates a floating-point number from 0.0 up to, but not including, 1.0.

```csharp
double number2 = rand.NextDouble();
```

These methods are useful when an application needs to generate values randomly.

## 8. The Form Load Event

The Load event happens when a Windows Form is loaded into memory as the application starts.

To create its event handler, we can double-click the form in the Designer.

**Example:**

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Welcome to the application!");
}
```

The statements inside `Form1_Load` execute when the form is launched.

This event can be used to perform actions that should happen when the application first opens.

## Conclusion

This week helped me understand how C# applications can store and retrieve information using text files. I practiced writing data with StreamWriter, reading data with StreamReader, and selecting files through OpenFileDialog and SaveFileDialog. I also learned how to generate random numbers and use the Form Load event in Windows Forms.