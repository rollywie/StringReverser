using System;
using System.Diagnostics.Tracing;

internal class Program
{
    // Function Section

    public static int[] Spaces(char[] x)
    {
        int start = 0;
        List<int> Result = new();

        // Check for space, to determent where a word ends
        foreach (char c in x)
        {
            bool whiteSpaceCheck = char.IsWhiteSpace(c);

            if (whiteSpaceCheck is true)
            {
                Result.Add(start);
            }

            start++;
        }

        return Result.ToArray();
    }

    public static char[] Revers(char[] x)
    {
        int pos = 0;

        // Print values
        foreach (var item in Spaces(x) )
        {
            Console.WriteLine(item.ToString());
        }

        // Get the length of array and create array with same size
        int xLenght = x.Length;
        char[] newArray = new char[xLenght];

        foreach (char c in x)
        {   
            newArray[pos] = x[xLenght - 1];
            pos ++;
            xLenght = xLenght - 1;
        }

        return newArray;

    }

    private static void Main(string[] args)
    {
        // Explain the application
        Console.WriteLine("Please provide any string input. The application will return the reversed words in the same order");
        Console.WriteLine("To exit the application, please type 'EXIT' and press ENTER.");

        //initialize variables
        string? input;

        do
        {
            // Get user input as string from console
            input = Console.ReadLine();
            bool b = string.IsNullOrWhiteSpace(input);

            if (input != "EXIT" && b is not true)
            {
                // Split word at space and store all characters in array
                Console.WriteLine("\n");
                char[] inputChar = input.ToCharArray();

                // Function output
                Console.Write(Revers(inputChar));

                Console.WriteLine("\n");
                Console.WriteLine("Please give an other string input or type 'EXIT' to exit the application.");
            }
            else if (b is true)
            {
                Console.WriteLine("Please provide an input!");
            }
            else
            {
                Console.WriteLine("The application will be shut down!");
            }

        } while (input != "EXIT");

    }
}
