# FileEditor
### File Editor code challenge for Code Louisville

This solution is for the File Editor code challenge.  This challenge is designed to get you started searching for solutions to problems that you haven't encountered yet.  You will need to figure out how to read and write files, and as a bonus challenge, you will need to convert the file to XML.  You will only need to make changes to the DataService.cs file.

#### CreateTestFile() Method
Method for creating a new file to write to, overwriting any file with the same name that already exists.  You will need to create the file test.txt in the current directory, and using the numbers 0, 1, 2, 3, and 4, add each number to its own line in the file.  The file should be overwritten if the same file already exists.

#### ReadTestData() Method
Reads the test data from the file.  Read each line of the file, and store it in the "numbers" variable.  Check that each item is read in as an int before try to add it to "numbers"

#### AppendTestData() Method
Appends a new number to the file.  Accept an int paramter named number, and append the number to the end of the file (DO NOT OVERWRITE THE FILE CREATED IN THE CreateTestFile() METHOD).

### BONUS
#### ConvertToXML() Method
Convert the file to VALID and WELL-FORMED XML.  You can use the following URL to http://xmlgrid.net/validator.html to validate your file when completed.
