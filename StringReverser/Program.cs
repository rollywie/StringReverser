using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        // Explain the application
        Console.WriteLine("Please provide any string input. The application will return the reversed words in the same order");
        Console.WriteLine("To exit the application, please type 'EXIT' and press ENTER.");

        //initialize variables
        string? input = null;
        List<string> ReversedWords = new();

        do
        {
            // Get user input as string from console
            input = Console.ReadLine();
            bool b = string.IsNullOrWhiteSpace(input);

            if (input != "EXIT" && b is not true)
            {
                // Split word at space and store in List.
                Console.WriteLine("\n");
                List<string> Words = input.Split(" ").ToList();

                // Remove all values which are "" due to wrong input
                Words.RemoveAll(w => string.IsNullOrWhiteSpace(w));

                // Take each value, revers and put back to list.
                foreach (string word in Words)
                {
                    char[] strArray = word.ToCharArray();
                    Array.Reverse(strArray);
                    string reversedString = new string(strArray);
                    ReversedWords.Add(reversedString);
                }

                // Print each item from List to console and clear the list for next try.
                ReversedWords.ForEach(w => Console.Write("{0}\t", w));
                ReversedWords.Clear();

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
