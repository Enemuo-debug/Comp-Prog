using System;

class Solutions
{
    public static string Encryption(string s)
    {
        string modified = s.Replace(" ", "");
        int numberOfRows = (int)Math.Floor(Math.Sqrt(modified.Length));
        int numberOfColumns = (int)Math.Ceiling(Math.Sqrt(modified.Length));
        char[,] grid = new char[numberOfRows, numberOfColumns];
        int index = 0;

        for (int i = 0; i < numberOfColumns; i++)
        {
            for (int j = 0; j < numberOfRows; j++)
            {
                if (index < modified.Length)
                {
                    grid[j, i] = modified[index];
                    index++;
                }
            }
        }

        return PrintGrid(grid, numberOfRows, numberOfColumns);
    }

    public static string PrintGrid(char[,] grid, int rows, int cols)
    {
        string outp = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                outp += grid[i, j];
            }
            outp += " ";
        }
        return outp;
    }

    public static void Main(string[] args)
    {
        string s = "   Things to do1.download capcut2.set up tools for web designOBJECTIVES1. aim to get advanced in video editing2. aim to have reached a significant height in web dev.";
        string sOut = Encryption(s);
        System.Console.WriteLine(sOut);
    }
}

/*
    CEOnly 2024
    CodeJam Question
*/