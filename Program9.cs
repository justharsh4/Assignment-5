using System;
using System.IO;

class Program10
{
    static void Main9()
    {
        string fileName = "student.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Student Name: Riya");
                writer.WriteLine("Roll Number: 101");
                writer.WriteLine("Course: MCA");
                writer.WriteLine("Marks: 450");
            }

            Console.WriteLine("Student details written successfully.");

            Console.WriteLine("\nStudent Details:");

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}