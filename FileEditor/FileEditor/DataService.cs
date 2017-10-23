using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileEditor
{
    /// <summary>
    /// Implements methods from DataServiceBase
    /// 
    /// HINT:
    /// These method signatures have been declared in the DataServiceBase.cs file.
    /// It is up to you to create the method implementation
    /// I have already started the implementation of the abstract methods below
    /// </summary>
    public class DataService : DataServiceBase
    {
        /// <summary>
        /// Method for creating a new file to write to, overwriting
        /// any file with the same name that already exists.
        /// 
        /// Requirements:
        /// Create test.txt in the current directory.
        /// Using the numbers 0, 1, 2, 3, and 4, add each number to its own line.
        /// The file should be overwritten if the same file already exists.
        /// 
        /// Additional Notes:
        /// The class you use to write will be disposable, so you should wrap your code in a using block.
        /// You can modify this method as much as needed, but it has 
        /// already been partially completed to help get you started if needed.
        /// </summary>
        public override void CreateTestFile()
        {
                using (// Open file for writing here)
                {
                    // Loop and write to file
                }
        }

        /// <summary>
        /// Reads the test data from the file
        /// 
        /// Requirements:
        /// Read each line of the file, and store it in the "numbers" variable.
        /// Return the enumerable for use in Main()
        /// Check that each item read in as an int before try to add it to "numbers"
        /// 
        /// Additional Notes:
        /// The class you use to read will be disposable, so you should wrap your code in a using block.
        /// The "numbers" variable has already been created for you.
        /// You can modify this method as much as needed, but it has 
        /// already been partially completed to help get you started if needed.
        /// </summary>
        /// <returns></returns>
        public override void ReadTestData()
        {
            using (// Open file for reading here)
            {
                numbers.Clear();
                string line;
                while (// While there are lines in the file)
                {
                    // Parse the text from the line into a number and add it to "numbers"
                }
            }
        }

        /// <summary>
        /// Appends a new number to the file
        /// 
        /// Requirements:
        /// Accept an int paramter named number
        /// Append the number to the end of the file
        /// (DO NOT OVERWRITE THE FILE CREATED IN THE CreateTestFile() METHOD)
        /// 
        /// Additional Notes:
        /// The class you use to write will be disposable, so you should wrap your code in a using block.
        /// The "numbers" variable has already been created for you.
        /// You can modify this method as much as needed, but it has 
        /// already been partially completed to help get you started if needed.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override void AppendTestData(int number)
        {
            using (// Open file for writing here)
            {
                Console.WriteLine($"Appending the number {number} to the data set.");
                // Write the number parameter to the end of the file here
            }
            Console.WriteLine();
        }

        /// <summary>
        /// BONUS CHALLENGE:
        /// Convert the file to VALID and WELL-FORMED XML
        /// You can use the following URL to http://xmlgrid.net/validator.html to validate
        /// 
        /// Additional Notes:
        /// No help here.  Hey, what can I say, it's supposed to be a challenge.
        /// </summary>
        public override void ConvertToXML()
        {
        }
    }
}
