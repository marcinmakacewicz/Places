﻿using System;
using System.IO;
using System.Text;

public class Note
{
    private string Description;
    private string PATH = @"C:\Users\W & M\Desktop\notatki.txt";

    public Note(string description)
    {
        description = description;
    }

    public GetDescriptionFromFile()
    {
        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Create a file to write to.
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText(path, createText, Encoding.UTF8);
        }

        // This text is always added, making the file longer over time
        // if it is not deleted.
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText, Encoding.UTF8);

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
    }
}