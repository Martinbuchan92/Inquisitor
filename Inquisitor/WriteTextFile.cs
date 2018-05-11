using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquisitor
{
    class WriteTextFile
    {
        public static void ReadWrite(int[] stats)
        {

            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C:\Users\intro\documents\Inquisitor\inquisitor1.txt", lines);


            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\intro\documents\Inquisitor\inquisitor2.txt", text);

            // Example #3: Write only some strings in an array to a file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\intro\documents\Inquisitor\inquisitor3.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Example #4: Append new text to an existing file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\intro\documents\Inquisitor\inquisitor.txt", true))
            {
                file.WriteLine("Fourth line");
            }
        }
    }
    //Output (to WriteLines.txt):
    //   First line
    //   Second line
    //   Third line

    //Output (to WriteText.txt):
    //   A class is the most powerful data type in C#. Like a structure, a class defines the data and behavior of the data type.

    //Output to WriteLines2.txt after Example #3:
    //   First line
    //   Third line

    //Output to WriteLines2.txt after Example #4:
    //   First line
    //   Third line
    //   Fourth line
}
