C# File Operations Assignment

This project demonstrates file operations using a ListBox to display content line-by-line and remove selected items.

1. Code Overview & Functions Used

A. File Creation (btnCreateFile_Click)

File.CreateText("DataFile.txt"): Creates a new text file and opens a stream to write lines using StreamWriter.

writer.WriteLine(...): Appends lines of text to the file.

writer.Close(): Closes and flushes the file stream.

B. Displaying Content in ListBox (btnReadOther_Click)

File.Exists(filePath): Checks whether the file exists on the disk.

File.ReadAllLines(filePath): Reads all text lines into a string[] array.

listBox1.Items.Add(line): Loads each string element into the ListBox control.

C. Deleting a Selected Item (btnDeleteItemFile_Click)

listBox1.SelectedIndex: Identifies which item the user clicked.

listBox1.Items.RemoveAt(...): Removes the chosen line from the ListBox.

File Update: Overwrites DataFile.txt with the remaining items from the ListBox using File.CreateText().

D. Deleting the Entire File (btnDeleteFile_Click)

File.Delete(filePath): Deletes the file entirely from storage and clears the ListBox.