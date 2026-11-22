using System;
using System.IO;

class PROGRAM
{
    static void Main()
    {
        string fileName = "marks.txt";

        try
        {
            string[] lines = File.ReadAllLines(fileName);

            int total = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            foreach (string line in lines)
            {
                int mark = Convert.ToInt32(line);

                total += mark;

                if (mark > highest)
                    highest = mark;

                if (mark < lowest)
                    lowest = mark;
            }

            if (lines.Length > 0)
            {
                double average = (double)total / lines.Length;

                Console.WriteLine("Total = " + total);
                Console.WriteLine("Average = " + average);
                Console.WriteLine("Highest = " + highest);
                Console.WriteLine("Lowest = " + lowest);
            }
            else
            {
                Console.WriteLine("File is empty.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: marks.txt file was not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: File contains invalid marks.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}
